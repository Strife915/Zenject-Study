using UnityEngine;

public class Health
{
    float maxHealth;

    public Health(HealthSo healthSo)
    {
        maxHealth = healthSo.maxHealth;
        Debug.Log(maxHealth);
    }
}