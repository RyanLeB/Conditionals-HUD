using System;
using System.Collections.Generic;
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



        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine("------------------");
            Console.WriteLine();

            // initialization
            health = 100;
            lives = 3;



            // take damage
            ShowHUD();
            TakeDMG(10);
            ShowHUD();
            TakeDMG(25);
            ShowHUD();
            TakeDMG(50);
            ShowHUD();
            TakeDMG(25);
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
