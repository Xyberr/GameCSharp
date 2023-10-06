using System;
using System.Runtime.InteropServices;
using System.Security.Policy;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ConsoleApplication1
{
    internal class Program
    {

        public static int enemyHealth = 1000;
        public static float Health = 100;
        public static int Armor = 2;
        public static int DamageSword = 25;
        public static int KillItem = 99999;
        public static string Name;
        public static string Item;
        public static int Score = 0;


        public static void Main(string[] args)
        {
            firstScreen();
            
            Item = Console.ReadLine();
            
            switch (Item)
            {
                case "IronSword":
                    enemyHealth -= DamageSword;

                    ArmorPlayer();

                    Score += 50;
                    Console.WriteLine($"You score: {Score}");
                    
                    Console.WriteLine($"Enemy health: {enemyHealth}");
                    break;
                
                case "KillItem":
                    enemyHealth -= KillItem;

                    Score += 1000;
                    
                    Console.WriteLine($"Enemy health: {enemyHealth}");
                    break;

                case "Armor":
                    Armor += 50;
                    
                    Console.WriteLine($"You armor: {Armor}");
                    break;
                
                case "HealthPotion":
                    Health += 25;

                    Console.WriteLine($"You health: {Health}");
                    break;
                
                case "ScoreItem":
                    Score += 1000;

                    Console.WriteLine($"You score: {Score}");
                    break;
                    
                default:
                    Console.WriteLine("Unknown item!");
                    break;
            }

            if (enemyHealth <= 0)
            {
                isDeadEnemy();
            }
        }

        static float ArmorPlayer()
        {
            if (Armor > 0)
            {
                DamageSword = DamageSword / Armor;
            }

            return DamageSword;
        }
        
        static void isDeadPlayer()
        {
            if (Health <= 0)
            {
                Console.WriteLine("You died, game over!");
            }
        }

        static void isDeadEnemy()
        {
            if (enemyHealth <= 0)
            {
                Console.WriteLine("Wow! you can kill enemy!");
                Console.WriteLine($"you score: {Score}");
            }
        }

        static void firstScreen()
        {
            Console.WriteLine("Write your name:");
            Name = Console.ReadLine();
            Console.WriteLine($"Hello {Name}! Welcome my test game, your task is to kill the enemy!");
            Console.WriteLine($"nickname: {Name}");
            Console.WriteLine($"You health: {Health}");
            Console.WriteLine($"health enemy: {enemyHealth}");
            Console.WriteLine("Select item: Iron Sword, Gold Sword");
        }
    }
}