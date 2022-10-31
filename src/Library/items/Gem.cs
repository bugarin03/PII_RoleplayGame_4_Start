namespace RoleplayGame.Items
{
    public class Gem
    {
        public int AttackPower { get; }
        public int DefensePower { get; }

        public Gem(int attackPower, int defensePower)
        {
            this.AttackPower = attackPower;
            this.DefensePower = defensePower;
        }
    }
}