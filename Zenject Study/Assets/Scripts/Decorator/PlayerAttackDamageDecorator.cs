public class PlayerAttackDamageDecorator : IValue
{
    readonly IIntValue _decorated;
    readonly IIntValue _bonusAttackDamage;

    public PlayerAttackDamageDecorator(IIntValue decorated, IIntValue bonusAttackDamage) {
        _decorated = decorated;
        _bonusAttackDamage = bonusAttackDamage;
    }

    public int GetValue() {
        int decoratedValue = _decorated.GetValue();
        int bonusAttackDamageValue = _bonusAttackDamage.GetValue();
        return decoratedValue + bonusAttackDamageValue;
    }
}