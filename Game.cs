using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranSensor
{
    internal class Game
    {
        public static void Start()
        {
            Agent n = new Agent("itamar");

            string[] Guess = new string[n.Rank];
            for (int i = 0; i < Guess.Length; i++)
            {
                Guess[i] = "";
            }
            Console.WriteLine("We caught an Iranian agent. What sensor would you like to give him?");
            Sensor.PrintSensors();
            string Gues = Console.ReadLine();
            Console.WriteLine("In what location would you like to insert it? 0/1 ");
            int loc = int.Parse(Console.ReadLine());
            Guess[loc] = Gues;
            while (n.Activate(Guess) != n.Rank)
            {
                Console.WriteLine($"You managed to put a sensor {n.Activate(Guess)}/{n.Rank}");
                Agent.Pri(n); ;
                Console.WriteLine("We caught an Iranian agent. What sensor would you like to give him?");
                Sensor.PrintSensors();
                Gues = Console.ReadLine();
                Console.WriteLine("In what location would you like to insert it? 0/1 ");
                loc = int.Parse(Console.ReadLine());
                Guess[loc] = Gues;
            }
            Console.WriteLine("Well done, you successfully brought down the agent.");


        }
    }
}
