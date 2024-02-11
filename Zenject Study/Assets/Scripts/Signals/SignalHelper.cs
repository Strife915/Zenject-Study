using System.Collections;
using UnityEngine;
using Zenject;

public class SignalHelper : MonoBehaviour
{
    MySignalClass _signalClass;

    [Inject]
    void Construct(MySignalClass signalClass) => _signalClass = signalClass;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            _signalClass.MySignalMethod();
            yield return new WaitForSeconds(1f);
            
        }
    }
}