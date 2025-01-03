using Zenject;

public class PlayerInGameBonusAttackDamageUpgradeButton : BaseUpgradeButton
{
    [Inject]
    public void Init(PlayerInGameBonusAttackDamage playerInGameBonusAttackDamage) {
        _value = playerInGameBonusAttackDamage;
    }
}