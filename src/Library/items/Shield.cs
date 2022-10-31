namespace RoleplayGame.Items
{

    public class Shield : IDefenseItem
    {
        public string Name {get;}
        public string Description {get;}
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Shield";
        }

        public Shield()
        {
            this.Name = "Black Arrow";
            this.Description = "Coraza de gran resistencia"; 
        }
    }
}