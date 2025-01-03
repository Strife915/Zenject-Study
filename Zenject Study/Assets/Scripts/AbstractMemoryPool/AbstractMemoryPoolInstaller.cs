using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

public class AbstractMemoryPoolInstaller : MonoInstaller
{
    [SerializeField] AbstractMonoMemoryPoolObject abstractMonoMemoryPoolObjectPrefab;

    public override void InstallBindings()
    {
        Container.BindMemoryPool<AbstractMonoMemoryPoolObject, AbstractMonoMemoryPool>()
            .WithInitialSize(10).FromComponentInNewPrefab(abstractMonoMemoryPoolObjectPrefab);
        Container.BindMemoryPool<IAbstractMemoryPoolObject, AbstractMemoryPool>().WithInitialSize(5)
            .To<AbstractMemoryPoolObject>();
        Container.BindInterfacesAndSelfTo<AbstractMemoryPoolUser>().AsSingle().NonLazy();
    }
}

public interface IAbstractMemoryPoolObject
{
    void MyTestMethod();
}

public class AbstractMonoMemoryPool : MonoMemoryPool<AbstractMonoMemoryPoolObject>
{
}

public class AbstractMemoryPool : MemoryPool<IAbstractMemoryPoolObject>
{
}