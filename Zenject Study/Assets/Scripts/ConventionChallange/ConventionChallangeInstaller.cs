using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ConventionChallangeInstaller : MonoInstaller
{
    public bool isDebugMode;

    public override void InstallBindings()
    {
        Container.Bind<IDataSource>()
            .To(binder => binder.AllNonAbstractClasses().WithPrefix(isDebugMode ? "Stub" : "Network")).AsSingle();
    }
}

public interface IDataSource
{
    void LogMethod();
}

public class NetworkDataSource : IDataSource
{
    public void LogMethod()
    {
        Debug.Log("Network Data Source");
    }
}

public class StubDataSource : IDataSource
{
    public void LogMethod()
    {
        Debug.Log("Stub Data Source");
    }
}