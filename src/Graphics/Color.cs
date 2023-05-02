namespace GridEditor.Graphics
{
    using System.Drawing;
    using GridEditor.Core;
    using Raylib_cs;

    class Color
    {
        public int R { get; set; } = 0;
        public int G { get; set; } = 0;
        public int B { get; set; } = 0;
        public int A { get; set; } = 255;

        public Color() { }

        public Color(int R, int G, int B, int A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;

            this.R = Math.Clamp(this.R, 0, 255);
            this.G = Math.Clamp(this.G, 0, 255);
            this.B = Math.Clamp(this.B, 0, 255);
            this.A = Math.Clamp(this.A, 0, 255);
        }

        public Color(int R, int G, int B)
        {
            this.R = R;
            this.G = G;
            this.B = B;

            this.R = Math.Clamp(this.R, 0, 255);
            this.G = Math.Clamp(this.G, 0, 255);
            this.B = Math.Clamp(this.B, 0, 255);
            this.A = Math.Clamp(this.A, 0, 255);
        }

        public Color(string hex)
        {
            System.Drawing.Color color = new System.Drawing.Color();

            try
            {
                color = ColorTranslator.FromHtml(hex);
            }

            catch (System.Exception)
            {
                Debug.LogError("Couldn't translate a hexadecimal value!");
            }

            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
            this.A = color.A;
        }

        public Raylib_cs.Color ConvertToRaylibColor()
        {
            return new Raylib_cs.Color(this.R, this.G, this.B, this.A);
        }

        public override string ToString()
        {
            return this.R + "/" + this.G + "/" + this.B;
        }
    }
}