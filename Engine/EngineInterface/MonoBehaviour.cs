using Engine.EngineCore;

namespace Engine.ConsoleEngine
{
    public abstract class MonoBehaviour
    {
        protected MonoBehaviour()
        {
            ProgramCycle.RegisterMonoBehaviour(this);
        }
        public virtual void Update(){}
        public virtual void Start(){}
    }
}