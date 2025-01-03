using Zenject;

//Does not validate by regular validiation
public class CustomEnemyFactory : IFactory<IEnemy>
{
    public IEnemy Create() {
        IEnemy enemy = new Worm();
        return enemy;
    }
}