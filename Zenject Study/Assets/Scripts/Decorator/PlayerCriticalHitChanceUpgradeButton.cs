using Zenject;

public class PlayerCriticalHitChanceUpgradeButton : BaseUpgradeButton
{
    [Inject]
    public void Init(PlayerCriticalHitChance playerCriticalHitChance) {
        _value = playerCriticalHitChance;
    }
}