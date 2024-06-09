using System.Threading;
using Cysharp.Threading.Tasks;
using Zenject;

public class MyTestObjectSpawner : IInitializable
{
    MyTestObjectPool _pool;
    MoverFactory _moverFactory;
    CancellationTokenSource _cancellationTokenSource;

    public MyTestObjectSpawner(MyTestObjectPool pool, MoverFactory moverFactory)
    {
        _pool = pool;
        _moverFactory = moverFactory;
        _cancellationTokenSource = new CancellationTokenSource();
    }

    public void Initialize()
    {
        SpawnProcess(_cancellationTokenSource.Token).Forget();
    }

    async UniTaskVoid SpawnProcess(CancellationToken token)
    {
        // Başlangıçta gecikme görevini oluştur
        var delayTask = UniTask.Delay(1000, cancellationToken: token);

        while (!token.IsCancellationRequested)
        {
            var myTestObject = _pool.Spawn();
            var mover = _moverFactory.Create(myTestObject.transform);
            myTestObject.Construct(mover);
            mover.Move();

            await delayTask; // Önceden oluşturulmuş gecikme görevini kullan

            // Gecikme görevini yeniden başlat
            delayTask = UniTask.Delay(1000, cancellationToken: token);
        }
    }
}