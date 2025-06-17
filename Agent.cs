using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranSensor
{
    internal class Agent
    {

        public string Name { get; set; }
        public int Rank { get; set; }
        public List<Sensor> Sensors { get; set; }
        public Agent(string name, int rank = 2)
        {
            this.Name = name;
            this.Rank = rank;
            this.Sensors = AddSensors(this.Rank);
        }
        public List<Sensor> AddSensors(int rank)
        {
            List<Sensor> sensors = new List<Sensor>();
            for (int i = 0; i < rank; i++)
            {
                sensors.Add(new Sensor());
            }
            return sensors;
        }
        public static void Pri(Agent person)
        {
            for (int i = 0; i < person.Rank; i++)
            {
                Console.WriteLine(person.Sensors[i].Name);
            }
        }
        public int Activate(string[] guesses)
        {
            int correctCount = 0;

            int length = Math.Min(guesses.Length, Sensors.Count);

            for (int i = 0; i < length; i++)
            {
                if (guesses[i].Equals(Sensors[i].Name, StringComparison.OrdinalIgnoreCase))
                {
                    correctCount++;
                }
            }

            return correctCount;
        }





    }
}
