using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class PowerGauntlet : IAttackItem, IDefenseItem
    {
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }
        public List<Gem> GemsList { get; set; }

        public PowerGauntlet()
        {
            this.AttackPower = 0;
            this.DefensePower = 0;
            this.GemsList = new List<Gem>();
        }

        public void AddGem(Gem gem)
        {
            this.AttackPower += gem.AttackPower;
            this.DefensePower += gem.DefensePower;
            this.GemsList.Add(gem);
        }
    }
}