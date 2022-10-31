namespace RoleplayGame.Items
{

    public class MedievalShield : IDefenseItem
    {
        public string Name { get; }
        public string Description { get; }
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

        public MedievalShield()
        {
            this.Name = "Escudo Medieval";
            this.Description = "Escudo utilizado por los reyes";
        }
        
        public override string ToString()
        {
            return "Medieval Shield";
        }
    }
}