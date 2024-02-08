using Zenject;

public class OOPBindInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<MyDerivedClass>().AsSingle();
        Container.BindInterfacesAndSelfTo<MyDerivedClassB>().AsSingle();
    }
}