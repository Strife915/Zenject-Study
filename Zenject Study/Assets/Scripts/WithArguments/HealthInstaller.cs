using Zenject;

public class HealthInstaller : MonoInstaller
{
    public HealthSo healthSo;

    public override void InstallBindings()
    {
        Container.Bind<Health>().AsTransient().WithArguments(healthSo).NonLazy();
    }
}