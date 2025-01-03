using UnityEngine;

public class PlayerCriticalDecorator : IIntValue
{
    readonly IIntValue _decorated;
    readonly IIntValue _playerCriticalHitChance;

    public PlayerCriticalDecorator(IIntValue decorated, IIntValue playerCriticalHitChance) {
        _decorated = decorated;
        _playerCriticalHitChance = playerCriticalHitChance;
    }

    public int GetValue() {
        int baseDamage = _decorated.GetValue();
        int crChance = _playerCriticalHitChance.GetValue();
        if (Random.Range(0, 100) < crChance)
        {
            Debug.Log("Critical Hit!");
            return baseDamage * 2;
        }

        return baseDamage;
    }

    public void IncreaseValue(int amount) => _decorated.IncreaseValue(amount);
    public void ResetValue() => _decorated.ResetValue();
}