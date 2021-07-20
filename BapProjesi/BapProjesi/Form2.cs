using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BapProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[] ports = SerialPort.GetPortNames();
        int ComBoxSelectedIndex;
        string SelectedPort;
        public static uint updateTime;
        public static int Boudrate;
        public static float fan1P,fan1I,fan1D;
        public static float fan2P, fan2I, fan2D;

        private void Form2_Load(object sender, EventArgs e)
        {
            ComBox.Items.AddRange(ports);
            try { 
                ComBox.SelectedIndex = ComBoxSelectedIndex;
            }
            catch { }

            Fan1PTb.Text = Properties.Settings.Default.Fan1P.ToString();
            Fan1ITb.Text = Properties.Settings.Default.Fan1I.ToString();
            Fan1DTb.Text = Properties.Settings.Default.Fan1D.ToString();


            Fan2PTb.Text = Properties.Settings.Default.Fan2P.ToString();
            Fan2ITb.Text = Properties.Settings.Default.Fan2I.ToString();
            Fan2DTb.Text = Properties.Settings.Default.Fan2D.ToString();

            updateTimeBox.Text= Properties.Settings.Default.UpdateTime.ToString();
        }

        private void ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public static float[] values = new float[6];
        public static bool SendSaves;
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool savecheck = true;
            SelectedPort = ComBox.Text;
            ComBoxSelectedIndex = ComBox.SelectedIndex;
            float value;
            if (float.TryParse(Fan1PTb.Text, out value))
            {
                values[0] = value ;
            }
            else { savecheck = false; }

            if (float.TryParse(Fan1ITb.Text, out value))
            {
                values[1] = value ;
            }
            else { savecheck = false; }

            if (float.TryParse(Fan1DTb.Text, out value))
            {
                values[2] = value ;
            }
            else { savecheck = false; }

            if (float.TryParse(Fan2PTb.Text, out value))
            {
                values[3] = value ;
            }
            else { savecheck = false; }

            if (float.TryParse(Fan2ITb.Text, out value))
            {
                values[4] = value ;
            }
            else { savecheck = false; }

            if (float.TryParse(Fan2DTb.Text, out value))
            {
                values[5] = value ;
            }
            else { savecheck = false; }

            if (uint.TryParse(updateTimeBox.Text, out uint intvalue) )
            {
                updateTime = intvalue;
            }
            else { savecheck = false; }

            if (savecheck==true)
            {
                MessageBox.Show("Save Succesfull", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Fan1P = values[0];
                Properties.Settings.Default.Fan1I = values[1];
                Properties.Settings.Default.Fan1D = values[2];

                
                Properties.Settings.Default.Fan2P = values[3];
                Properties.Settings.Default.Fan2I = values[4];
                Properties.Settings.Default.Fan2D = values[5];
                Properties.Settings.Default.Com = SelectedPort;
                Properties.Settings.Default.UpdateTime = updateTime;
                Properties.Settings.Default.Save();
                SendSaves = true;

            }
            else if (savecheck == false)
            {
                MessageBox.Show("Save Failed","Saving", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
