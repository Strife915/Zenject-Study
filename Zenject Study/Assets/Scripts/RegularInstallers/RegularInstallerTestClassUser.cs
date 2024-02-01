using System;
using UnityEngine;
using Zenject;

public class RegularInstallerTestClassUser : MonoBehaviour
{
    RegularInstallerTestClass _regularInstaller;

    [Inject]
    void Construct(RegularInstallerTestClass regularInstallerTestClass)
    {
        _regularInstaller = regularInstallerTestClass;
    }

    void Start()
    {
        Debug.Log(_regularInstaller);
    }
}