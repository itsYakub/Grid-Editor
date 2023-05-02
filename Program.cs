namespace GridEditor
{
    using GridEditor.Core;

    class Program
    {
        static int Main(string[] args)
        {
            var editor = new Editor(Resolution: 16, Size: 640, Framerate: 60);

            return 0;
        }
    }
}