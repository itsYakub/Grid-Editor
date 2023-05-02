namespace GridEditor.Tiles
{
    using GridEditor.Core;
    using GridEditor.Graphics;
    using Raylib_cs;

    class Tile
    {
        public Graphics.Color color { get; private set; }

        public Tile(Graphics.Color color)
        {
            this.color = color;
        }

        public void Render(int x, int y, int size)
        {
            Raylib.DrawRectangle(x, y, size, size, color.ConvertToRaylibColor());
        }
    }
}