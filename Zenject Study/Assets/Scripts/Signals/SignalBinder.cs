using UnityEngine;
using Zenject;

public class SignalBinder : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MySignalClass>().AsSingle();
        Container.DeclareSignal<MySignalClass>();
    }
}

public class MySignalClass
{
    public void MySignalMethod() => Debug.Log("My signal fire");
    public int MyTestAttribute { get; set; } = 1;
}