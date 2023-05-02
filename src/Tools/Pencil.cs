namespace GridEditor.Tools
{
    using GridEditor.Core;
    using Raylib_cs;

    class Pencil : Tool
    {
        public override void OnToolUpdate(Grid grid)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_LEFT))
            {
                var x = RecalculateMousePosition(Raylib.GetMouseX(), grid.Spacing);
                var y = RecalculateMousePosition(Raylib.GetMouseY(), grid.Spacing);

                grid.SetTile(x, y);
            }
        }
    }
}