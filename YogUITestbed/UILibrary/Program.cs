using System;

namespace YogUITestBed
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        //NOTE: You must set the current thread to STAThread for TextFields to work with ContextMenus/CopyPasting
        [STAThread]
        static void Main(string[] args)
        {
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
#endif
}

