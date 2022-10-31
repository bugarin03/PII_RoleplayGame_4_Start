namespace RoleplayGame.Items
{
    public class GoldenApple : IItem
    {
        public string Name { get; }
        public string Description { get; }

        public GoldenApple()
        {
            this.Name = "Manzana dorada";
            this.Description = "Fruta de origen divino que cura por completo a su consumidor";
        }
    }
}