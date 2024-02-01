using UnityEngine;
using Zenject;

public class ScopeUserB : MonoBehaviour
{
    ScopeClass _scope;

    [Inject]
    void Construct([Inject(Id = typeof(ScopeClass))] ScopeClass scopeClass) => _scope = scopeClass;

    void Start() => Debug.Log(_scope);
}