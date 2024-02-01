using System;
using UnityEngine;
using Zenject;

public class ConditionalInstallerUserB : MonoBehaviour
{
    ISettings _userSettings;
    ISettings _enemySettings;

    [Inject]
    void Construct(ISettings userSettings, ISettings enemySettings)
    {
        _userSettings = userSettings;
        _enemySettings = enemySettings;
    }

    void Start()
    {
        _userSettings.LogMethod();
        _enemySettings.LogMethod();
    }
}