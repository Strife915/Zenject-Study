using TMPro;
using UnityEngine;
using Zenject;

public abstract class BaseTextController : MonoBehaviour
{
    TextMeshProUGUI _text;
    SignalBus _signalBus;
    protected IIntValue _valueToTrack;
    protected string _bonusText;

    [Inject]
    void Init(SignalBus signalBus) {
        _signalBus = signalBus;
    }

    void Awake() {
        _text = GetComponent<TextMeshProUGUI>();
    }

    void OnEnable() {
        _signalBus.Subscribe<DecoratorInstaller.ValueChangeSignal>(UpdateText);
    }

    void OnDisable() {
        _signalBus.Unsubscribe<DecoratorInstaller.ValueChangeSignal>(UpdateText);
    }

    void UpdateText(DecoratorInstaller.ValueChangeSignal obj) {
        IIntValue intValue = obj.IntValue;
        if (intValue != _valueToTrack) return;
        int value = intValue.GetValue();
        _text.text = _bonusText + value.ToString();
    }
}