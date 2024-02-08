using UnityEngine;

public class MyDerivedClass : MyBaseClass
{
    public int a = 0;

    public MyDerivedClass()
    {
        Debug.Log("my derived class created");
    }

    public override void Initialize()
    {
        Debug.Log("2");
    }

    public override void Log()
    {
        Debug.Log("Log from my derived class");
    }
}

public class MyDerivedClassB : MyBaseClass
{
    public MyDerivedClassB()
    {
        Debug.Log("My derived class b created");
    }

    public override void Log()
    {
        Debug.Log("log from derived class b");
    }
}