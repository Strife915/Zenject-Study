using UnityEngine;
using Zenject;

namespace Decorator2
{
    public class Decorator2AttackLogger : MonoBehaviour
    {
        IAttacker _attacker;

        [Inject]
        public void Construct(IAttacker attacker)
        {
            _attacker = attacker;
        }

        void Start()
        {
            Debug.Log($"Decorator2 Total Attack Damage (Start): {_attacker.GetAttackDamage()}");
        }
    }
}
