namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Shield = 3,
        Stick = 4,
        MagicStick = 5,
        MagicSword = 6,
        Gem = 7,

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
                case ItemType.Shield: return new Shield();
                case ItemType.Stick: return new Stick();
                case ItemType.MagicStick: return new MagicStick();
                case ItemType.MagicSword: return new MagicSword();

                default: return null;
            }
        }
    }
}