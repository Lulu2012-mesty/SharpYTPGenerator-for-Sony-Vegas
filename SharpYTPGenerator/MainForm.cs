\
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SharpYTPGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtOutput.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "GeneratedYTP.cs");
            txtSeed.Text = Environment.TickCount.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var f = new FolderBrowserDialog())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    txtSource.Text = f.SelectedPath;
                }
            }
        }

        private void btnOutBrowse_Click(object sender, EventArgs e)
        {
            using (var s = new SaveFileDialog())
            {
                s.Filter = "C# Vegas Script (*.cs)|*.cs|All files (*.*)|*.*";
                s.FileName = txtOutput.Text;
                if (s.ShowDialog(this) == DialogResult.OK)
                {
                    txtOutput.Text = s.FileName;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                Cursor = Cursors.WaitCursor;

                var settings = CollectSettings();
                if (string.IsNullOrWhiteSpace(settings.SourceFolder) || !Directory.Exists(settings.SourceFolder))
                {
                    MessageBox.Show(this, "Please select a valid source folder.", "Missing folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(settings.OutputScriptPath))
                {
                    MessageBox.Show(this, "Please set an output script filename.", "Missing filename", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var files = ExpandFiles(settings.SourceFolder, settings.SearchPattern);
                if (files.Count == 0)
                {
                    MessageBox.Show(this, "No media files matched your pattern.", "No media", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var rng = new RandomUtil(settings.Seed);
                var clips = BuildRandomClips(files, settings, rng);

                VegasScriptWriter.WriteScript(settings.OutputScriptPath, clips, settings.IncludeVideo, settings.IncludeAudio);

                MessageBox.Show(this, "Done! Open Vegas Pro 14 and run the generated script:\n" + settings.OutputScriptPath, "Script generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Visible = false;
                Cursor = Cursors.Default;
            }
        }

        private YtpSettings CollectSettings()
        {
            var s = new YtpSettings();
            s.SourceFolder = txtSource.Text.Trim();
            s.SearchPattern = txtPattern.Text.Trim();
            s.NumberOfClips = (int)numClips.Value;
            s.MinClipSeconds = (double)numMin.Value;
            s.MaxClipSeconds = (double)numMax.Value;
            s.GapSeconds = (double)numGap.Value;
            s.IncludeVideo = chkVideo.Checked;
            s.IncludeAudio = chkAudio.Checked;
            s.AddHardStutter = chkStutter.Checked;
            s.StutterRepeats = (int)numStutterRepeats.Value;
            s.StutterSliceSeconds = (double)numStutterSlice.Value;
            int seed;
            if (int.TryParse(txtSeed.Text.Trim(), out seed)) s.Seed = seed;
            s.OutputScriptPath = txtOutput.Text.Trim();
            return s;
        }

        private List<string> ExpandFiles(string folder, string pattern)
        {
            var all = new List<string>();
            var exts = (pattern ?? "*.*").Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();
            foreach (var ext in exts)
            {
                try
                {
                    all.AddRange(Directory.GetFiles(folder, ext, SearchOption.AllDirectories));
                }
                catch { }
            }
            all = all.Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(p => p).ToList();
            return all;
        }

        private List<VegasScriptWriter.Clip> BuildRandomClips(List<string> files, YtpSettings s, RandomUtil rng)
        {
            var clips = new List<VegasScriptWriter.Clip>();
            for (int i = 0; i < s.NumberOfClips; i++)
            {
                var path = files[rng.NextInt(0, files.Count)];
                // Use a pseudo random offset and length; Vegas will clamp to media boundaries
                double len = Math.Max(0.01, rng.NextDouble(s.MinClipSeconds, s.MaxClipSeconds));
                double start = Math.Max(0, rng.NextDouble(0, 60)); // random offset guess
                bool stutter = s.AddHardStutter && rng.Chance(0.35);
                var c = new VegasScriptWriter.Clip
                {
                    Path = path,
                    StartOffsetSec = start,
                    LengthSec = len,
                    Stutter = stutter,
                    StutterRepeats = stutter ? Math.Max(2, s.StutterRepeats) : 1,
                    StutterSliceSec = stutter ? Math.Max(0.02, s.StutterSliceSeconds) : len
                };
                clips.Add(c);

                // optional tiny gap
                if (s.GapSeconds > 0.0001)
                {
                    clips.Add(new VegasScriptWriter.Clip
                    {
                        Path = path,
                        StartOffsetSec = start,
                        LengthSec = Math.Max(0.01, s.GapSeconds),
                        Stutter = false,
                        StutterRepeats = 1,
                        StutterSliceSec = s.GapSeconds
                    });
                }
            }
            // Remove the gap placeholder events by converting them into zero-length via Vegas cursor advance only
            // (handled by cursor += length.Seconds in writer). Nothing else needed here.
            return clips;
        }
    }
}
