using System;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

public class MyTestPoolObject2 : MonoBehaviour
{
    IMover _mover;
    public void Construct(IMover mover) => _mover = mover;

    public void Move()
    {
        _mover.Move();
    }
}

public interface IMover
{
    Transform MoverTransform { get; }
    void Move();
}

public class Mover : IMover
{
    public Transform MoverTransform { get; private set; }

    public Mover(Transform moverTransform)
    {
        MoverTransform = moverTransform;
    }

    public void Move()
    {
        Debug.Log(MoverTransform);
    }
}

public class MyTestObjectPool : MonoMemoryPool<MyTestPoolObject2>
{
    protected override void OnSpawned(MyTestPoolObject2 item)
    {
        base.OnSpawned(item);
        item.gameObject.name = "Object_" + Random.Range(0, 10000);
    }
}

public class MoverFactory : PlaceholderFactory<Transform, IMover>
{
}