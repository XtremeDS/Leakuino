using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leakuino
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        /*List<ConfSerial> lstSerial = new List<ConfSerial>();

            lstSerial.Add(new ConfSerial("COM8",9600));
            lstSerial.Add(new ConfSerial("COM9", 9600));

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("ConfSerial.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, lstSerial);
            stream.Close();*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            List<Node> lstNodes;
            try
            {
                IFormatter formatterRead = new BinaryFormatter();
                Stream streamRead = new FileStream("ConfNodes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                lstNodes = (List<Node>)formatterRead.Deserialize(streamRead);
                streamRead.Close();

            }
            catch (Exception excep)
            {
                lstNodes = new List<Node>();
            }

            int sizeNodes = lstNodes.Count;

            Node nod;
            try
            {
                nod = new Node(sizeNodes + 1, txtNameNode.Text, txtPortNode.Text, Convert.ToInt32(txtBaudrate.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert correct baudrate (E.g 9600)", "Error");
                return;
            }

            lstNodes.Add(nod);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("ConfNodes.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, lstNodes);
            stream.Close();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Nodes
            List<Node> lstNodes = new List<Node>();
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("ConfNodes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                lstNodes = (List<Node>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Couldn't load the file" + excep.Message, "Error");
            }

            lstAllNodes.Items.Clear();
            lstAllSensors.Items.Clear();

            foreach(Node nod in lstNodes)
            {
                lstAllNodes.Items.Add(new ListViewItem(new[] { Convert.ToString(nod.PropIdNode), nod.PropName, nod.PropPort, Convert.ToString(nod.PropBaudrate) }));

                foreach (Sensor sens in nod.GetSensors())
                {
                    lstAllSensors.Items.Add(new ListViewItem(new[] { Convert.ToString(sens.PropidSensor), sens.PropName, Convert.ToString(sens.PropPort), string.Join(";", sens.GetThreshold()), Convert.ToString(sens.PropIdArduino) }));
                }

            }

        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {

            List<Node> lstNodes = new List<Node>();
            try
            {
                IFormatter formatterRead = new BinaryFormatter();
                Stream streamRead = new FileStream("ConfNodes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                lstNodes = (List<Node>)formatterRead.Deserialize(streamRead);
                streamRead.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Couldn't load the file" + excep.Message, "Error");
            }

            foreach (Node nod in lstNodes)
            {
                if (nod.PropIdNode == Convert.ToInt32(txtIDNode.Text))
                {
                    string[] tmpthre = txtThreshold.Text.Split(';');
                    List<int> lstThresh = new List<int>();

                    foreach (string tmpvalue in tmpthre)
                    {
                        lstThresh.Add(Convert.ToInt32(tmpvalue));
                    }

                    Sensor sens = new Sensor(nod.SensorCount(), nod.PropIdNode, txtNameSensor.Text,Convert.ToInt32(txtPortSensor.Text), lstThresh);

                    nod.AddSensor(sens);

                    //Sensor sens = new Sensor(nod.SensorCount, Convert.ToInt32(txtIDNode.Text), Convert.ToInt32(txtPortSensor.Text), List<int>tmp);
                    lstAllSensors.Items.Add(new ListViewItem(new[] { Convert.ToString(nod.SensorCount()), txtNameSensor.Text, txtPortSensor.Text, txtThreshold.Text, Convert.ToString(nod.PropIdNode)}));
                }
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("ConfNodes.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, lstNodes);
            stream.Close();

        }


    }
}
