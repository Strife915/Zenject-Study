using Zenject;

public class PlayerBaseAttackDamageTextController : BaseTextController
{
    [Inject]
    public void Init(PlayerBaseAttackDamage playerBaseAttackDamage) {
        _valueToTrack = playerBaseAttackDamage;
    }
}