using System;
namespace Aydin_Isamettin_Tp1
{
    public class SpaceInvaders
    {
        public SpaceInvaders()
        {
            Init();
        }

        static void Main()
        {
            SpaceInvaders jeu = new SpaceInvaders();
            
        }


        private void Init()
        {
            Player a = new Player("john", "doe", "jojo");
            Player b = new Player("jane", "doe", "jaja");
            Player c = new Player("michel", "meyer", "mimi");
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}

