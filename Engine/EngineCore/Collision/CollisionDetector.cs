using Engine.ConsoleEngine;

namespace Engine.EngineCore
{
    public static class CollisionDetector
    {
        private static Frame? _frame;

        public static void UpdateFrame(Frame newFrame)
        {
            _frame = newFrame;
        }

        public static bool IsCollide(Vector2 position)
        {
            return _frame?.Bitmap[position.X, position.Y].Cell.Colliding == true;
        }
    }
}