using Zenject;

namespace Decorator2
{
    public class EliteAttacker : IAttacker
    {
        readonly int _baseDamage;

        public EliteAttacker([Inject(Id = Decorator2Installer.EliteBaseDamageId)] int baseDamage)
        {
            _baseDamage = baseDamage;
        }

        public int GetAttackDamage()
        {
            return _baseDamage;
        }
    }
}
