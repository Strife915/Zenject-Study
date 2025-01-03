using TMPro;
using UnityEngine;
using Zenject;

public class PlayerCurrentTotalAttackDamageTextController : MonoBehaviour
{
    TextMeshProUGUI _text;
    SignalBus _signalBus;
    PlayerAttackHandler _totalAttackDamage;

    [Inject]
    void Init(SignalBus signalBus,
        PlayerAttackHandler totalAttackDamage) {
        _totalAttackDamage = totalAttackDamage;
        _signalBus = signalBus;
    }

    void Awake() {
        _text = GetComponent<TextMeshProUGUI>();
    }

    void OnEnable() {
        _signalBus.Subscribe<DecoratorInstaller.UpgradeSignal>(UpdateText);
    }

    void OnDisable() {
        _signalBus.Unsubscribe<DecoratorInstaller.UpgradeSignal>(UpdateText);
    }

    void UpdateText() {
        int totalDamage = _totalAttackDamage.TotalAttackDamage;
    }
}