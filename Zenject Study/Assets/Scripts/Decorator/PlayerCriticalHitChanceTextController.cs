using Zenject;

public class PlayerCriticalHitChanceTextController : BaseTextController
{
    [Inject]
    public void Init(PlayerCriticalHitChance playerCriticalHitChance) {
        _valueToTrack = playerCriticalHitChance;
    }
}