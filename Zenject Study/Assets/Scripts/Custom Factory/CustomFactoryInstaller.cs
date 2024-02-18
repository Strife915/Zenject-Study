using Zenject;

public class CustomFactoryInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindFactory<IEnemy, EnemyFactory>().FromFactory<CustomEnemyFactory>();
        //Container.BindFactoryCustomInterface<ICustomEnemyFactory, EnemyFactory, CustomEnemyFactory>();
    }
}