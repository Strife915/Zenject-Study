using Zenject;

namespace Decorator2
{
    public class WeaponAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _weaponBonusDamage;

        public WeaponAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.WeaponBonusId)] int weaponBonusDamage)
        {
            _decorated = decorated;
            _weaponBonusDamage = weaponBonusDamage;
        }

        public int GetAttackDamage()
        {
            return _decorated.GetAttackDamage() + _weaponBonusDamage;
        }
    }
}
