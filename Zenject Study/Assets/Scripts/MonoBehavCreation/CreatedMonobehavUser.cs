using UnityEngine;
using Zenject;

public class CreatedMonobehavUser : MonoBehaviour
{
    CreatedMonoBehavior _createdMonoBehavior;
    RequestedComponent _requestedComponent;

    [Inject]
    void Construct(CreatedMonoBehavior createdMonoBehavior, RequestedComponent requestedComponent)
    {
        _createdMonoBehavior = createdMonoBehavior;
        _requestedComponent = requestedComponent;
    }

    void Awake()
    {
        _createdMonoBehavior.transform.position = new Vector3(0, 5, 0);
    }
}