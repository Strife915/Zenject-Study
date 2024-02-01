using UnityEngine;
using Zenject;

public class IdentifierUserA : MonoBehaviour
{
    IdentifierTestClass _identifierTestClass;

    [Inject]
    void Construct([Inject(Id = MyTestEnum.IdentifierA)] IdentifierTestClass identifierTestClass) =>
        _identifierTestClass = identifierTestClass;
}