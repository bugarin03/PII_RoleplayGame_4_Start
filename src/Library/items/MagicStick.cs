namespace RoleplayGame.Items
{

    public class MagicStick : IAttackItem, IMagic 
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }

         public int DefensePower
        {
            get
            {
                return 12;
            }
        }

        public override string ToString()
        {
            return "MagicStick";
        }
    }
}