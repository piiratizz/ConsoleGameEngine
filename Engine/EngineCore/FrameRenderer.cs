using System;
using Engine.EngineCore;

namespace Engine.EngineCore
{
    public class FrameRenderer
    {
        public void Render(Frame frame)
        {
            Console.SetCursorPosition(0,0);
            Console.CursorVisible = false;
            
            for (int i = 0; i < frame.Width; i++)
            {
                for (int j = 0; j < frame.Height; j++)
                {
                    Console.Write(frame.Bitmap[i,j].Cell.Symbol);
                }
                Console.Write("\n");
            }
        }
    }
}