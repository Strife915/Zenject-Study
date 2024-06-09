using UnityEngine;
using Zenject;

public class AbstractMonoMemoryPoolUser : MonoBehaviour
{
    AbstractMonoMemoryPool _abstractMonoMemoryPool;

    [Inject]
    public void Construct(AbstractMonoMemoryPool abstractMonoMemoryPool)
    {
        _abstractMonoMemoryPool = abstractMonoMemoryPool;
    }

    void Start()
    {
        IAbstractMemoryPoolObject abstractMemoryPoolObject = _abstractMonoMemoryPool.Spawn();
        abstractMemoryPoolObject.MyTestMethod();
    }
}

public class AbstractMemoryPoolUser : IInitializable
{
    AbstractMemoryPool _abstractMemoryPool;

    public AbstractMemoryPoolUser(AbstractMemoryPool abstractMemoryPool)
    {
        _abstractMemoryPool = abstractMemoryPool;
    }

    public void Initialize()
    {
        IAbstractMemoryPoolObject abstractMemoryPoolObject = _abstractMemoryPool.Spawn();
        abstractMemoryPoolObject.MyTestMethod();
    }
}