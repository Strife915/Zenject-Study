using Zenject;

public class SignalBinder : MonoInstaller
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
    }
}