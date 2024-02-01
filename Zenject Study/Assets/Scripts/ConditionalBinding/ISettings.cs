using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISettings
{
    void LogMethod();
}

public class GameSettings : ISettings
{
    public void LogMethod()
    {
        Debug.Log("Game settings");
    }

    public GameSettings()
    {
        Debug.Log("Game settings created");
    }
}

public class AudioSettings : ISettings
{
    public void LogMethod()
    {
        Debug.Log("Audio settings");
    }

    public AudioSettings()
    {
        Debug.Log("Audio settings created");
    }
}

public class UserSettings : ISettings
{
    public void LogMethod()
    {
        Debug.Log("User settings");
    }

    public UserSettings()
    {
        Debug.Log("User settings created");
    }
}

public class EnemySettings : ISettings
{
    public void LogMethod()
    {
        Debug.Log("Enemy settings");
    }

    public EnemySettings()
    {
        Debug.Log("Enemy Settings created");
    }
}