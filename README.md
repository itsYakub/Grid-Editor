# Grid-Editor
[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

Minimalistic pixel art editor, made with Raylib in C#.

# Features:
- Users can choose from <b>16 different color</b> options within the program's interface;
- The program utilizes a focused selection of key inputs for its workflow;
- Users have the freedom to choose grid sizes within the range of <b>2x2</b> up to <b>128x128</b>;

# Building and Running:
<b>Steps of getting Grid Editor up and running:</b>
1. Clone this repository;
2. Save the files in the direction of your choosing;
3. Open the `GridEditor.csproj` in the IDE or Text Editor of your choosing (recomendedly `Visual Studio` or any other IDE with built-in c# compiler);
4. Run the project!

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

# Workflow:
Section dedicated to describle how to work with Grid Editor:
- <b>Pencil <i>(drawing pixels to the grid)</i>:</b> `Left Mouse Button`;
- <b>Eraser <i>(clearing pixels from the grid)</i>:</b> `Right Mouse Button`;
- <b>Brush <i>(clearing the entire grid at once)</i>:</b> `C Keyboard Key`;
- <b>Switching colors:</b> `Mouse Scroll Wheel`;

# Credits:
- <b>PICO-8 Palette:</b> https://lospec.com/palette-list/pico-8
- <b>OpenAI ChatGPT:</b> https://chat.openai.com
- <b>Raylib-cs:</b> https://github.com/ChrisDill/Raylib-cs;

# Licence:
[MIT](https://choosealicense.com/licenses/mit/)
