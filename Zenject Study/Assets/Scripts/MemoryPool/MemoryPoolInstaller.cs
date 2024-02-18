using UnityEngine;
using Zenject;

public class MemoryPoolInstaller : MonoInstaller
{
    [SerializeField] Bullet _bullet;

    public override void InstallBindings()
    {
        Container.BindMemoryPool<Bullet, BulletPool>().WithInitialSize(10).FromComponentInNewPrefab(_bullet);
    }
}