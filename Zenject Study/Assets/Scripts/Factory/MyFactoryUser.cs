using System.Collections;
using UnityEngine;
using Zenject;

public class MyFactoryUser : MonoBehaviour
{
    MyFactory _factory;

    [Inject]
    void Construct(MyFactory factory)
    {
        _factory = factory;
    }

    IEnumerator Start()
    {
        while (true)
        {
            _factory.Create();
            yield return new WaitForSeconds(2f);
        }
    }
}