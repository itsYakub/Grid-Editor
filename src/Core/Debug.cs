namespace GridEditor.Core
{
    struct Debug
    {
        public static void Log(params object[] message)
        {
            foreach (var item in message)
            {
                System.Console.WriteLine("Grid Editor: " + item);
            }
        }

        public static void LogError(params object[] message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            foreach (var item in message)
            {
                System.Console.WriteLine("Grid Editor, Error: " + item);
            }

            Console.ResetColor();
        }
    }
}