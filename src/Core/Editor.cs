namespace GridEditor.Core
{
    using GridEditor.Tools;
    using GridEditor.Tiles;
    using GridEditor.Graphics;
    using Raylib_cs;

    class Editor : Window
    {
        private Grid[] grids;
        private Tool[] tools;

        private uint resolution = 64;
        private uint spacing = 0;

        private int currentGrid = 0;
        private int currentColor = 0;

        public Editor() : base()
        {
            EditorSetup();
        }

        public Editor(uint Resolution) : base()
        {
            this.resolution = Resolution;
            this.resolution = Math.Clamp(this.resolution, 1, Size / 2);

            EditorSetup();
        }

        public Editor(uint Resolution, uint Size, uint Framerate) : base(Size, Framerate)
        {
            this.resolution = Resolution;
            this.resolution = Math.Clamp(this.resolution, 1, Size / 2);

            EditorSetup();
        }

        public Editor(uint Resolution, uint Size, uint Framerate, Graphics.Color Background) : base(Size, Framerate, Background.ConvertToRaylibColor())
        {
            this.resolution = Resolution;
            this.resolution = Math.Clamp(this.resolution, 1, Size / 2);

            EditorSetup();
        }

        #region  Editor_UpdateLoop

        private void OnEditorLoad()
        {
            grids = new Grid[] { new Grid(resolution, spacing) };
            tools = new Tool[] { new Pencil(), new Eraser(), new Brush() };

            DebugCurrentGrid();
            DebugCurrentColor();
        }

        private void OnEditorUpdate()
        {
            SetCurrentGrid();
            SetCurrentColor();

            grids[currentGrid].SetCurrentTileColor(currentColor);

            foreach (var item in tools)
            {
                item.OnToolUpdate(grids[currentGrid]);
            }
        }

        private void OnEditorRender()
        {
            for (int i = grids.Length - 1; i >= 0; i--)
            {
                grids[i].RenderGrid();
            }
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

        private void SetCurrentGrid()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
            {
                currentGrid++;
                currentGrid = Math.Clamp(currentGrid, 0, grids.Length - 1);

                DebugCurrentGrid();
            }

            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
            {
                currentGrid--;
                currentGrid = Math.Clamp(currentGrid, 0, grids.Length - 1);

                DebugCurrentGrid();
            }
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

        private void DebugCurrentGrid()
        {
            Debug.Log("Current layer: " + currentGrid);
        }

        private void DebugCurrentColor()
        {
            Debug.Log("Currently selected color: " + ColorPalette.Colors[currentColor].ToString());
        }

        #endregion
    }
}