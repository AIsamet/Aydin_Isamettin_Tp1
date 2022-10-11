using System;
namespace Aydin_Isamettin_Tp1
{
    public class Armory
    {
        //5.1
        public List<Weapon> Weapons { get; set; }

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
            foreach (Weapon weapon in Weapons)
            {
                Console.WriteLine(weapon.ToString());
            }
        }

        public void AddWeapon(Weapon nouvelleArme)
        {
            Weapons.Add(nouvelleArme);
        }

        public void RemoveWeapon(Weapon armeSupprimer)
        {
            foreach (Weapon w in Weapons)
            {
                if(w.name == armeSupprimer.name)
                {
                    Weapons.Remove(armeSupprimer);
                }
            }
        }

        public int CountWeapons()
        {
            return Weapons.Count();
        }


    }
}
