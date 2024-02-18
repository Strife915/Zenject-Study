using UnityEngine;
using Zenject;

public class MyFactoryItem : MonoBehaviour , IMyAbstractItem
{
    FactorySceneRegularClass _class;
    [Inject]
    void Construct(FactorySceneRegularClass regularClass)
    {
        _class = regularClass;
        Debug.Log(_class.A);
    }
}