namespace RoleplayGame.Items
{
    public class TrollCuirass : IDefenseItem
    {
        public string Name { get; }
        public string Description { get; }
        public int DefensePower{ get; }

        public TrollCuirass()
        {
            this.Name = "Coraza de troll";
            this.Description = "Coraza con la que nace un troll";
            this.DefensePower = 20;
        }

        public override string ToString()
        {
            return "Troll Cuirass";
        }
    }
}