using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MonoPoolUser : MonoBehaviour
{
    BulletPool _bulletPool;
    List<Bullet> _spawnedBullets = new List<Bullet>();

    [Inject]
    void Construct(BulletPool pool)
    {
        _bulletPool = pool;
    }

    IEnumerator Start()
    {
        while (true)
        {
            Bullet bullet = _bulletPool.Spawn();
            _spawnedBullets.Add(bullet);
            yield return new WaitForSeconds(.5f);
        }
    }

    void Update()
    {
        if (_spawnedBullets.Count > 5)
        {
            Bullet bullet = _spawnedBullets[0];
            _spawnedBullets.Remove(bullet);
            _bulletPool.Despawn(bullet);
        }
    }
}