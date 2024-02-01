using Zenject;

public class ConditionalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ISettings>().WithId(ConditionalEnum.AudioSettings).To<AudioSettings>().AsSingle();
        Container.Bind<ISettings>().WithId(ConditionalEnum.GameSettings).To<GameSettings>().AsSingle();

        Container.Bind<ISettings>().To<UserSettings>().AsSingle()
            .When(context => context.MemberName.StartsWith("user"));
        Container.Bind<ISettings>().To<EnemySettings>().AsSingle()
            .When(context => context.MemberName.StartsWith("enemy"));
    }
}

public enum ConditionalEnum
{
    AudioSettings,
    GameSettings
}