using Zenject;

namespace Decorator2
{
    public class EliteBerserkAttackerDecorator : IAttacker
    {
        readonly IAttacker _decorated;
        readonly int _berserkPercent;

        public EliteBerserkAttackerDecorator(
            IAttacker decorated,
            [Inject(Id = Decorator2Installer.EliteBerserkPercentId)] int berserkPercent)
        {
            _decorated = decorated;
            _berserkPercent = berserkPercent;
        }

        public int GetAttackDamage()
        {
            int damage = _decorated.GetAttackDamage();
            return damage + (damage * _berserkPercent / 100);
        }
    }
}
