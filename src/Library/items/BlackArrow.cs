namespace RoleplayGame.Items
{
    public class BlackArrow : IItem, IAttackItem
    {
        public string Name { get; }
        public string Description { get; }
        public int AttackPower
        {
            get
            {
                return 15;
            }
        }

        public BlackArrow()
        {
            this.Name = "Black Arrow";
            this.Description = "Arco de origen misterioso con capcidades de poder tener magia contenida";
        }
    }
}