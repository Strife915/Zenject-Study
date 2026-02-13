using Zenject;

namespace Decorator2
{
    public class EliteWeaponAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _weaponBonus;

        public EliteWeaponAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.EliteWeaponBonusId)] int weaponBonus)
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
