using Engine.ConsoleEngine;
using Engine.EngineCore;

namespace Engine
{
    public class Enemy : MonoBehaviourRendererDecorator, ICollideable
    {
        public Enemy(){}
            
        public Enemy(Vector2 startPosition, char symbol, int layer, bool colliding)
        {
            Position = startPosition;
            Symbol = symbol;
            Layer = layer;
            Colliding = colliding;
            Tag = "Enemy";
        }

        public override void Update()
        {
            //if(Position.Y <= 30)
               //MoveObject(new Vector2(0,1));
            //else MoveObject(new Vector2(0,-1));
        }

        public void OnCollide(CollisionContext ctx)
        {
            
        }
    }
}