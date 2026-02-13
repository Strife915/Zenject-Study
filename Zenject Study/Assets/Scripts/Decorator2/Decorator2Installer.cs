using UnityEngine;
using Zenject;

namespace Decorator2
{
    public class Decorator2Installer : MonoInstaller
    {
        public const string BaseDamageId = "Decorator2.BaseDamage";
        public const string WeaponBonusId = "Decorator2.WeaponBonus";
        public const string EnchantPercentId = "Decorator2.EnchantPercent";

        [SerializeField]
        int _baseDamage = 20;

        [SerializeField]
        int _weaponBonusDamage = 15;

        [SerializeField]
        int _weaponEnchantPercent = 30;

        public override void InstallBindings()
        {
            Container.BindInstance(_baseDamage).WithId(BaseDamageId);
            Container.BindInstance(_weaponBonusDamage).WithId(WeaponBonusId);
            Container.BindInstance(_weaponEnchantPercent).WithId(EnchantPercentId);

            Container.Bind<IAttacker>().To<BaseAttacker>().AsTransient();
            Container.Decorate<IAttacker>().With<WeaponAttackerDecorator>();
            Container.Decorate<IAttacker>().With<WeaponEnchantAttackerDecorator>();

            Container.BindInterfacesTo<Decorator2AttackPresenter>().AsSingle();
        }
    }
}
