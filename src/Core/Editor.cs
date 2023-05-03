namespace GridEditor.Core
{
    using GridEditor.Tools;
    using GridEditor.Tiles;
    using GridEditor.Graphics;
    using Raylib_cs;

    class Editor : Window
    {
        private Grid grid;
        private Tool[] tools;

        private uint resolution = 16;
        private uint spacing = 0;

        private int currentGrid = 0;
        private int currentColor = 0;

        public Editor() : base()
        {
            EditorSetup();
        }

        public Editor(uint Resolution) : base()
        {
            uint minResolution = 2;
            uint maxResolution = 128;

            this.resolution = Resolution;
            this.resolution = Math.Clamp(this.resolution, minResolution, maxResolution);

            EditorSetup();
        }

        #region  Editor_UpdateLoop

        private void OnEditorLoad()
        {
            grid = new Grid(resolution: resolution, spacing: spacing);
            tools = new Tool[] { new Pencil(), new Eraser(), new Brush() };

            DebugCurrentColor();
        }

        private void OnEditorUpdate()
        {
            SetCurrentColor();

            grid.SetCurrentTileColor(currentColor);

            foreach (var item in tools)
            {
                item.OnToolUpdate(grid);
            }
        }

        private void OnEditorRender()
        {
            grid.RenderGridLines();
            grid.RenderGridCells();
        }

        #endregion

        #region  Editor_Setup

        private void EditorSetup()
        {
            this.spacing = Size / this.resolution;

            OnLoad += OnEditorLoad;
            OnUpdate += OnEditorUpdate;
            OnRender += OnEditorRender;

            Init();
            Run();
        }

        private void SetCurrentColor()
        {
            int minScrollValue = 0;
            int maxScrollValue = ColorPalette.Colors.Count - 1;

            if (Raylib.GetMouseWheelMove() != 0)
            {
                currentColor += (int)(Raylib.GetMouseWheelMove());

                if (currentColor < minScrollValue)
                    currentColor = maxScrollValue;

                else if (currentColor > maxScrollValue)
                    currentColor = minScrollValue;

                DebugCurrentColor();
            }
        }

        #endregion

        #region  Editor_Debuging

        private void DebugCurrentColor()
        {
            Debug.Log("Currently selected color: " + ColorPalette.Colors[currentColor].ToString());
        }

        #endregion
    }
}