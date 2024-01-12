using Engine.ConsoleEngine;

namespace Engine
{
    public class KeyboardInput : MonoBehaviour
    {
        private Player _player;

        public KeyboardInput(Player player)
        {
            _player = player;
        }
        
        public override void Update()
        {
            var directionVertical = Input.GetAxis(Axis.Vertical);
            var directionHorizontal = Input.GetAxis(Axis.Horizontal);
            
            _player.MovePlayer(new Vector2(directionVertical, directionHorizontal));
        }
    }
}