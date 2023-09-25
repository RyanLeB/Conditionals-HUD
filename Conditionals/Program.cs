using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        // declarations
        static int health;
        static int lives;
        static int weapon;


        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------------");
            Console.WriteLine();

            // initialization
            health = 100;
            lives = 3;
            weapon = 0;


            // take damage
            ShowHUD();
            TakeDMG(10);
            ShowHUD();
            TakeDMG(25);
            ShowHUD();
            TakeDMG(50);
            ShowHUD();
            Heal(25);
            ShowHUD();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        
        
        }
       
        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
        }
        
        static void Heal(int healed)
        {
            health = health + healed;
        }
        
        
        static void weaponSelected(int weaponPickedup)
        {

            weapon = weapon + weaponPickedup;
            
            
            if (weapon == 0)
            {
                Console.WriteLine("Pistol equipped");
            }

            if (weapon == 1)
            {
                Console.WriteLine("shotgun equipped");
            }

            if (weapon == 2)
            {
                Console.WriteLine("spreader equipped");
            }
        
            if (weapon == 3)
            {
                Console.WriteLine("laser equipped");
            }
            
            if (weapon == 4)
            {
                Console.WriteLine("sniper equipped");
            }

            if (weapon == 5)
            {
                Console.WriteLine("bfg equipped (big friendly giant)");
            }
        
        }
        
        static void TakeDMG(int damage)
        {
           
            // apply damage first before range check
            Console.WriteLine("Player about to take " + damage + " damage");
            health = health - damage;
            
            if (health <= 0)
            {
                Console.WriteLine("Player died...");

                lives = lives - 1;
                // range check lives after
                if (lives <= 0)
                {
                    Console.WriteLine("Game Over...");
                }

                
                health = 0;
            }
        }
    }
}
