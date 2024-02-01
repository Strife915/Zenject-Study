using Zenject;

public class InstallerHelper : MonoInstaller
{
    public override void InstallBindings()
    {
        MyInstaller.Install(Container);
    }
}