using Engine.EngineCore;

namespace Engine.ConsoleEngine;

public class Collider
{
    private ICollideable _collideable;
    
    public Collider(ICollideable collideable)
    {
        _collideable = collideable;
    }

    public bool CheckCollision(Vector2 position)
    {
        if (!CollisionDetector.IsCollide(position)) return false;
        _collideable.OnCollide(new CollisionContext(position, GridManager.GetCellTagAtPosition(position)));
        return true;
    }
}