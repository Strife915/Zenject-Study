using Zenject;

namespace Decorator2
{
    public class EliteWeaponEnchantAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _weaponEnchantPercent;

        public EliteWeaponEnchantAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.EliteEnchantPercentId)] int weaponEnchantPercent)
        {
            _decorated = decorated;
            _weaponEnchantPercent = weaponEnchantPercent;
        }

        public int GetAttackDamage()
        {
            int damageWithWeapon = _decorated.GetAttackDamage();
            return damageWithWeapon + (damageWithWeapon * _weaponEnchantPercent / 100);
        }
    }
}
