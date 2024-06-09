using System;
using UnityEngine;
using Zenject;

public class MyTestPoolObject2 : MonoBehaviour
{
    IMover _mover;
    public void Construct(Mover mover) => _mover = mover;

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
}

public class MoverFactory : PlaceholderFactory<Transform, Mover>
{
}