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
        SpawnProcess().Forget();
    }

    async UniTaskVoid SpawnProcess()
    {
        while (true)
        {
            var myTestObject = _pool.Spawn();
            var mover = _moverFactory.Create(myTestObject.transform);
            myTestObject.Construct(mover);
            mover.Move();

            await UniTask.Delay(1000);
        }
    }
}