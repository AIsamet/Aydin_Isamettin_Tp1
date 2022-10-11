using System;
namespace Aydin_Isamettin_Tp1
{
    public class Armory
    {
        //5.1 
        public List<Weapon> Weapons { get; private set; }

        public Armory()
        {
            Init();
        }

        //5.2
        private void Init()
        {
            Weapons = new List<Weapon>();
            Weapons.Add(new Weapon("Rayon laser", 50, 80, Weapon.EWeaponType.Direct));
            Weapons.Add(new Weapon("Mitrailleuse", 20, 40, Weapon.EWeaponType.Guided));
            Weapons.Add(new Weapon("Lance missile", 10, 60, Weapon.EWeaponType.Explosive));
        }

        //5.3
        public void ViewArmory()
        {
            Console.WriteLine("Liste des armes de l'armurerie : ");
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine(weapon.ToString());
            }
            Console.Write("\n");
        }

        public void AddWeapon(Weapon weapon)
        {
            Weapons.Add(weapon);
        }

        public void RemoveWeapon(Weapon armeSupprimer)
        {
            foreach (Weapon weapon in Weapons)
            {
                if (weapon.name == armeSupprimer.name)
                {
                    Weapons.Remove(armeSupprimer);
                    break;
                }
            }
        }
        public int CountWeapons()
        {
            return Weapons.Count();
        }

        public Weapon GetWeapon(String name)
        {

            foreach (Weapon weapon in Weapons)
            {
                if (weapon.name == name)
                {
                    return weapon;
                }
            }
            throw new ArmoryException("L'arme n'existe pas dans l'armurerie");

        }
    }
}
