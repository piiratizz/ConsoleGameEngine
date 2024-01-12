using Engine.ConsoleEngine;

namespace Engine
{
    public class Turret : MonoBehaviourRendererDecorator
    {
        public Turret(){}
            
        public Turret(Vector2 startPosition, char symbol, int layer, bool colliding)
        {
            Position = startPosition;
            Symbol = symbol;
            Layer = layer;
            Colliding = colliding;
        }
    }
}