using UnityEngine;
using Zenject;

public abstract class MyBaseClass : IInitializable, IMyInterface
{
    public virtual void Initialize()
    {
        Debug.Log("1");
    }

    public virtual void Log()
    {
    }
}

public interface IMyInterface
{
    void Log();
}