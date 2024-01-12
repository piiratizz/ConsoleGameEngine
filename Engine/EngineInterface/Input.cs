using System;
using System.Threading;
using System.Threading.Tasks;

namespace Engine.ConsoleEngine
{
    public static class Input
    {
        private static ConsoleKey key;

        public static void StartAsyncInputHandle()
        {
            Task.Run(() =>
            {
                do
                {
                    key = Console.ReadKey(true).Key;
                } while (true);
            });
        }
        public static int GetAxis(Axis axis)
        {
            
            if (axis == Axis.Horizontal)
            {
                if (key == ConsoleKey.D) return 1;
                if (key == ConsoleKey.A) return -1;
            }
            else if (axis == Axis.Vertical)
            {
                if (key == ConsoleKey.W) return -1;
                if (key == ConsoleKey.S) return 1;
            }
            
            return 0;
        }
    }
}