using System;
using UnityEngine;
using Zenject;

public class InstanceUser : MonoBehaviour
{
    GameObject _gameObject;

    [Inject]
    void Construct(GameObject gameObject)
    {
        _gameObject = gameObject;
    }

    void Start()
    {
        Debug.Log(gameObject.name);
    }
}