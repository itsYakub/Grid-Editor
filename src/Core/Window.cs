namespace GridEditor.Core
{
    using static Raylib_cs.Raylib;
    using Raylib_cs;

    class Window
    {
        protected Action? OnLoad;
        protected Action? OnUpdate;
        protected Action? OnRender;

        public Color Background { get; set; } = new Color(25, 42, 86, 255);

        public uint Size { get; set; } = 512;
        public uint Framerate { get; set; } = 60;

        private const string Title = "Grid Editor";

        public Window() { }
        public Window(uint Size, uint Framerate) { this.Size = Size; this.Framerate = Framerate; }
        public Window(uint Size, uint Framerate, Color Background) { this.Size = Size; this.Framerate = Framerate; this.Background = Background; }

        public void Init()
        {
            InitWindow((int)Size, (int)Size, Title);
            InitAudioDevice();

            SetTargetFPS((int)Framerate);
        }

        public void Run()
        {
            OnLoad();

            while (!WindowShouldClose())
            {
                Raylib.ClearBackground(Background);

                OnUpdate();

                BeginDrawing();

                OnRender();

                EndDrawing();
            }

            CloseAudioDevice();
            CloseWindow();
        }
    }
}