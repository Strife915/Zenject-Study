using System.Collections;
using UnityEngine;
using Zenject;

public class AbstractFactoryUser : MonoBehaviour
{
    MyAbstractFactory _myAbstractFactory;

    [Inject]
    void Construct(MyAbstractFactory myAbstractFactory)
    {
        _myAbstractFactory = myAbstractFactory;
    }

    IEnumerator Start()
    {
        while (true)
        {
            _myAbstractFactory.Create();
            yield return new WaitForSeconds(2f);
        }
    }
}