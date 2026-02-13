using UnityEngine;
using Zenject;

namespace Decorator2
{
    public class Decorator2AttackPresenter : IInitializable
    {
        readonly IAttacker _defaultAttacker;
        readonly IAttacker _eliteAttacker;

        public Decorator2AttackPresenter(
            IAttacker defaultAttacker,
            [Inject(Id = Decorator2Installer.EliteAttackerId)] IAttacker eliteAttacker)
        {
            _defaultAttacker = defaultAttacker;
            _eliteAttacker = eliteAttacker;
        }

        public void Initialize()
        {
            Debug.Log($"Decorator2 Default Attacker Damage: {_defaultAttacker.GetAttackDamage()}");
            Debug.Log($"Decorator2 Elite Attacker Damage: {_eliteAttacker.GetAttackDamage()}");
        }
    }
}
