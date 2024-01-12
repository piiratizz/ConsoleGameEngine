using Engine.ConsoleEngine;

namespace Engine.EngineCore;

public class CollisionContext
{
    public Vector2 position;
    public string objectTag;

    public CollisionContext(Vector2 position, string objectTag)
    {
        this.position = position;
        this.objectTag = objectTag;
    }
}