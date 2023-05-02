namespace GridEditor.Core
{
    using GridEditor.Tiles;
    using GridEditor.Graphics;
    using Raylib_cs;

    class Point
    {
        private Tile? tile = null;

        public int x = 0;
        public int y = 0;

        private int size = 0;

        public Point(int x, int y, int size)
        {
            this.x = x;
            this.y = y;

            this.size = size;
        }

        public void Render()
        {
            if (Contains())
                tile.Render(x, y, size);
        }

        public Tile GetTile() { return this.tile; }

        public void SetTile(Tile tile) { this.tile = tile; }

        public bool Contains() { return this.GetTile() != null; }

        public void RemoveTile() { if (Contains()) this.tile = null; }
    }
}