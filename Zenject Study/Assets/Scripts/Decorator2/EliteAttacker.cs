using Zenject;

namespace Decorator2
{
    public class EliteAttacker : IAttacker
    {
        readonly int _baseAttackDamage;
        readonly int _weaponBonusDamage;
        readonly int _weaponEnchantPercent;

        public EliteAttacker(
            [Inject(Id = Decorator2Installer.EliteBaseDamageId)] int baseAttackDamage,
            [Inject(Id = Decorator2Installer.EliteWeaponBonusId)] int weaponBonusDamage,
            [Inject(Id = Decorator2Installer.EliteEnchantPercentId)] int weaponEnchantPercent)
        {
            _baseAttackDamage = baseAttackDamage;
            _weaponBonusDamage = weaponBonusDamage;
            _weaponEnchantPercent = weaponEnchantPercent;
        }

        public int GetAttackDamage()
        {
            int damageWithWeapon = _baseAttackDamage + _weaponBonusDamage;
            return damageWithWeapon + (damageWithWeapon * _weaponEnchantPercent / 100);
        }
    }
}
