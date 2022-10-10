using System;
namespace Aydin_Isamettin_Tp1
{
    public class Player
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Alias { get; set; }
        public string Name { get { return (Alias + " (" + FirstName + " " + LastName + ")"); } }




        public Player(string firstName, string lastName, string alias)
        {
            FirstName = Format(firstName);
            LastName = Format(lastName);
            Alias = alias;
        }

        private static string Format(string str)
        {
            return str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }


        public override string ToString()
        {
            return (Name);
        }

        public override bool Equals(object obj)
        {
            Player c = obj as Player;

            if (c == null)
                return false;
            return Alias == c.Alias;
        }

    }
}

