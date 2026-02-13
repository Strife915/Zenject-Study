using UnityEngine;
using Zenject;

namespace Decorator2
{
    public class Decorator2Installer : MonoInstaller
    {
        public const string EliteAttackerId = "Decorator2.EliteAttacker";

        public const string DefaultBaseDamageId = "Decorator2.Default.BaseDamage";
        public const string DefaultWeaponBonusId = "Decorator2.Default.WeaponBonus";
        public const string DefaultWeaponEnchantPercentId = "Decorator2.Default.WeaponEnchantPercent";

        public const string EliteBaseDamageId = "Decorator2.Elite.BaseDamage";
        public const string EliteWeaponBonusId = "Decorator2.Elite.WeaponBonus";
        public const string EliteEnchantPercentId = "Decorator2.Elite.WeaponEnchantPercent";
        public const string EliteBerserkPercentId = "Decorator2.Elite.BerserkPercent";

        [Header("Default Attacker")]
        [SerializeField]
        int _defaultBaseDamage = 20;

        [SerializeField]
        int _defaultWeaponBonus = 15;

        [SerializeField]
        int _defaultWeaponEnchantPercent = 30;

        [Header("Elite Attacker")]
        [SerializeField]
        int _eliteBaseDamage = 35;

        [SerializeField]
        int _eliteWeaponBonus = 25;

        [SerializeField]
        int _eliteWeaponEnchantPercent = 50;

        [SerializeField]
        int _eliteBerserkPercent = 20;

        public override void InstallBindings()
        {
            Container.BindInstance(_defaultBaseDamage).WithId(DefaultBaseDamageId);
            Container.BindInstance(_defaultWeaponBonus).WithId(DefaultWeaponBonusId);
            Container.BindInstance(_defaultWeaponEnchantPercent).WithId(DefaultWeaponEnchantPercentId);

            Container.BindInstance(_eliteBaseDamage).WithId(EliteBaseDamageId);
            Container.BindInstance(_eliteWeaponBonus).WithId(EliteWeaponBonusId);
            Container.BindInstance(_eliteWeaponEnchantPercent).WithId(EliteEnchantPercentId);
            Container.BindInstance(_eliteBerserkPercent).WithId(EliteBerserkPercentId);

            Container.Bind<IAttacker>()
                .FromSubContainerResolve()
                .ByInstaller<DefaultAttackerInstaller>()
                .AsSingle();

            Container.Bind<IAttacker>()
                .WithId(EliteAttackerId)
                .FromSubContainerResolve()
                .ByInstaller<EliteAttackerInstaller>()
                .AsSingle();

            Container.BindInterfacesTo<Decorator2AttackPresenter>().AsSingle();
        }
    }
}
