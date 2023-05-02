namespace GridEditor.Graphics
{
    // source: https://lospec.com/palette-list/pico-8
    struct ColorPalette
    {
        public static Color White = new Color("#FFF1E8");
        public static Color Black = new Color("#000000");
        public static Color Red = new Color("#FF004D");
        public static Color Pink = new Color("#FF77A8");
        public static Color Eggplant = new Color("#7E2553");
        public static Color Brown = new Color("#AB5236");
        public static Color Oragne = new Color("#FFA300");
        public static Color Yellow = new Color("#FFEC27");
        public static Color Cream = new Color("#FFCCAA");
        public static Color VoxatronPurple = new Color("#7E2553");
        public static Color Blue = new Color("#29ADFF");
        public static Color DarkBlue = new Color("#1D2B53");
        public static Color DarkGreen = new Color("#008751");
        public static Color Green = new Color("#00E436");
        public static Color LightGray = new Color("#C2C3C7");
        public static Color DarkGray = new Color("#5F574F");

        public static List<Color> Colors { get; } = new List<Color>()
        {
            White,
            Black,
            Red,
            Pink,
            Eggplant,
            Brown,
            Oragne,
            Yellow,
            Cream,
            VoxatronPurple,
            Blue,
            DarkBlue,
            DarkGreen,
            Green,
            LightGray,
            DarkGray
        };
    }
}