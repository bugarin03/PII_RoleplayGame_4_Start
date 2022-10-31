namespace RoleplayGame.Items
{
    public class MagicSword : IAttackItem
    {
        public string Name {get;}
        public string Description {get;}
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }
    }
}