using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leakuino
{
    public partial class formMain : Form
    {
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private Options winOptions;

        ImageList myImageList;

        public formMain()
        {
            InitializeComponent();

            myImageList = new ImageList();
            myImageList.ColorDepth = ColorDepth.Depth32Bit;
            myImageList.Images.Add(Image.FromFile("F:\\Universidade\\MEICM\\MRC\\Leakuino\\Green.png"));
            myImageList.Images.Add(Image.FromFile("F:\\Universidade\\MEICM\\MRC\\Leakuino\\Red.png"));

            myImageList.ImageSize = new Size(32, 32);
            lstSensors.LargeImageList = myImageList;

            winOptions = new Options();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            /*string source = item["source"].InnerText;
                string subject = item["subject"].InnerText;
                string summary = item["summary"].InnerText;
                string date = item["date"].InnerText;

                if (item.Name == "RSSEntry")
                {
                    lstPrincipal.Items.Add(new ListViewItem(new[] { source + " - " + subject, summary, date }, 0));
                }
                else if (item.Name == "TwitterEntry")
                {
                    lstPrincipal.Items.Add(new ListViewItem(new[] { source + " - " + subject, summary, date }, 1));
                }
                else
                {
                    lstPrincipal.Items.Add(new ListViewItem(new[] { source + " - " + subject, summary, date }, 2));
                }*/

            string state = "Nsadasdsadsa";
            string location = "Kitchenasdadasdasdsadsadasdsadsa";

            string val;
            string val2;

            serialPort1 = new System.IO.Ports.SerialPort("COM8", 9600);
            serialPort2 = new System.IO.Ports.SerialPort("COM9", 9600);

            serialPort2.PortName = "COM9";
            serialPort2.BaudRate = 9600; 

            serialPort1.Open();
            val = serialPort1.ReadLine();
            serialPort1.Close();

            /*serialPort2.Open();
            val2 = serialPort2.ReadLine();
            serialPort2.Close();*/

            if (Convert.ToInt32(val)== 0)
            {
                lstSensors.Items.Add(new ListViewItem(new[] { "No Leak", serialPort1.PortName }, 0));
            }
            else
            {
                lstSensors.Items.Add(new ListViewItem(new[] { "Leak!", serialPort1.PortName }, 1));
            }

            /*if (Convert.ToInt32(val2) == 0)
            {
                lstSensors.Items.Add(new ListViewItem(new[] { "No Leak", serialPort2.PortName }, 0));
            }
            else
            {
                lstSensors.Items.Add(new ListViewItem(new[] { "Leak!", serialPort2.PortName }, 1));
            }*/
            
            lstSensors.Items.Add(new ListViewItem(new[] { state, location }, 1));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            winOptions.ShowDialog(); 
        }
    }
}
