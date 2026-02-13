using Zenject;

namespace Decorator2
{
    public class WeaponEnchantAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _weaponEnchantPercent;

        public WeaponEnchantAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.DefaultWeaponEnchantPercentId)] int weaponEnchantPercent)
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
