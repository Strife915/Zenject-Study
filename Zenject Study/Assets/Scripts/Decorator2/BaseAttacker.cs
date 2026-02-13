using Zenject;

namespace Decorator2
{
    public class BaseAttacker : IAttacker
    {
        readonly int _baseAttackDamage;

        public BaseAttacker([Inject(Id = Decorator2Installer.BaseDamageId)] int baseAttackDamage)
        {
            _baseAttackDamage = baseAttackDamage;
        }

        public int GetAttackDamage()
        {
            return _baseAttackDamage;
        }
    }
}
