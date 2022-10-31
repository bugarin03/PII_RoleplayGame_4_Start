using RoleplayGame.Items;
namespace RoleplayGame.Characters
{
    public class Troll : Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 120;
            this.AddItem(new Stick());
            this.AddItem(new TrollCuirass());
        }
    }
}