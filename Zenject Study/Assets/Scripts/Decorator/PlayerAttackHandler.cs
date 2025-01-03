public class PlayerAttackHandler
{
    readonly PlayerAttackDamageFactory _factory;
    public int TotalAttackDamage => _factory.Create();

    public PlayerAttackHandler(PlayerAttackDamageFactory factory) {
        _factory = factory;
    }
}