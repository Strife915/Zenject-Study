using Zenject;

public class ComplexSignalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.BindInterfacesAndSelfTo<ConcreteSignal>().AsSingle();
        Container.BindInterfacesAndSelfTo<ComplexSignalSub>().AsSingle().NonLazy();
        Container.DeclareSignal<IComplexSignal>();
        //Container.DeclareSignal<ConcreteSignal>();
    }
}

public interface IComplexSignal
{
    void Signal();
}