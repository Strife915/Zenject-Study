using UnityEngine;
using Zenject;

public class FactoryInstaller : MonoInstaller
{
    public GameObject myFactoryItem;

    public override void InstallBindings()
    {
        //Container.BindFactory<MyFactoryItem, MyFactory>().FromComponentInNewPrefab(myFactoryItem);
        //Container.BindFactory<int,IMyAbstractItem, MyFactory>().FromComponentInNewPrefab(myFactoryItem);
        Container.BindFactory<int,string, MyFactoryItem, MyFactory>();
        Container.Bind<FactorySceneRegularClass>().AsSingle();
    }
}