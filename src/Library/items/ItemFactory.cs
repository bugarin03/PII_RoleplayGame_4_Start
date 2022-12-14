namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        MedievalShield = 3,
        Stick = 4,
        MagicStick = 5,
        MagicSword = 6,
        PowerGauntlet = 7,
        TrollCuirass = 8,
        BlackArrow = 9
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.MedievalShield: return new MedievalShield();
                case ItemType.Stick: return new Stick();
                case ItemType.MagicStick: return new MagicStick();
                case ItemType.MagicSword: return new MagicSword();
                case ItemType.PowerGauntlet: return new PowerGauntlet();
                case ItemType.TrollCuirass: return new TrollCuirass();
                case ItemType.BlackArrow: return new BlackArrow();

                default: return null;
            }
        }
    }
}