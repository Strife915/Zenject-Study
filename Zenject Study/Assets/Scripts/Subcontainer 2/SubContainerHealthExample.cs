using System;
using UnityEngine;
using Zenject;


public class SubContainerHealthExample : MonoBehaviour {
    SubContainerUserExample _subContainerUserExample;

    [Inject]
    void Construct(SubContainerUserExample subContainerUserExample) {
        _subContainerUserExample = subContainerUserExample;
    }

    void Awake() {
        _subContainerUserExample.Log();
    }

    public void Log() {
        Debug.Log("Health xxxx");
    }
}