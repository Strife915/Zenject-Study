using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OptionalBindingInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<OptionalBindingClass>().AsSingle().WithArguments(true);
    }
}

public class OptionalBindingClass
{
    public bool testBool;

    public OptionalBindingClass([InjectOptional] bool testBool)
    {
        this.testBool = testBool;
    }
}