\
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SharpYTPGenerator
{
    public class VegasScriptWriter
    {
        public class Clip
        {
            public string Path;
            public double StartOffsetSec;
            public double LengthSec;
            public bool Stutter;
            public int StutterRepeats;
            public double StutterSliceSec;
        }

        public static void WriteScript(string outPath, List<Clip> clips, bool includeVideo, bool includeAudio)
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using Sony.Vegas;");
            sb.AppendLine("");
            sb.AppendLine("public class EntryPoint {");
            sb.AppendLine("  public void FromVegas(Vegas vegas) {");
            sb.AppendLine("    Project proj = vegas.Project;");
            sb.AppendLine("    VideoTrack vTrack = new VideoTrack();");
            sb.AppendLine("    AudioTrack aTrack = new AudioTrack();");
            sb.AppendLine("    if (" + includeVideo.ToString().ToLower() + ") proj.Tracks.Add(vTrack);");
            sb.AppendLine("    if (" + includeAudio.ToString().ToLower() + ") proj.Tracks.Add(aTrack);");
            sb.AppendLine("    double cursor = 0.0;");
            sb.AppendLine("    Media media;");
            sb.AppendLine("    Timecode start, length;");
            sb.AppendLine("");

            // Emit media list grouped to reduce Vegas 'new Media' overhead
            for (int i = 0; i < clips.Count; i++)
            {
                var c = clips[i];
                string esc = c.Path.Replace("\\", "\\\\").Replace("\"", "\\\"");
                sb.AppendLine("    // Clip #" + (i + 1));
                sb.AppendLine("    media = new Media(\"" + esc + "\");");
                sb.AppendLine("    start = Timecode.FromSeconds(" + c.StartOffsetSec.ToString("0.###", System.Globalization.CultureInfo.InvariantCulture) + ");");
                sb.AppendLine("    length = Timecode.FromSeconds(" + c.LengthSec.ToString("0.###", System.Globalization.CultureInfo.InvariantCulture) + ");");

                if (includeVideo)
                {
                    sb.AppendLine("    try {");
                    sb.AppendLine("      if (media.HasVideo()) {");
                    sb.AppendLine("        VideoEvent ve = new VideoEvent(Timecode.FromSeconds(cursor), length);");
                    sb.AppendLine("        vTrack.Events.Add(ve);");
                    sb.AppendLine("        Take vTake = new Take(media.GetVideoStreamByIndex(0), start);");
                    sb.AppendLine("        ve.Takes.Add(vTake);");
                    sb.AppendLine("      }");
                    sb.AppendLine("    } catch (Exception) {}");
                }

                if (includeAudio)
                {
                    sb.AppendLine("    try {");
                    sb.AppendLine("      if (media.HasAudio()) {");
                    if (clips[i].Stutter && clips[i].StutterRepeats > 1)
                    {
                        // Create a stutter by slicing a very short audio piece multiple times
                        sb.AppendLine("        double local = cursor;");
                        sb.AppendLine("        int reps = " + clips[i].StutterRepeats + ";");
                        sb.AppendLine("        Timecode slice = Timecode.FromSeconds(" + clips[i].StutterSliceSec.ToString("0.###", System.Globalization.CultureInfo.InvariantCulture) + ");");
                        sb.AppendLine("        for (int r = 0; r < reps; r++) {");
                        sb.AppendLine("          AudioEvent ae = new AudioEvent(Timecode.FromSeconds(local), slice);");
                        sb.AppendLine("          aTrack.Events.Add(ae);");
                        sb.AppendLine("          Take aTake = new Take(media.GetAudioStreamByIndex(0), start);");
                        sb.AppendLine("          ae.Takes.Add(aTake);");
                        sb.AppendLine("          local += slice.Seconds;");
                        sb.AppendLine("        }");
                    }
                    else
                    {
                        sb.AppendLine("        AudioEvent ae = new AudioEvent(Timecode.FromSeconds(cursor), length);");
                        sb.AppendLine("        aTrack.Events.Add(ae);");
                        sb.AppendLine("        Take aTake = new Take(media.GetAudioStreamByIndex(0), start);");
                        sb.AppendLine("        ae.Takes.Add(aTake);");
                    }
                    sb.AppendLine("      }");
                    sb.AppendLine("    } catch (Exception) {}");
                }

                sb.AppendLine("    cursor += length.Seconds;");
                sb.AppendLine("");
            }

            sb.AppendLine("  }");
            sb.AppendLine("}");
            File.WriteAllText(outPath, sb.ToString(), new UTF8Encoding(false));
        }
    }
}
