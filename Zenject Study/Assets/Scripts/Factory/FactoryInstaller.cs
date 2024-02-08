using UnityEngine;
using Zenject;

public class FactoryInstaller : MonoInstaller
{
    public GameObject myFactoryItem;

    public override void InstallBindings()
    {
        Container.BindFactory<MyFactoryItem, MyFactory>().FromComponentInNewPrefab(myFactoryItem);
    }
}