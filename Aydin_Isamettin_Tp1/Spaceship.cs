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
            private set
            {
                isDestroyed = value;
            }
        }
        //6.1
        public List<Weapon> WeaponsList;

        public Spaceship()
        {
            MaxStructure = 100;
            MaxShield = 100;
            CurrentShield = 100;
            CurrentStructure = 100;
            WeaponsList = new List<Weapon>();
        }

        //6.2
        public void AddWeapon(Weapon weapon)
        {
            try
            {
                if (WeaponsList.Count() < 3)
                {
                    WeaponsList.Add(weapon);
                    Console.WriteLine(weapon.name + " ajouté au vaisseau \n");
                }
                else { Console.WriteLine("Vous avez atteint le nombre d'armes maximum\n"); }
            }
            catch (ArmoryException e)
            {
                Console.WriteLine(e);
                return;
            }
        }

    public void RemoveWeapon(Weapon oWeapon)
    {
        WeaponsList.Remove(oWeapon);
        Console.WriteLine("Arme " + oWeapon.name + " supprimé\n");
    }

    public void ClearWeapons()
    {
        WeaponsList.Clear();
        Console.WriteLine("La liste des armes a été vidée\n");
    }

    //6.3
    public void ViewWeapons()
    {
        Console.WriteLine("Liste d'armes du vaisseau : ");
        foreach (Weapon weapon in WeaponsList)
        {
            Console.WriteLine(weapon.ToString());
        }

        if (WeaponsList.Count == 0) { Console.WriteLine("Vide\n"); }
        else { Console.WriteLine(""); };
    }

    public double AverageDamages()
    {
        double moyenne = 0;
        foreach (Weapon weapon in WeaponsList)
        {
            moyenne += ((weapon.MaxDamage + weapon.MinDamage) / 2);
        }
        if ((moyenne / WeaponsList.Count()) > 0) { return moyenne; }
        return 0;
    }

    public void ViewShip()
    {
        Console.WriteLine("Point de structure maximum : " + MaxStructure);
        Console.WriteLine("Point de bouclier maximum : " + MaxShield);
        Console.WriteLine("Point de structure courrant : " + CurrentStructure);
        Console.WriteLine("Point de bouclier courrant : " + CurrentShield);
        ViewWeapons();
    }
}
}