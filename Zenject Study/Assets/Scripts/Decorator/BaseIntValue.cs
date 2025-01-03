using UnityEngine;
using Zenject;

public abstract class BaseIntValue : IIntValue, IInitializable
{
    SignalBus _signalBus;
    int _defaultValue;
    protected int _value;

    public BaseIntValue(SignalBus signalBus) {
        _signalBus = signalBus;
    }

    public virtual void Initialize() {
        InitValue();
    }

    protected virtual void InitValue() {
        SetDefaultValue(0);
        FireSignalOnValueUpdate();
    }


    public virtual int GetValue() {
        return _value;
    }

    public virtual void IncreaseValue(int amount) {
        _value += amount;
        Debug.Log(GetClassName() + " increased value by " + amount + " to " + _value);
        FireSignalOnValueUpdate();
    }

    protected void FireSignalOnValueUpdate() {
        _signalBus.Fire(new DecoratorInstaller.ValueChangeSignal { IntValue = this });
    }

    string GetClassName() {
        return GetType().Name;
    }

    protected void SetDefaultValue(int value) {
        _defaultValue = value;
    }

    protected void SetValue(int value) {
        _value = value;
        FireSignalOnValueUpdate();
    }

    protected int GetDefaultValue() {
        return _defaultValue;
    }

    public void ResetValue() {
        _value = _defaultValue;
    }
}