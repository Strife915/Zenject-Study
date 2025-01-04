using Zenject;

public class AbstractSignalInstaller : MonoInstaller {
    public override void InstallBindings() {
        SignalBusInstaller.Install(Container);
        DeclareSignals();
        InstallManagers();
    }

    void DeclareSignals() {
        Container.DeclareSignalWithInterfaces<SignalEnemyDefeated>().OptionalSubscriber();
        Container.DeclareSignalWithInterfaces<SignalLevelCompleted>().OptionalSubscriber();
        Container.DeclareSignalWithInterfaces<SignalSecretDiscovered>().OptionalSubscriber();
    }

    void InstallManagers() {
        Container.Bind<LevelManager>().AsSingle().NonLazy();
        Container.Bind<SecretManager>().AsSingle().NonLazy();
        Container.Bind<EnemyManager>().AsSingle().NonLazy();
        Container.Bind<SoundManager>().AsSingle().NonLazy();
    }
}

public interface ISignalSoundPlayer {
    int SoundID { get; }
}

public interface ISignalSecretDiscovered {
    string SecretName { get; }
}

public interface ISignalLevelComplete {
    int Level { get; }
}

public interface ISignalEnemyDefeated {
    int EnemyID { get; }
}

public struct SignalEnemyDefeated : ISignalEnemyDefeated, ISignalSoundPlayer {
    public int SoundID { get; }
    public int EnemyID { get; }
}

public struct SignalLevelCompleted : ISignalLevelComplete, ISignalSoundPlayer {
    public int SoundID { get; }
    public int Level { get; }
}

public struct SignalSecretDiscovered : ISignalSoundPlayer, ISignalSecretDiscovered {
    public int SoundID { get; }
    public string SecretName { get; }
}