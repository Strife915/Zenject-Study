using UnityEngine;
using Zenject;

public class LevelManager {
    public LevelManager(SignalBus signalBus) {
        signalBus.Subscribe<ISignalLevelComplete>(x => OnLevelComplete(x.Level));
    }

    void OnLevelComplete(int level) {
        //Level completed
        Debug.Log(level + " Level completed");
    }
}