using System;
using Weapons;
using Enumerations;

namespace Characters.Melee.Warrior

{
public class Warrior
    {
        private const int DEFAULT_HEIGHT = 180;
        private const int DEFAULT_WEIGHT = 170;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Midoriya";
        private const string DEFAULT_POWER = "One For All";
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        public static int idCounter;
        private readonly int id;
        private int height;
        private int weight;
        private string power;
        private string name;
        private int age;
        private Sword swordWeapon;
        private Faction faction;
        public int healthPoints;
        public int HealthPoints 
        { 
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public Faction Faction 
        { 
            get
            {
                return this.faction;
            } 
            private set
            {
                this.faction = value;
            }
        }


        public int ID 
        {
            get
            {
                return this.id;
            }
        }
       
        public static int IdCounter
        { 
            get
            { 
                return Warrior.idCounter;
            }
            private set
            {
                Warrior.idCounter = value;
            } 
        }
        public int Age { 
            get{
                return age;
            }
            set{
                if (value >= 18 && value <= 45){
                     age = value;
                }
                else{
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {name}, is not a proper age for a warrior, must be between 18-45");
                }
            }
        }
        public int Height { 
            get{
                
                return height;
            } 
            set{
                height = value;
            } 
        }
        public int Weight { 
            get{
                return weight;
            } 
            set{
                weight = value;
            } 
        }
        public string Power { 
            get{
                return power;
            } 
            set{
                power = value;
            } 
        }
        public string Name { 
            get{
                return name;
            } 
            set{
                name = value;
            } 
        }
        public Sword SwordWeapon { 
            get{
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        
        // : this() adds a default height and weight for the warriors
        public Warrior()
            : this(DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {
        }
        public Warrior(int height, int weight)
            : this(height, weight, DEFAULT_NAME, DEFAULT_POWER, string.Empty)
        {
        }
        public Warrior(int height, int weight, string name, string power, string faction)
        {
            IdCounter++;

            this.Faction = faction;
            this.id = IdCounter;
            this.height = height;
            this.weight = weight;
            this.power = power;
            this.Age = DEFAULT_AGE;
            this.name = name;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
            Warrior.IdCounter++;

            if (this.Faction == "Good Guy")
            {
                this.healthPoints = 120;

            }
            else if (this.Faction == "Bad Guy")
            {
                this.healthPoints = 100;
            }
        }


        public void Greetings(Warrior warrior)
        {
            System.Console.WriteLine($@"Greetings, {warrior.Name}!");
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            System.Console.WriteLine($"Default Height: {DEFAULT_HEIGHT}" + 
            $"\nDefault Weight: {DEFAULT_WEIGHT}" +
            $"\nDefault Age: {DEFAULT_AGE}" +
            $"\nDefault Name: {DEFAULT_NAME}" +
            $"\nDefault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}"
            );
        }




    

    }
}