using Zenject;

namespace Decorator2
{
    public class EliteAttackerInstaller : Installer<EliteAttackerInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IAttacker>().To<EliteBaseAttacker>().AsTransient();
            Container.Decorate<IAttacker>().With<EliteWeaponAttackerDecorator>();
            Container.Decorate<IAttacker>().With<EliteWeaponEnchantAttackerDecorator>();
            Container.Decorate<IAttacker>().With<EliteBerserkAttackerDecorator>();
        }
    }
}
