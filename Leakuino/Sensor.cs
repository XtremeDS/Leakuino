using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leakuino
{
    [Serializable]
    class Sensor
    {
        int idSensor;
        int idArduino;
        string name;
        int port;
        List<int> nrThreshold;

        public Sensor(int id, int idArd, string nameSensor, int portSensor, List<int> nrThresh)
        {
            idSensor = id;
            idArduino = idArd;
            name = nameSensor;
            port = portSensor;
            nrThreshold = nrThresh;
        }

        public int PropIdArduino
        {
            get { return idArduino; }
            set { idArduino = value; }
        }

        public int PropidSensor
        {
            get { return idSensor; }
            set { idSensor = value; }
        }

        public string PropName
        {
            get { return name; }
            set { name = value; }
        }

        public int PropPort
        {
            get { return port; }
            set { port = value; }
        }

        public void AddThreshold(List<int> thresh)
        {
            nrThreshold = thresh;
        }

        public List<int> GetThreshold()
        {
            return nrThreshold;
        }

    }
}
