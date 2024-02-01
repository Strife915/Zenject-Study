using System;
using UnityEngine;
using Zenject;

public class ConventionUser : MonoBehaviour
{
    ConventionA _conventionA;
    ConventionB _conventionB;

    [Inject]
    void Construct(ConventionA conventionA, ConventionB conventionB)
    {
        _conventionA = conventionA;
        _conventionB = conventionB;
    }

    void Start()
    {
        Debug.Log(_conventionA);
        Debug.Log(_conventionB);
    }
}