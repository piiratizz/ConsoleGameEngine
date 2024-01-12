using Engine.ConsoleEngine;

namespace Engine.EngineCore
{
    public interface IRenderer
    {
        Vector2 Position { get;  set; }
        char Symbol { get; set; }
        int Layer { get; set; }
        bool Colliding { get; set; }
        string Tag { get; set; }
        
        void MoveObject(Vector2 newPosition);
    }
}