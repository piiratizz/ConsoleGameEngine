using System.Runtime.CompilerServices;
using Engine.EngineCore;

namespace Engine.ConsoleEngine
{
    public class MonoBehaviourRendererDecorator : MonoBehaviour, IRenderer
    {
        public Vector2 Position { get; set; }
        public char Symbol { get; set; } = '*';
        public int Layer { get; set; } = 1;
        public bool Colliding { get; set; } = false;
        public string Tag { get; set; } = "Default";
        
        
        public MonoBehaviourRendererDecorator()
        {
            FrameManager.RegisterRenderer(this);
        }
        
        public void MoveObject(Vector2 newPosition)
        {
            Position += newPosition;
        }
        
        public void MoveObject(Vector2 newPosition, Collider collider)
        {
            if(!collider.CheckCollision(Position + newPosition))
                Position += newPosition;
        }
    }
}