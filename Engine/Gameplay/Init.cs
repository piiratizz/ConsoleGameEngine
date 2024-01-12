using Engine.ConsoleEngine;
using Engine.EngineCore;

namespace Engine
{
    [GameplayInitializator]
    public class Init : IGameplayInitializator
    {
        public void Start()
        {
            Player player = new Player(startPosition: new Vector2(5,5),
                                       symbol:'@',
                                       layer: 1,
                                       colliding: true);
            
            KeyboardInput keyboardInput = new KeyboardInput(player);

            Enemy enemy = new Enemy(startPosition: new Vector2(6,8),
                                    symbol:'*',
                                    layer: 1,
                                    colliding: true);
            
            Turret turret = new Turret(startPosition: new Vector2(3,3),
                                       symbol:'%',
                                       layer: 2,
                                       colliding: false);
        }
    }
}