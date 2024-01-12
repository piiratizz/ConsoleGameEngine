using Engine.EngineCore;

namespace Engine.ConsoleEngine;

public interface ICollideable
{
    void OnCollide(CollisionContext ctx);
}