using UnityEngine;
using Zenject;

namespace Decorator2
{
    public class Decorator2Installer : MonoInstaller
    {
        public const string BaseDamageId = "Decorator2.BaseDamage";
        public const string WeaponBonusId = "Decorator2.WeaponBonus";
        public const string EnchantPercentId = "Decorator2.EnchantPercent";

        public const string EliteAttackerId = "Decorator2.EliteAttacker";

        public const string EliteBaseDamageId = "Decorator2.EliteBaseDamage";
        public const string EliteWeaponBonusId = "Decorator2.EliteWeaponBonus";
        public const string EliteEnchantPercentId = "Decorator2.EliteEnchantPercent";

        [SerializeField]
        int _baseDamage = 20;

        [SerializeField]
        int _weaponBonusDamage = 15;

        [SerializeField]
        int _weaponEnchantPercent = 30;

        [Header("Elite Attacker")]
        [SerializeField]
        int _eliteBaseDamage = 35;

        [SerializeField]
        int _eliteWeaponBonusDamage = 25;

        [SerializeField]
        int _eliteWeaponEnchantPercent = 50;

        public override void InstallBindings()
        {
            Container.BindInstance(_baseDamage).WithId(BaseDamageId);
            Container.BindInstance(_weaponBonusDamage).WithId(WeaponBonusId);
            Container.BindInstance(_weaponEnchantPercent).WithId(EnchantPercentId);

            Container.BindInstance(_eliteBaseDamage).WithId(EliteBaseDamageId);
            Container.BindInstance(_eliteWeaponBonusDamage).WithId(EliteWeaponBonusId);
            Container.BindInstance(_eliteWeaponEnchantPercent).WithId(EliteEnchantPercentId);

            Container.Bind<IAttacker>().To<BaseAttacker>().AsTransient();
            Container.Decorate<IAttacker>().With<WeaponAttackerDecorator>();
            Container.Decorate<IAttacker>().With<WeaponEnchantAttackerDecorator>();

            Container.Bind<IAttacker>().WithId(EliteAttackerId).To<EliteAttacker>().AsSingle();
            Container.BindInterfacesTo<Decorator2AttackPresenter>().AsSingle();
        }
    }
}
