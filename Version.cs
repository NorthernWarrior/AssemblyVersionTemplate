public static class Version
    {

        public static string CompleteVersion { get { return Release + "." + Build + "." + Step + _hotFixChars[HotFix] + " " + Extra; } }

        
        private const string _hotFixChars = " abcdefghjiklmnopqrstuvwxyz";

        public static ushort Release = 0;
        public static ushort Build = 0;
        public static ushort Step = 1;
        public static ushort HotFix = 0;
        public static string Extra = "Alpha";
    }
