using UnityEngine;
using Zenject;

public class SubContainerInstaller : MonoInstaller {
    public override void InstallBindings() {
        Container.BindInterfacesTo<GameController>().AsSingle();
        Container.Bind<Greeter>().FromSubContainerResolve().ByMethod(InstallGreeter).AsSingle();
    }

    void InstallGreeter(DiContainer subContainer) {
        subContainer.Bind<Greeter>().AsSingle();
        subContainer.BindInstance("Hello world!");
    }
}

public class Greeter {
    readonly string _message;

    public Greeter(string message) {
        _message = message;
    }

    public void DisplayGreeting() {
        Debug.Log(_message);
    }
}

public class GameController : IInitializable {
    readonly Greeter _greeter;

    public GameController(Greeter greeter) {
        _greeter = greeter;
    }

    public void Initialize() {
        _greeter.DisplayGreeting();
    }
}