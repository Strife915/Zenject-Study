using System;
using UnityEngine;
using Zenject;

public class ScopeUserA : MonoBehaviour
{
    ScopeClass _scope;

    [Inject]
    void Construct(ScopeClass scopeClass) => _scope = scopeClass;

    void Start() => Debug.Log(_scope);
}