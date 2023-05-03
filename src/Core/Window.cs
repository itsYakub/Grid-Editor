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

        protected const int Size = 768;
        protected const int Framerate = 60;
        private const string Title = "Grid Editor";

        public Window() { }

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