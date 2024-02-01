using System;
using UnityEngine;
using Zenject;

public class ConditionalInstallerUser : MonoBehaviour
{
    ISettings _gameSettings;
    ISettings _audiotSettings;
    ISettings _userSettings;
    ISettings _enemySettings;

    [Inject]
    void Construct([Inject(Id = ConditionalEnum.GameSettings)] ISettings gameset,
        [Inject(Id = ConditionalEnum.AudioSettings)]
        ISettings audioset, ISettings userSettings, ISettings enemySettings)
    {
        _gameSettings = gameset;
        _audiotSettings = audioset;
        _userSettings = userSettings;
        _enemySettings = enemySettings;
    }

    void Start()
    {
        _gameSettings.LogMethod();
        _audiotSettings.LogMethod();
        _userSettings.LogMethod();
        _enemySettings.LogMethod();
    }
}