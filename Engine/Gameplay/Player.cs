using Engine.ConsoleEngine;
using Engine.EngineCore;

namespace Engine
{
    public class Player : MonoBehaviourRendererDecorator, ICollideable
    {
        private int _speed = 1;
        private Collider _collider;
        
        public Player()
        {
            _collider = new Collider(this);
        }
            
        public Player(Vector2 startPosition, char symbol, int layer, bool colliding) : this()
        {
            Position = startPosition;
            Symbol = symbol;
            Layer = layer;
            Colliding = colliding;
            Tag = "Player";
        }
    
        public void MovePlayer(Vector2 direction)
        {
            if(direction.X != 0 || direction.Y != 0)
                MoveObject(direction * _speed, _collider);
        }

        public void OnCollide(CollisionContext ctx)
        {
            if(ctx.objectTag == "Enemy")
                Environment.Exit(0);
        }
    }
}