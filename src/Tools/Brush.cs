namespace GridEditor.Tools
{
    using GridEditor.Core;
    using Raylib_cs;

    class Brush : Tool
    {
        public override void OnToolUpdate(Grid grid)
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_C))
            {
                grid.ClearGrid();
            }
        }
    }
}