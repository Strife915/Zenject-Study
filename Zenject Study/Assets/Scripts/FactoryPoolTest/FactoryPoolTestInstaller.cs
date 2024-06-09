using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

public class FactoryPoolTestInstaller : MonoInstaller
{
    [SerializeField] MyTestPoolObject2 myTestPoolObject2Prefab;

    public override void InstallBindings()
    {
        Container.BindFactory<Transform, IMover, MoverFactory>()
            .To<Mover>()
            .AsSingle();
        Container.BindMemoryPool<MyTestPoolObject2, MyTestObjectPool>().WithInitialSize(5)
            .FromComponentInNewPrefab(myTestPoolObject2Prefab);
        Container.BindInterfacesAndSelfTo<MyTestObjectSpawner>().AsSingle().NonLazy();
    }
}