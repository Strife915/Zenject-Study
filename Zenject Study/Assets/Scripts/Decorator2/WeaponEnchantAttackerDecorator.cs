using Zenject;

namespace Decorator2
{
    public class WeaponEnchantAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _enchantPercent;

        public WeaponEnchantAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.EnchantPercentId)] int enchantPercent)
        {
            _decorated = decorated;
            _enchantPercent = enchantPercent;
        }

        public int GetAttackDamage()
        {
            int damageWithWeapon = _decorated.GetAttackDamage();
            return damageWithWeapon + (damageWithWeapon * _enchantPercent / 100);
        }
    }
}
