using System;
using UnityEngine;
using Zenject;

public class OOPBindTestUser : MonoBehaviour
{
    IMyInterface _myDerivedClass;
    IMyInterface _myDerivedClassB;

    [Inject]
    void Construct(MyDerivedClass myDerivedClass, MyDerivedClassB myDerivedClassB)
    {
        _myDerivedClass = myDerivedClass;
        _myDerivedClassB = myDerivedClassB;
    }

    void Start()
    {
        _myDerivedClass.Log();
        _myDerivedClassB.Log();
    }
}