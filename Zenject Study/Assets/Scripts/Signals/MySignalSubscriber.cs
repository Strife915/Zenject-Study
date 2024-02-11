using UnityEngine;
using Zenject;

public class MySignalSubscriber : MonoBehaviour
{
    [Inject] SignalBus _signalBus;

    void Awake()
    {
        _signalBus.Subscribe<MySignalClass>(SignalReciever);
    }

    public void SignalReciever()
    {
        Debug.Log("Signal recieved");
    }

    void OnDestroy()
    {
        _signalBus.Unsubscribe<MySignalClass>(SignalReciever);
    }
}