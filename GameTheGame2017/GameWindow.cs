using SunshineConsole;
using OpenTK.Graphics;
using OpenTK.Input;


namespace GameTheGame2017 {
    static class GameWindow {
        public static int Width { get; set; } = 120;
        public static int Height { get; set; } = 60;

        public static ConsoleWindow window = new ConsoleWindow(Height, Width, "The Game");

        public static void ClearConsole() {
            for(int i = 0; i < window.Width; i++) {
                for(int j = 0; j < window.Height; j++) {
                    window.Write(i, j, " ", Color4.Black);
                }
            }
        }   
    }
}
