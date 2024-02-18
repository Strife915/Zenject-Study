using System;
using UnityEngine;
using Zenject;

public class CustomFactoryUser : MonoBehaviour
{
    EnemyFactory _customEnemyFactory;

    [Inject]
    void Construct(EnemyFactory factory)
    {
        _customEnemyFactory = factory;
    }

    void Start()
    {
        IEnemy enemy = _customEnemyFactory.Create();
        enemy.Log();
    }
}