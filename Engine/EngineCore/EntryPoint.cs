using System.Reflection;
using Engine.ConsoleEngine;
using Engine.EngineCore;

namespace Engine.EngineCore
{
  internal class EntryPoint
  {
    
    public static void Main()
    {
      InitializatorInstancer.GetInstance()?.Start();
      Input.StartAsyncInputHandle();
      ProgramCycle.StartCycle();
    }
  }
}