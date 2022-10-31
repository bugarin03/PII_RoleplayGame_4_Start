namespace RoleplayGame.Items
{

    public class MagicStick : IMagicItem 
    {

        public string Name {get;}
        public string Description {get;}
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

        public MagicStick()
        {
            this.Name = "Palo";
            this.Description = "Simplemente un palo de apariencia extraña";
        }
    }
}