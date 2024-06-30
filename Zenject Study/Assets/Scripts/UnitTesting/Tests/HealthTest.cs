using System;
using Zenject;
using NUnit.Framework;

[TestFixture]
public class HealthTest : ZenjectUnitTestFixture
{
    IHealth health;
    IAttacker attacker;
    IHealer healer;

    [SetUp]
    public void Install()
    {
        // health = new Health(100);
        // attacker = new SimpleAttacker(20);
        // healer = new SimplyHealer(10);
        Container.BindInterfacesAndSelfTo<Health>().AsSingle().WithArguments(100);
        Container.BindInterfacesAndSelfTo<SimpleAttacker>().AsSingle().WithArguments(20);
        Container.BindInterfacesAndSelfTo<SimplyHealer>().AsSingle().WithArguments(10);

        health = Container.Resolve<Health>();
        attacker = Container.Resolve<SimpleAttacker>();
        healer = Container.Resolve<SimplyHealer>();
    }

    [Test]
    public void TakeDamageTest()
    {
        health.TakeDamage(attacker);
        Assert.AreNotEqual(health.CurrentHealth, health.MaxHealth);
    }

    [Test]
    public void RestoreHealthTest()
    {
        health.TakeDamage(attacker);
        int healthBeforeHeal = health.CurrentHealth;
        health.RestoreHealth(healer);
        Assert.Greater(health.CurrentHealth, healthBeforeHeal);
    }
}

public interface IHealth
{
    int MaxHealth { get; }
    int CurrentHealth { get; }
    void TakeDamage(IAttacker attacker);
    void RestoreHealth(IHealer healer);
}

public interface IHealer
{
    int HealAmount { get; }
}

public class SimplyHealer : IHealer
{
    public int HealAmount { get; private set; }

    public SimplyHealer(int healAmount)
    {
        HealAmount = healAmount;
    }
}

public interface IAttacker
{
    int CurrentDamage { get; }
}

public class SimpleAttacker : IAttacker
{
    public int CurrentDamage { get; private set; }

    public SimpleAttacker(int damage)
    {
        CurrentDamage = damage;
    }
}

public class Health : IHealth
{
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    public Health(int maxHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(IAttacker attacker)
    {
        CurrentHealth -= attacker.CurrentDamage;
    }

    public void RestoreHealth(IHealer healer)
    {
        CurrentHealth += healer.HealAmount;
    }
}