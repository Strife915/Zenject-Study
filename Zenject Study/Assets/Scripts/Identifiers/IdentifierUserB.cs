using UnityEngine;
using Zenject;

public class IdentifierUserB : MonoBehaviour
{
    IdentifierTestClass _identifierTestClass;

    [Inject]
    void Construct([Inject(Id = MyTestEnum.IdentifierB)] IdentifierTestClass identifierTestClass) =>
        _identifierTestClass = identifierTestClass;
}