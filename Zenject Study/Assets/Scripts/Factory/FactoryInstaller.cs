using UnityEngine;
using Zenject;

public class FactoryInstaller : MonoInstaller
{
    public GameObject myFactoryItem;

    public override void InstallBindings()
    {
        //Container.BindFactory<MyFactoryItem, MyFactory>().FromComponentInNewPrefab(myFactoryItem);
        Container.BindFactory<IMyAbstractItem, MyFactory>().FromComponentInNewPrefab(myFactoryItem);
        Container.Bind<FactorySceneRegularClass>().AsSingle();
    }
}