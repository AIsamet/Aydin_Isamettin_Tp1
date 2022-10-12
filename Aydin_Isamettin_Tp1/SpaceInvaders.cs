using System;
namespace Aydin_Isamettin_Tp1
{
    public class SpaceInvaders
    {
        //2.3
        private List<Player> Players { get;  set; }
        public Armory GameArmory { get; private set; }

        //2.1 & 2.4
        public SpaceInvaders()
        {
            Init();
        }

        //2.2 & 2.4 & 2.5 & 2.6
        static void Main()
        {
            SpaceInvaders myGame = new SpaceInvaders();

            Console.WriteLine("Liste des joueurs :");
            foreach (Player p in myGame.Players)
            {
                Console.WriteLine(p.ToString());
            }
            Console.Write("\n");

            //8.1
            Console.WriteLine(myGame.Players[0].Equals(myGame.Players[1]) +"\n");

            //INFORMATIONS DU VAISSEAU DU JOUEUR JOHN DOE
            myGame.Players[0].MySpaceship.ViewWeapons();
            Weapon myWeapon = new Weapon("Annihilateur lourd", 80, 100, Weapon.EWeaponType.Guided);
            Armory test = new Armory();
            //ESSAI DAJOUT D'ARME N'ETANT PAS DANS L'ARMURERIE
            myGame.Players[0].MySpaceship.AddWeapon(myGame.GameArmory.GetWeapon("Annihilateur lourd"));
            myGame.GameArmory.AddWeapon(myWeapon);
            myGame.GameArmory.ViewArmory();

            //REESSAI EN L'AJOUTANT DANS L'ARMURERIE
            myGame.Players[0].MySpaceship.AddWeapon(myWeapon);
            myGame.Players[0].MySpaceship.ViewWeapons();
            Console.WriteLine("Degats moyens du vaisseau : " + myGame.Players[0].MySpaceship.AverageDamages() + "\n");

            //LE JOUEUR JANE DOE ATTAQUE LE JOUEUR JOHN DOE
            Console.WriteLine(myGame.Players[1].Name + " attaque le vaisseau de " + myGame.Players[0].Name + "\n");
            Console.WriteLine("Le vaisseau de " + myGame.Players[0].Name + " subit 100 degats");
            myGame.Players[0].MySpaceship.CurrentShield -= 100;
            Console.WriteLine("Le vaisseau de " + myGame.Players[0].Name + " n'a plus de shield");
            Console.WriteLine("Le vaisseau de " + myGame.Players[0].Name + " subit a nouveau 100 degats");
            myGame.Players[0].MySpaceship.CurrentStructure -= 100;

            // LE VAISSEAU DE JOHN DOE EST DETRUIT
            if (myGame.Players[0].MySpaceship.IsDestroyed) { Console.WriteLine("Le vaisseau de " + myGame.Players[0].Name + " est detuit\n"); }
            myGame.Players[0].MySpaceship.RemoveWeapon(myWeapon);
            Console.WriteLine("Degats moyens du vaisseau : " + myGame.Players[0].MySpaceship.AverageDamages() + "\n");

            //8.2
            myGame.GameArmory.ViewArmory();

            //8.3
            Console.WriteLine("Informations concernant le vaisseau de " + myGame.Players[0].Name);
            myGame.Players[0].MySpaceship.ViewShip();

        }

        //2.3
        private void Init()
        {
            Players = new List<Player>();
            Players.Add(new Player("john", "doe", "jojo"));
            Players.Add(new Player("jane", "doe", "jaja"));
            Players.Add(new Player("michel", "meyer", "mimi"));
            GameArmory = new Armory();
        }
    }
}

