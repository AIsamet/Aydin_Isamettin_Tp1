using System;
namespace Aydin_Isamettin_Tp1
{
    public class Spaceship
    {
        //3.3
        private bool isDestroyed;
        private int currentStructure;
        //3.1
        private int MaxStructure { get; set; }
        private int MaxShield { get; set; }
        //3.2
        public int CurrentShield { get; set; }
        //3.3
        public int CurrentStructure
        {
            get
            {
                return currentStructure;
            }
            set
            {
                currentStructure = value;
                if (CurrentStructure == 0)
                {
                    IsDestroyed = true;
                }
            }
        }
        //3.3
        public bool IsDestroyed
        {
            get
            {
                if (CurrentStructure == 0)
                {
                    return true;
                }
                else return false;
            }
            set
            {
                isDestroyed = value;
            }
        }
        //6.1
        public Armory Armurerie { get; set; }

        public Spaceship(int currentShield, int currentStructure)
        {
            MaxStructure = 100;
            MaxShield = 100;
            CurrentShield = currentShield;
            CurrentStructure = currentStructure;
            this.Armurerie = new Armory();
        }

        //6.2
        public void AddWeapon(Weapon weapon)
        {
            if (Armurerie.CountWeapons() < 3)
            {
                Armurerie.Weapons.Add(weapon);
            }
            else Console.WriteLine("Erreur, vous avez deja 3 armes");
        }

        public void RemoveWeapon(Weapon oWeapon)
        {
            Armurerie.Weapons.Remove(oWeapon);
        }

        //6.3
        public void ViewWeapons()
        {
            Armurerie.ViewArmory();
        }

        public double AverageDamages()
        {
            double moyenne=0;
            foreach (Weapon weapon in Armurerie.Weapons)
            {
                moyenne += (weapon.MaxDamage-weapon.MinDamage);
            }
            return moyenne / Armurerie.CountWeapons();
        }
    }
}