using System;
using System.Windows.Forms;

namespace SharpYTPGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numClips = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkVideo = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.chkStutter = new System.Windows.Forms.CheckBox();
            this.numStutterRepeats = new System.Windows.Forms.NumericUpDown();
            this.numStutterSlice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOutBrowse = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numGap = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numClips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStutterRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStutterSlice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(16, 32);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(456, 20);
            this.txtSource.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(478, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source media path";
            // 
            // numClips
            // 
            this.numClips.Location = new System.Drawing.Point(16, 101);
            this.numClips.Maximum = new decimal(new int[] {1000,0,0,0});
            this.numClips.Minimum = new decimal(new int[] {1,0,0,0});
            this.numClips.Name = "numClips";
            this.numClips.Size = new System.Drawing.Size(92, 20);
            this.numClips.TabIndex = 3;
            this.numClips.Value = new decimal(new int[] {40,0,0,0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "# of snippets";
            // 
            // numMin
            // 
            this.numMin.DecimalPlaces = 2;
            this.numMin.Increment = new decimal(new int[] {1,0,0,131072});
            this.numMin.Location = new System.Drawing.Point(139, 101);
            this.numMin.Maximum = new decimal(new int[] {60,0,0,0});
            this.numMin.Minimum = new decimal(new int[] {1,0,0,131072});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(92, 20);
            this.numMin.TabIndex = 5;
            this.numMin.Value = new decimal(new int[] {25,0,0,131072});
            // 
            // numMax
            // 
            this.numMax.DecimalPlaces = 2;
            this.numMax.Increment = new decimal(new int[] {1,0,0,131072});
            this.numMax.Location = new System.Drawing.Point(252, 101);
            this.numMax.Maximum = new decimal(new int[] {120,0,0,0});
            this.numMax.Minimum = new decimal(new int[] {1,0,0,131072});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(92, 20);
            this.numMax.TabIndex = 6;
            this.numMax.Value = new decimal(new int[] {250,0,0,131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min len (seconds)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max len (seconds)";
            // 
            // chkVideo
            // 
            this.chkVideo.AutoSize = true;
            this.chkVideo.Checked = true;
            this.chkVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVideo.Location = new System.Drawing.Point(16, 136);
            this.chkVideo.Name = "chkVideo";
            this.chkVideo.Size = new System.Drawing.Size(53, 17);
            this.chkVideo.TabIndex = 9;
            this.chkVideo.Text = "Video";
            this.chkVideo.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Checked = true;
            this.chkAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAudio.Location = new System.Drawing.Point(86, 136);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(53, 17);
            this.chkAudio.TabIndex = 10;
            this.chkAudio.Text = "Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // chkStutter
            // 
            this.chkStutter.AutoSize = true;
            this.chkStutter.Checked = true;
            this.chkStutter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStutter.Location = new System.Drawing.Point(16, 168);
            this.chkStutter.Name = "chkStutter";
            this.chkStutter.Size = new System.Drawing.Size(122, 17);
            this.chkStutter.TabIndex = 11;
            this.chkStutter.Text = "Add audio stutter";
            this.chkStutter.UseVisualStyleBackColor = true;
            // 
            // numStutterRepeats
            // 
            this.numStutterRepeats.Location = new System.Drawing.Point(160, 166);
            this.numStutterRepeats.Maximum = new decimal(new int[] {16,0,0,0});
            this.numStutterRepeats.Minimum = new decimal(new int[] {1,0,0,0});
            this.numStutterRepeats.Name = "numStutterRepeats";
            this.numStutterRepeats.Size = new System.Drawing.Size(71, 20);
            this.numStutterRepeats.TabIndex = 12;
            this.numStutterRepeats.Value = new decimal(new int[] {3,0,0,0});
            // 
            // numStutterSlice
            // 
            this.numStutterSlice.DecimalPlaces = 2;
            this.numStutterSlice.Increment = new decimal(new int[] {1,0,0,131072});
            this.numStutterSlice.Location = new System.Drawing.Point(278, 166);
            this.numStutterSlice.Maximum = new decimal(new int[] {5,0,0,0});
            this.numStutterSlice.Minimum = new decimal(new int[] {1,0,0,131072});
            this.numStutterSlice.Name = "numStutterSlice";
            this.numStutterSlice.Size = new System.Drawing.Size(66, 20);
            this.numStutterSlice.TabIndex = 13;
            this.numStutterSlice.Value = new decimal(new int[] {8,0,0,131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "x repeats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "slice (seconds)";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 257);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(537, 33);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate Vegas Script (.cs)";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 218);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(456, 20);
            this.txtOutput.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Output script filename";
            // 
            // btnOutBrowse
            // 
            this.btnOutBrowse.Location = new System.Drawing.Point(478, 216);
            this.btnOutBrowse.Name = "btnOutBrowse";
            this.btnOutBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOutBrowse.TabIndex = 19;
            this.btnOutBrowse.Text = "Browse...";
            this.btnOutBrowse.UseVisualStyleBackColor = true;
            this.btnOutBrowse.Click += new System.EventHandler(this.btnOutBrowse_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(537, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.Visible = false;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(16, 64);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(456, 20);
            this.txtPattern.TabIndex = 20;
            this.txtPattern.Text = "*.mp4;*.mov;*.mkv;*.avi;*.wmv;*.mp3;*.wav";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "File extensions";
            // 
            // numGap
            // 
            this.numGap.DecimalPlaces = 2;
            this.numGap.Increment = new decimal(new int[] {1,0,0,131072});
            this.numGap.Location = new System.Drawing.Point(370, 101);
            this.numGap.Maximum = new decimal(new int[] {5,0,0,0});
            this.numGap.Name = "numGap";
            this.numGap.Size = new System.Drawing.Size(92, 20);
            this.numGap.TabIndex = 22;
            this.numGap.Value = new decimal(new int[] {5,0,0,131072});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Gap (seconds)";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(478, 101);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(75, 20);
            this.txtSeed.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Seed";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(568, 331);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numGap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnOutBrowse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numStutterSlice);
            this.Controls.Add(this.numStutterRepeats);
            this.Controls.Add(this.chkStutter);
            this.Controls.Add(this.chkAudio);
            this.Controls.Add(this.chkVideo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numClips);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSource);
            this.Name = "MainForm";
            this.Text = "SharpYTPGenerator (Vegas Pro 14 script generator)";
            ((System.ComponentModel.ISupportInitialize)(this.numClips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStutterRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStutterSlice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtSource;
        private Button btnBrowse;
        private Label label1;
        private NumericUpDown numClips;
        private Label label2;
        private NumericUpDown numMin;
        private NumericUpDown numMax;
        private Label label3;
        private Label label4;
        private CheckBox chkVideo;
        private CheckBox chkAudio;
        private CheckBox chkStutter;
        private NumericUpDown numStutterRepeats;
        private NumericUpDown numStutterSlice;
        private Label label5;
        private Label label6;
        private Button btnGenerate;
        private TextBox txtOutput;
        private Label label7;
        private Button btnOutBrowse;
        private ProgressBar progressBar1;
        private TextBox txtPattern;
        private Label label8;
        private NumericUpDown numGap;
        private Label label9;
        private TextBox txtSeed;
        private Label label10;
    }
}
