using UnityEngine;

public class AbstractMonoMemoryPoolObject : MonoBehaviour, IAbstractMemoryPoolObject
{
    public void MyTestMethod()
    {
        Debug.Log("My test method was called! from Mono");
    }
}

public class AbstractMemoryPoolObject : IAbstractMemoryPoolObject
{
    public void MyTestMethod()
    {
        Debug.Log("My test method was called! from regular");
    }
}