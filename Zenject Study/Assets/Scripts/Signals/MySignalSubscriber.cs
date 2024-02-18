using UnityEngine;
using Zenject;

public class MySignalSubscriber : MonoBehaviour
{
    [Inject] SignalBus _signalBus;
    void Awake()
    {
        _signalBus.Subscribe<MySignalClass>(SignalReciever);
    }

    public void SignalReciever(MySignalClass mySignalClass)
    {
        Debug.Log("Signal recieved");
        Debug.Log(mySignalClass.MyTestAttribute);
    }

    void OnDestroy()
    {
        _signalBus.Unsubscribe<MySignalClass>(SignalReciever);
    }
}