using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class IdentifierInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IdentifierTestClass>().WithId(MyTestEnum.IdentifierA).AsCached();
        Container.Bind<IdentifierTestClass>().WithId(MyTestEnum.IdentifierB).AsCached();
    }
}

public class IdentifierTestClass
{
    public IdentifierTestClass()
    {
        Debug.Log("Identifier test class created");
    }
}

public enum MyTestEnum
{
    IdentifierA,
    IdentifierB
}