using RoleplayGame.Items;
namespace RoleplayGame.Characters
{
    public class Troll : Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 180;
            this.MaxHealth = 180;
            this.AddItem(new Stick());
            this.AddItem(new Shield());
        }
    }
}