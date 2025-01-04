using UnityEngine;
using Zenject;

public class SoundManager {
    public SoundManager(SignalBus signalBus) {
        signalBus.Subscribe<ISignalSoundPlayer>(x => PlaySound(x.SoundID));
    }

    void PlaySound(int objSoundID) {
        //Play sound
        Debug.Log("Playing sound with ID: " + objSoundID);
    }
}