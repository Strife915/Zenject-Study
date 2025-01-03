using UnityEngine;
using Zenject;

public class PlayerInGameBonusAttackDamage : BaseIntValue
{
    public PlayerInGameBonusAttackDamage(SignalBus signalBus) : base(signalBus) {
    }

    public override void Initialize() {
        SetDefaultValue(5);
        SetValue(GetDefaultValue());
        FireSignalOnValueUpdate();
    }
}