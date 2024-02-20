using System;
using UnityEngine;
using Zenject;

public class ComplexSignalSub : IInitializable, IDisposable
{
    SignalBus _signalBus;

    [Inject]
    public ComplexSignalSub(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }

    public void Initialize()
    {
        _signalBus.Subscribe<IComplexSignal>(MySubMethod);
    }

    void MySubMethod()
    {
        Debug.Log("Sub method call");
    }

    public void Dispose()
    {
        _signalBus.Unsubscribe<IComplexSignal>(MySubMethod);
    }
}