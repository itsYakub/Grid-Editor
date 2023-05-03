# Grid-Editor
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

Minimalistic pixel art editor, made with Raylib in C#.

# Features:
- Users can choose from 16 different color options within the program's interface;
- The program utilizes a focused selection of key inputs for its workflow;
- Users have the freedom to choose grid sizes within the range of 2x2 up to 128x128;

# Usage:
```csharp
class Program
{
    static int Main(string[] args)
    {
        var editor = new Editor(Resolution: 16);

        return 0;
    }
}
```

# Credits:
- PICO-8 Palette: https://lospec.com/palette-list/pico-8
- OpenAI ChatGPT: https://chat.openai.com
- Raylib-cs: https://github.com/ChrisDill/Raylib-cs;

# Licence:
[MIT](https://choosealicense.com/licenses/mit/)
