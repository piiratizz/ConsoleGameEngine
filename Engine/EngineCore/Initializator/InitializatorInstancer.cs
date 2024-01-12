using System.Reflection;

namespace Engine.EngineCore;

public static class InitializatorInstancer
{
    public static IGameplayInitializator? GetInstance()
    {
        Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        foreach (Type type in types)
        {
            if (type.GetCustomAttributes(typeof(GameplayInitializatorAttribute), true).Length > 0)
            {
                if (type.FullName != null)
                    return (IGameplayInitializator)Activator.CreateInstance(Type.GetType(type.FullName) ?? throw new InvalidOperationException())!;
            }
        }

        return null;
    }
}