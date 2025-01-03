using Zenject;

public class CustomAttackDamageFactory : IFactory<int>
{
    readonly PlayerBaseAttackDamage _baseAttackDamage;
    readonly PlayerInGameBonusAttackDamage _bonusAttackDamage;

    public CustomAttackDamageFactory(PlayerBaseAttackDamage baseAttackDamage, PlayerInGameBonusAttackDamage bonusAttackDamage) {
        _baseAttackDamage = baseAttackDamage;
        _bonusAttackDamage = bonusAttackDamage;
    }

    public int Create() {
        var decorator = new PlayerAttackDamageDecorator(_baseAttackDamage, _bonusAttackDamage);
        return decorator.GetValue();
    }
}

public class PlayerAttackDamageFactory : PlaceholderFactory<int>
{
}