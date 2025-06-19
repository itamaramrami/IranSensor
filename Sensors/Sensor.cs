using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranSensor
{
    

    internal class Sensor : Interface.ISensors
    {
        private static Random random = new Random();
        public string Name { get; set; }

        public int count { get; set; }

        public bool Activatee { get; set; }

        public Sensor()
        {
            this.Name = RundName();
            this.Activatee = false;
            this.count = 0;
        }


        public void Activate()
        {
            this.Activatee = true;
            this.count += 1;
        }

        public string RundName()
        {
            Array values = Enum.GetValues(typeof(Interface.SensorsEnum));
            Interface.SensorsEnum randomSensor = (Interface.SensorsEnum)values.GetValue(random.Next(values.Length));
            return randomSensor.ToString();
        }


        
        public static void PrintSensors()
        {
            foreach (var sensor in Enum.GetValues(typeof(Interface.SensorsEnum)))
            {
                Console.WriteLine(sensor);
            }
        }
    }
}
