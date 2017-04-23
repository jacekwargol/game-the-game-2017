using OpenTK.Graphics;
using SunshineConsole;

namespace GameTheGame2017 {
    static class GameWindow {
        public static int Width { get; set; } = 120;
        public static int Height { get; set; } = 60;

        public static ConsoleWindow Window = new ConsoleWindow(Height, Width, "The Game");

        public static void ClearConsole() {
            for(int i = 0; i < Window.Width; i++) {
                for(int j = 0; j < Window.Height; j++) {
                    Window.Write(i, j, " ", Color4.Black);
                }
            }
        }   
    }
}
