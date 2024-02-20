using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class ComplexSignalHelper : MonoBehaviour
{
    IComplexSignal _complexSignal;

    [Inject]
    void Construct(ConcreteSignal concreteSignal)
    {
        _complexSignal = concreteSignal;
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            _complexSignal.Signal();
        }
    }
}