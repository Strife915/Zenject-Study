using UnityEngine;
using Zenject;

public class ConventionalChallangeUser : MonoBehaviour
{
    IDataSource _dataSource;

    [Inject]
    void Construct(IDataSource dataSource)
    {
        _dataSource = dataSource;
    }

    void Start()
    {
        _dataSource.LogMethod();
    }
}