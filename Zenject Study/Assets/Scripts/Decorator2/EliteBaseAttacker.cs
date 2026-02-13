using Zenject;

namespace Decorator2
{
    public class EliteBaseAttacker : IAttacker
    {
        readonly int _baseDamage;

        public EliteBaseAttacker([Inject(Id = Decorator2Installer.EliteBaseDamageId)] int baseDamage)
        {
            _baseDamage = baseDamage;
        }

        public int GetAttackDamage()
        {
            return _baseDamage;
        }
    }
}
