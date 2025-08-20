using System;

namespace SharpYTPGenerator
{
    public class YtpSettings
    {
        public string SourceFolder { get; set; }
        public string SearchPattern { get; set; } = "*.mp4;*.mov;*.mkv;*.avi;*.wmv;*.mp3;*.wav";
        public int NumberOfClips { get; set; } = 40;
        public double MinClipSeconds { get; set; } = 0.25;
        public double MaxClipSeconds { get; set; } = 2.5;
        public double GapSeconds { get; set; } = 0.05;
        public bool AddHardStutter { get; set; } = true;
        public int StutterRepeats { get; set; } = 3;
        public double StutterSliceSeconds { get; set; } = 0.08;
        public int Seed { get; set; } = Environment.TickCount;

        public bool IncludeAudio { get; set; } = true;
        public bool IncludeVideo { get; set; } = true;
        public string OutputScriptPath { get; set; }
    }
}
