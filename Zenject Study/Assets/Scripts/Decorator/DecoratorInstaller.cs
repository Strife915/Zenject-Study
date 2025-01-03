using Zenject;

public class DecoratorInstaller : MonoInstaller
{
    public override void InstallBindings() {
        SignalBusInstaller.Install(Container);
        InstallValues();
        DeclareSignals();
        InstallFactories();
        InstallDecoratedValues();
    }

    void InstallValues() {
        Container.BindInterfacesAndSelfTo<PlayerBaseAttackDamage>().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerInGameBonusAttackDamage>().AsSingle();
        Container.BindInterfacesAndSelfTo<PlayerCriticalHitChance>().AsSingle();
    }

    void InstallFactories() {
        Container.BindFactory<int, PlayerAttackDamageFactory>()
            .FromFactory<CustomAttackDamageFactory>();
    }

    void InstallDecoratedValues() {
        Container.Bind<PlayerAttackHandler>().AsSingle();
    }

    void DeclareSignals() {
        Container.DeclareSignal<ValueChangeSignal>();
        Container.DeclareSignal<UpgradeSignal>();
    }

    public struct ValueChangeSignal
    {
        public IIntValue IntValue { get; set; }
    }

    public struct UpgradeSignal
    {
    }
}