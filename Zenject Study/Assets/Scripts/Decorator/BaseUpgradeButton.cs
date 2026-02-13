using UnityEngine;
using UnityEngine.UI;
using Zenject;

public abstract class BaseUpgradeButton : MonoBehaviour
{
    [SerializeField] int _upgradeAmount;
    Button _button;
    SignalBus _signalBus;
    protected IIntValue _value;

    [Inject]
    void Init(SignalBus signalBus) {
        _signalBus = signalBus;
    }

    void Awake() {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    void OnClick() {
        _value.IncreaseValue(_upgradeAmount);
        _signalBus.Fire(new DecoratorInstaller.UpgradeSignal());
    }
}