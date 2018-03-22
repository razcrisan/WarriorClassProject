using System;
using Characters.Melee.Warrior;


namespace OOPPractice
{

    class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior firstWarrior = new Warrior();
            Warrior secondWarrior = new Warrior(150, 50);
            Warrior thirdWarrior = new Warrior(890, 987, "I am the third warrior,", "RazzyFrezsh");

            Warrior theGoodGuy = new Warrior(190, 80, "Sangwynn", "One For All");

            Warrior youngWarrior = new Warrior(560, 400);
            youngWarrior.Age = 18;
            System.Console.WriteLine(youngWarrior.Age);


            Warrior theBadGuy = new Warrior(150, 60, "Thanos" , "All For One");

            System.Console.WriteLine(theBadGuy.Power);
            System.Console.WriteLine(theGoodGuy.Power);

            System.Console.WriteLine(theGoodGuy.Age);
            System.Console.WriteLine(theBadGuy.Age);
            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);
            theGoodGuy.Height = 10;
            Console.WriteLine(theGoodGuy.SwordWeapon.Damage);
        }
    }
}
