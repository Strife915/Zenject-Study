using UnityEngine;
using Zenject;

namespace Decorator2
{
    public class Decorator2AttackPresenter : IInitializable
    {
        readonly IAttacker _attacker;

        public Decorator2AttackPresenter(IAttacker attacker)
        {
            _attacker = attacker;
        }

        public void Initialize()
        {
            Debug.Log($"Decorator2 Total Attack Damage: {_attacker.GetAttackDamage()}");
        }
    }
}
