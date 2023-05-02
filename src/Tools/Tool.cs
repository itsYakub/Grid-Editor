namespace GridEditor.Tools
{
    using GridEditor.Core;
    using Raylib_cs;

    abstract class Tool
    {
        public abstract void OnToolUpdate(Grid grid);

        protected int RecalculateMousePosition(int position, int spacing)
        {
            return (int)(position / spacing);
        }
    }
}