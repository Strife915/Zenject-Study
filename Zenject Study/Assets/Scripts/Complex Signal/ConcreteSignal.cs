using Zenject;

public class ConcreteSignal : ComplexSignalBase
{
    public ConcreteSignal(SignalBus signalBus) : base(signalBus)
    {
    }
}