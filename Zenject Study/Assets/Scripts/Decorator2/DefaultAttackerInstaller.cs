using Zenject;

namespace Decorator2
{
    public class DefaultAttackerInstaller : Installer<DefaultAttackerInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IAttacker>().To<BaseAttacker>().AsTransient();
            Container.Decorate<IAttacker>().With<WeaponAttackerDecorator>();
            Container.Decorate<IAttacker>().With<WeaponEnchantAttackerDecorator>();
        }
    }
}
