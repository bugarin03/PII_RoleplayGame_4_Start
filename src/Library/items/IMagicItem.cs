namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear elementos de Magia.
    /// </summary>
    public interface IMagic: IItem
    {
        int AttackPower{ get; }
        int DefensePower{ get; }
    }
}