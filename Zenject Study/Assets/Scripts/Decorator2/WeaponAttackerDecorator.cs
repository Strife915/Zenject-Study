using Zenject;

namespace Decorator2
{
    public class WeaponAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _weaponBonus;

        public WeaponAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.DefaultWeaponBonusId)] int weaponBonus)
        {
            _decorated = decorated;
            _weaponBonus = weaponBonus;
        }

        public int GetAttackDamage()
        {
            return _decorated.GetAttackDamage() + _weaponBonus;
        }
    }
}
