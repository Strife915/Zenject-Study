using UnityEngine;
using Zenject;

public class InitializationInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<InitTestA>().AsSingle().NonLazy();
        Container.BindInterfacesTo<InitTestB>().AsSingle().NonLazy();

        Container.BindExecutionOrder<InitTestA>(-5);
        Container.BindExecutionOrder<InitTestB>(-10);
    }
}

public class InitTestA : IInitializable
{
    public InitTestA()
    {
        Debug.Log("Init A created");
    }

    public void Initialize()
    {
        Debug.Log("Inıt A init");
    }
}

public class InitTestB : IInitializable
{
    public InitTestB()
    {
        Debug.Log("Init test B created");
    }

    public void Initialize()
    {
        Debug.Log("Init B init");
    }
}