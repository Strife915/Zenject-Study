using Zenject;

public abstract class ComplexSignalBase : IComplexSignal
{
    SignalBus _signalBus;

    [Inject]
    public ComplexSignalBase(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }

    public void Signal()
    {
        _signalBus.Fire(this as IComplexSignal);
    }
}