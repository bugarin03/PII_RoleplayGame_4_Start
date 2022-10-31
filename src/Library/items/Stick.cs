namespace RoleplayGame.Items
{
    public class Stick : IItem, IAttackItem
    {
        public string Name { get; }
        public string Description { get; }
        public int AttackPower
        {
            get
            {
                return 9;
            }
        }

        public Stick()
        {
            this.Name = "Palo";
            this.Description = "Simplemente un palo";
        }
    }
}