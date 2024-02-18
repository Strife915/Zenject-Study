using UnityEngine;
using Zenject;

public class MyFactoryItem :  IMyAbstractItem
{
    int _a;
    string _string;
    [Inject]
    void Construct(int a,string s)
    {
        _a = a;
        _string = s;
        Debug.Log(_a);
        Debug.Log(_string);
    }
}