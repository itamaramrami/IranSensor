using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranSensor.Interface
{
    public interface ISensors
    {
        string Name { get; set; }

        int count { get; set; }

        bool Activatee { get; set; }
        //int Isefect();

    }

    public enum SensorsEnum
    {
        Temperature,
        Motion,
        Camera
    }

}
