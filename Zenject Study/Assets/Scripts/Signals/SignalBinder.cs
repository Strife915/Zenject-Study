using Zenject;

public class SignalBinder : MonoInstaller
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.Bind<MySignalClass>().AsSingle();
        Container.DeclareSignal<MySignalClass>();
    }
}