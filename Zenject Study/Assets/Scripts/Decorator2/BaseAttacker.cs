using Zenject;

namespace Decorator2
{
    public class BaseAttacker : IAttacker
    {
        readonly int _baseDamage;

        public BaseAttacker([Inject(Id = Decorator2Installer.DefaultBaseDamageId)] int baseDamage)
        {
            _baseDamage = baseDamage;
        }

        public int GetAttackDamage()
        {
            return _baseDamage;
        }
    }
}
