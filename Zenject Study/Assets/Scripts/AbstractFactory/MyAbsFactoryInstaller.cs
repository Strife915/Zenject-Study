using UnityEngine;
using Zenject;

public class MyAbsFactoryInstaller : MonoInstaller
{
    public bool bindB;
    public GameObject concreteItem;
    public GameObject concreteItemB;

    public override void InstallBindings()
    {
        if (!bindB)
            Container.BindFactory<IMyItem, MyAbstractFactory>().To<MyConcreteItem>()
                .FromComponentInNewPrefab(concreteItem);
        else
        {
            Container.BindFactory<IMyItem, MyAbstractFactory>().To<MyConcreteItemB>()
                .FromComponentInNewPrefab(concreteItemB);
        }
    }
}