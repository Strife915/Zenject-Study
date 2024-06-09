using Cysharp.Threading.Tasks;
using Zenject;

public class MyTestObjectSpawner : IInitializable
{
    MyTestObjectPool _pool;
    MoverFactory _moverFactory;

    public MyTestObjectSpawner(MyTestObjectPool pool, MoverFactory moverFactory)
    {
        _pool = pool;
        _moverFactory = moverFactory;
    }

    public void Initialize()
    {
        SpawnProcess();
    }

    async void SpawnProcess()
    {
        while (true)
        {
            var myTestObject = _pool.Spawn();

            // Assuming myTestObject has a Transform component
            var mover = _moverFactory.Create(myTestObject.transform);
            myTestObject.Construct(mover);
            mover.Move();

            await UniTask.Delay(1000);
        }
    }
}