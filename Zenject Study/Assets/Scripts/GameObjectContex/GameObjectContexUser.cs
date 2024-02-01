using System;
using UnityEngine;
using Zenject;

public class GameObjectContexUser : MonoBehaviour
{
    InjectClassTest _injectClassTest;

    [Inject]
    void Construct(InjectClassTest injectClassTest)
    {
        _injectClassTest = injectClassTest;
    }

    void Start()
    {
        Debug.Log(_injectClassTest);
    }
}