using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Human h1 = new Human();
            Human h2 = new Human("Freddie", "Mercury");

            h1.AboutMe();
            h2.AboutMe();
            
            Human h3 = new Human("John", "Snow", "brown");
            Human h4 = new Human("Jack", "Stalk", 13);
            Human h5 = new Human("Chuck", "Sho", "blue", 30);

            h3.AboutMe();
            h4.AboutMe();
            h5.AboutMe();

            Human h6 = new Human("Heavy", "Joe", 40);
            h6.Weight = 300;
            h6.Weight = -123;
        }
    }
}
