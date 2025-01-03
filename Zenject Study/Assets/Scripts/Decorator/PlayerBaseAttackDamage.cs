using UnityEngine;
using Zenject;

public class PlayerBaseAttackDamage : BaseSaveLoadIntClass
{
    public PlayerBaseAttackDamage(SignalBus signalBus) : base(signalBus) {
        Debug.Log("Player Base Attack Created");
    }

    public override void Initialize() {
        InitValue();
    }

    protected override void InitValue() {
        SetDefaultValue(10);
        LoadValue();
        FireSignalOnValueUpdate();
    }
}