using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BindInstanceInstaller : MonoInstaller
{
    [SerializeField] GameObject _instanceObject;

    public override void InstallBindings()
    {
        Container.BindInstance(_instanceObject);
        Container.Bind<Player>().FromNew().AsSingle().NonLazy();
        Container.Bind<Enemy>().FromMethod(CreateEnemy).NonLazy();
        Container.Bind<Enemy>().FromMethodMultiple(GetListOfEnemies).NonLazy();
    }

    IEnumerable<Enemy> GetListOfEnemies(InjectContext arg)
    {
        return new Enemy[]
        {
            new Enemy(),
            new Enemy(),
            new Enemy(),
        };
    }

    Enemy CreateEnemy(InjectContext context)
    {
        return new Enemy();
    }
}