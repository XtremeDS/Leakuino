using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leakuino
{
    [Serializable]
    class Node
    {
        private int idNode = 1;
        private string port = "COM1";
        private string name = "Null";
        private int baudrate = 9600;
        List<Sensor> lstSensor = new List<Sensor>();

        public Node(int id, string nameNode, string inPort, int inBaudrate)
        {
            idNode = id;
            name = nameNode;
            port = inPort;
            baudrate = inBaudrate;
        }

        public int PropIdNode
        {
            get { return idNode; }
            set { idNode = value; }
        }

        public string PropPort
        {
            get { return port; }
            set { port = value; }
        }

        public int PropBaudrate
        {
            get { return baudrate; }
            set { baudrate = value; }
        }

        public string PropName
        {
            get { return name; }
            set { name = value; }
        }

        public void AddSensor(Sensor sens)
        {
            lstSensor.Add(sens);
        }

        public List<Sensor> GetSensors()
        {
            return lstSensor;
        }

        public int SensorCount()
        {
            return lstSensor.Count;
        }

    }

}
