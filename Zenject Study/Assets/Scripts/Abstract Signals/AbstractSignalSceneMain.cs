using UnityEngine;
using Zenject;

public class AbstractSignalSceneMain : MonoBehaviour
{
    SignalBus _signalBus;

    [Inject]
    void Construct(SignalBus signalBus) {
        _signalBus = signalBus;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //Player killed an enemy
            _signalBus.AbstractFire<SignalEnemyDefeated>();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            //Player completed a level
            _signalBus.AbstractFire<SignalLevelCompleted>();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //Player discovered a secret
            _signalBus.AbstractFire<SignalSecretDiscovered>();
        }
    }
}