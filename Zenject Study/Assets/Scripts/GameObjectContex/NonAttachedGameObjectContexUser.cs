using System;
using UnityEngine;
using Zenject;

public class NonAttachedGameObjectContexUser : MonoBehaviour
{
    InjectClassTest _injectClassTest;

    // This will cause an error cuz we bind the class via gameobjectcontex, gameobjectcontex and scenecontex
    // does not share the same container
    /*[Inject]
    void Construct(InjectClassTest injectClassTest)
    {
        _injectClassTest = injectClassTest;
    }*/

    void Start()
    {
        Debug.Log(_injectClassTest);
    }
}