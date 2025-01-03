using UnityEngine;
using Zenject;

public abstract class BaseSaveLoadIntClass : BaseIntValue
{
    protected BaseSaveLoadIntClass(SignalBus signalBus) : base(signalBus) {
    }

    string GetSaveKey() {
        return GetType().Name;
    }

    void SaveValue() {
        PlayerPrefs.SetInt(GetSaveKey(), _value);
    }

    protected void LoadValue() {
        _value = PlayerPrefs.GetInt(GetSaveKey(), GetDefaultValue());
    }

    public override void IncreaseValue(int amount) {
        base.IncreaseValue(amount);
        SaveValue();
    }
}