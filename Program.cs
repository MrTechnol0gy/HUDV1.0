using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUDV1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studioname = "Dawnlight Studios."; //studio name
            string gamename = "The Timespun War."; //game title
            int score;  //player score
            float health; //player health
            float shield; //player shield
            int lives; //player lives
            int scoremultiplier; //score multiplier
            int enemyValue; //enemy worth in points
            int enemyDamage; //amount of damage an enemy does

            //intialize variables for gamestart
            score = 0;
            health = 50.0f;
            shield = 75.0f;
            lives = 3;
            scoremultiplier = 1;
            enemyValue = 100;
            enemyDamage = 100;

            Console.WriteLine(studioname);
            Console.WriteLine(gamename);
            Console.WriteLine();
            Console.WriteLine("Health: {0}. Shields: {1}. Lives: {2}", health, shield, lives);
            Console.WriteLine("Score: {0} X {1}", score, scoremultiplier);
            Console.WriteLine("Press any key to attempt a strike!");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("A true strike!");
            Console.WriteLine();
            Console.ReadKey(true);

            score = score + enemyValue * scoremultiplier;
            scoremultiplier *= 2;

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Health: {0}. Shields: {1}. Lives: {2}", health, shield, lives);
            Console.WriteLine("Score: {0} X {1}", score, scoremultiplier);
            Console.WriteLine("Press any key to attempt a strike!");
            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("A critical miss!");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.Clear();

            scoremultiplier = 1;
            health = health + shield - enemyDamage;
            shield = shield - enemyDamage;

            Console.WriteLine();
            Console.WriteLine("Health: {0}. Shields: {1}. Lives: {2}", health, shield, lives);
            Console.WriteLine("Score: {0} X {1}", score, scoremultiplier);
            Console.WriteLine("Press any key to attempt a strike!");
            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("A karmic strike! You have died!");
            Console.WriteLine();
            Console.ReadKey(true);

            Console.Clear();

            score = score + enemyValue * scoremultiplier;
            scoremultiplier *= 2;
            health = health + shield - enemyDamage;
            shield = shield - enemyDamage;
            lives = 2;

            Console.WriteLine();
            Console.WriteLine("Health: {0}. Shields: {1}. Lives: {2}", health, shield, lives);
            Console.WriteLine("Score: {0} X {1}", score, scoremultiplier);
            Console.WriteLine("Press any key to attempt a strike!");
            Console.ReadKey(true);

        }
    }
}
