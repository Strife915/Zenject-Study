using UnityEngine;
using Zenject;

public class EnemyManager {
    public EnemyManager(SignalBus signalBus) {
        signalBus.Subscribe<ISignalEnemyDefeated>(x => OnEnemyDefeated(x));
    }

    void OnEnemyDefeated(ISignalEnemyDefeated signalEnemyDefeated) {
        Debug.Log(signalEnemyDefeated.EnemyID + " was defeated");
    }
}