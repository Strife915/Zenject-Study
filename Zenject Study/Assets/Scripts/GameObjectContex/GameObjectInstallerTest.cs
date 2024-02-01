using Zenject;

public class GameObjectInstallerTest : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<InjectClassTest>().AsTransient();
    }
}