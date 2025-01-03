using Zenject;

public class PlayerBaseAttackDamageUpgradeButton : BaseUpgradeButton
{
    [Inject]
    public void Init(PlayerBaseAttackDamage playerBaseAttackDamage) {
        _value = playerBaseAttackDamage;
    }
}