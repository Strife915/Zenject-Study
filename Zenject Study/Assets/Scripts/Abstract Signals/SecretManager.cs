using UnityEngine;
using Zenject;

public class SecretManager {
    public SecretManager(SignalBus signalBus) {
        signalBus.Subscribe<ISignalSecretDiscovered>(x => OnSecretDiscovered(x.SecretName));
    }

    void OnSecretDiscovered(string secretName) {
        //Secret discovered
        Debug.Log("Secret discovered: " + secretName);
    }
}