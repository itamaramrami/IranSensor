using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranSensor
{
    public interface ISensors
    {
        string Name { get; set; }
    }

    internal class Sensor : ISensors
    {
        private static Random random = new Random();
        public string Name { get; set; }


        public Sensor()
        {
            this.Name = RundName();
        }




        public string RundName()
        {
            Array values = Enum.GetValues(typeof(SensorsEnum));
            SensorsEnum randomSensor = (SensorsEnum)values.GetValue(random.Next(values.Length));
            return randomSensor.ToString();
        }


        private enum SensorsEnum
        {
            Temperature,
            Motion,
            Camera
        }
        public static void PrintSensors()
        {
            foreach (var sensor in Enum.GetValues(typeof(SensorsEnum)))
            {
                Console.WriteLine(sensor);
            }
        }
    }
}
