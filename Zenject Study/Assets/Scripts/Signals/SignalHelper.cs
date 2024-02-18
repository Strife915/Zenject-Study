using System.Collections;
using UnityEngine;
using Zenject;

public class SignalHelper : MonoBehaviour
{
    MySignalClass _signalClass;
    SignalBus _signalBus;

    [Inject]
    void Construct(MySignalClass signalClass,SignalBus signalBus)
    {
        _signalClass = signalClass;
        _signalBus = signalBus;
    }
        

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            //_signalBus.Fire<MySignalClass>();
            _signalBus.Fire(_signalClass);
            yield return new WaitForSeconds(1f);
            ;

        }
    }
}