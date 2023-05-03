namespace GridEditor.Core
{
    using GridEditor.Tiles;
    using Raylib_cs;

    class Grid
    {
        public Point[,] points;

        private Graphics.Color currentColor = Graphics.ColorPalette.Colors[0];

        public int Resolution { get; private set; } = 0;
        public int Spacing { get; private set; } = 24;

        public Grid(uint resolution, uint spacing)
        {
            this.Resolution = (int)resolution;
            this.Spacing = (int)spacing;

            GenerateGrid(resolution, spacing);

            Debug.Log("Created a " + resolution + "x" + resolution + " grid!");
        }

        public void RenderGridCells()
        {
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j].Render();
                }
            }
        }

        public void RenderGridLines()
        {
            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    if (!points[i, j].Contains())
                        Raylib.DrawRectangleLines(points[i, j].x, points[i, j].y, Spacing, Spacing, new Color(245, 245, 245, 127));

                }
            }
        }

        private void GenerateGrid(uint resolution, uint spacing)
        {
            points = new Point[resolution, resolution];

            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j] = new Point(i * (int)spacing, j * (int)spacing, (int)spacing);
                }
            }
        }

        private bool ValidatePosition(int x, int y)
        {
            bool result = new bool();

            if (x >= 0 && x < points.GetLength(0) && y >= 0 && y < points.GetLength(1))
                result = true;

            else
            {
                Debug.LogError("Coordinates x: " + (x + 1) + " and/or y: " + (y + 1) + " doesn't fit in the grid!");
                result = false;
            }

            return result;
        }

        public void SetCurrentTileColor(int index)
        {
            currentColor = Graphics.ColorPalette.Colors[index];
        }

        public void SetTile(int x, int y)
        {
            if (ValidatePosition(x, y))
                points[x, y].SetTile(new Tile(currentColor));
        }

        public void RemoveTile(int x, int y)
        {
            if (ValidatePosition(x, y))
                points[x, y].RemoveTile();
        }

        public void ClearGrid()
        {
            foreach (var item in points)
            {
                item.RemoveTile();
            }
        }
    }
}