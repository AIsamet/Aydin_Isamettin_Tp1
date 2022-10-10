using System;
namespace Aydin_Isamettin_Tp1
{
    public class SpaceInvaders
    {
        //2.1 & 2.4 & 2.5
        private List<Player> Players { get; set; }
        public SpaceInvaders()
        {
            Init();
        }


        //2.2 & 2.4 & 2.5 & 2.6
        static void Main()
        {
            SpaceInvaders jeu = new SpaceInvaders();
            foreach(Player p in jeu.Players)
            {
                Console.WriteLine(p.ToString());
            }

            Spaceship vaisseau = new Spaceship(100, 100);

            Weapon arme = new Weapon("Annihilateur lourd", 80, 100, Weapon.EWeaponType.Guided);

            Console.WriteLine(vaisseau.Armurerie.CountWeapons());

            vaisseau.AddWeapon(arme);
            vaisseau.Armurerie.ViewArmory();
            Console.WriteLine(vaisseau.Armurerie.CountWeapons());
            Console.WriteLine(vaisseau.AverageDamages());



        }

        //2.3 & 2.5
        private void Init()
        {
            Players = new List<Player>();
            Players.Add(new Player("john", "doe", "jojo"));
            Players.Add(new Player("jane", "doe", "jaja"));
            Players.Add(new Player("michel", "meyer", "mimi"));
        }
    }
}

