using Zenject;

public class PlayerInGameBonusAttackDamageTextController : BaseTextController
{
    [Inject]
    public void Init(PlayerInGameBonusAttackDamage playerInGameBonusAttackDamage) {
        _valueToTrack = playerInGameBonusAttackDamage;
    }
}