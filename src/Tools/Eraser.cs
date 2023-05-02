namespace GridEditor.Tools
{
    using GridEditor.Core;
    using Raylib_cs;

    class Eraser : Tool
    {
        public override void OnToolUpdate(Grid grid)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_BUTTON_RIGHT))
            {
                var x = RecalculateMousePosition(Raylib.GetMouseX(), grid.Spacing);
                var y = RecalculateMousePosition(Raylib.GetMouseY(), grid.Spacing);

                grid.RemoveTile(x, y);
            }
        }
    }
}