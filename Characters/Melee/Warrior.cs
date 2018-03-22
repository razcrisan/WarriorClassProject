using System;
using Weapons;

namespace Characters.Melee.Warrior

{
public class Warrior
    {
        private int height;
        private int weight;
        private string power;
        private string name;
        private int age;
        private Sword swordWeapon;

       

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
            : this(170, 70)
        {
        }
        public Warrior(int height, int weight)
            : this(height, weight, "Young Midoryia", "One for All")
        {
        }
        public Warrior(int height, int weight, string name, string power)
        {
            this.height = height;
            this.weight = weight;
            this.power = power;
            this.name = name;
            this.SwordWeapon = new Sword();
        }


        public void Greetings(Warrior warrior)
        {
            System.Console.WriteLine($@"Greetings, {warrior.Name}!");
        }
    }
}