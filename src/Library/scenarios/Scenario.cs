using System;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;
using RoleplayGame.Items;

namespace RoleplayGame.Scenarios
{
    public class Scenario : IScenario
    {
        public Scenario()
        {

        }

        /// <summary>
        /// Creación de los elementos del escenario.
        /// </summary>
        public void Setup()
        {

        }

        /// <summary>
        /// Ejecución del escenario.
        /// </summary>
        public void Run()
        {
            Troll troll = new Troll("Juan");
            BlackArrow blackArrow = new BlackArrow();
            GoldenApple goldenApple = new GoldenApple();
            troll.AddItem(blackArrow);
            troll.AddItem(goldenApple);

            Elf elf = new Elf("Pedro");
            MagicSword magicSword = new MagicSword();
            MedievalShield medievalShield = new MedievalShield();
            elf.AddItem(magicSword);
            elf.AddItem(medievalShield);

            Wizard wizard = new Wizard("Pepe");
            MagicStick magicStick = new MagicStick();
            PowerGauntlet powerGauntlet = new PowerGauntlet();
            wizard.AddItem(magicStick);
            wizard.AddItem(powerGauntlet);
            Gem gem = new Gem(20, 25);
            powerGauntlet.AddGem(gem);

            AttackEncounter attackEncounter1 = new AttackEncounter(troll, wizard);
            // El troll se come la manzana dorada y cura su vida
            troll.Health = troll.MaxHealth;
            troll.RemoveItem(goldenApple);
            AttackEncounter attackEncounter2 = new AttackEncounter(troll, elf);
            if (troll.IsDead)
            {
                Console.WriteLine($"¡{elf.Name} se declara victorioso de la Tierra Media!");
            }
            else
            {
                Console.WriteLine($"¡{troll.Name} se declara victorioso de la Tierra Media!");
            }
        }
    }
}