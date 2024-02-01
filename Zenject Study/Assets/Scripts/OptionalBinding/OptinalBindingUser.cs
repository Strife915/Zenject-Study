using UnityEngine;
using Zenject;

public class OptinalBindingUser : MonoBehaviour
{
    OptionalBindingClass _optionalBindingClass;

    [Inject]
    void Construct(OptionalBindingClass optionalBindingClass) => _optionalBindingClass = optionalBindingClass;

    void Start()
    {
        Debug.Log(_optionalBindingClass.testBool);
    }
}