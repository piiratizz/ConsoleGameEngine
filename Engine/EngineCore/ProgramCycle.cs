using Engine.ConsoleEngine;

namespace Engine.EngineCore
{
    public class ProgramCycle
    {
        private static List<MonoBehaviour> _monoBehaviours = new List<MonoBehaviour>();

        public static void RegisterMonoBehaviour(MonoBehaviour mono)
        {
            _monoBehaviours.Add(mono);
        }

        public static void StartCycle()
        {
            InitMonoBehaviours();
            do
            {
                FrameManager.Build(100,50);
                StartUpdatesInMonoBehaviours();
            } while (true);
        }

        private static void InitMonoBehaviours()
        {
            foreach (var monoBeh in _monoBehaviours)
            {
                monoBeh.Start();
            }
        }

        private static void StartUpdatesInMonoBehaviours()
        {
            foreach (var monoBeh in _monoBehaviours)
            {
                monoBeh.Update();
            }
        }
    }
}