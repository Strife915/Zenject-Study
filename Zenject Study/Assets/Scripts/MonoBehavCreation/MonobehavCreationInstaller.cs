using System;
using UnityEngine;
using Zenject;

public class MonobehavCreationInstaller : MonoInstaller
{
    [SerializeField] GameObject _createdMonoBehavior;

    public override void InstallBindings()
    {
        Container.Bind<CreatedMonoBehavior>().FromNewComponentOnNewPrefab(_createdMonoBehavior).AsSingle();
        Container.Bind<RequestedComponent>().FromNewComponentOnNewPrefab(_createdMonoBehavior).AsSingle();
    }
}