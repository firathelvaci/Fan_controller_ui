using EasyModbus;
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
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.IO;

namespace BapProjesi
{
   
    public partial class Form1 : Form
    {
        static class RegisterTags
        {
            public const int fan1_Start_Stop = 0;
            public const int fan1_manual_oto = 1;
            public const int fan2_Start_Stop = 2;
            public const int fan2_manual_oto = 3;
            public const int sensor1_set = 4;
            public const int sensor2_set = 5;
            public const int sensor1_voltaj = 6;
            public const int sensor2_voltaj = 7;
            public const int fan1_yuzde = 8;
            public const int fan2_yuzde = 9; 
            public const int y1_sensor1_output = 10;
            public const int y2_sensor2_output = 11;
            public const int fan1_p = 12;
            public const int fan1_i = 13;
            public const int fan1_d = 14;
            public const int fan2_p = 15;
            public const int fan2_i = 16;
            public const int fan2_d = 17;
  

        }

        public static  ModbusClient modbusClient;
        int[] tab_reg=new int[18];
        Stopwatch fan1Time = new Stopwatch();
        Stopwatch fan2Time = new Stopwatch();
        List<float> Fan1Speedlist = new List<float>();
        List<float> Prob1Speedlist = new List<float>();
        List<double> fan1Timelist = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(Properties.Settings.Default.Com);
                modbusClient.Baudrate = 115200;
                modbusClient.StopBits = StopBits.One;
                modbusClient.Parity = Parity.None;
                modbusClient.UnitIdentifier = 1;
                modbusClient.Connect();
                MessageBox.Show("Connected Sucsessfuly", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeltaTime.Start();
                Fan1AutoBtn.Enabled = true;
                Fan1ManualBtn.Enabled = true;
                Fan1StartBtn.Enabled = true;
                Fan1StopBtn.Enabled = true;

                Fan2AutoBtn.Enabled = true;
                Fan2ManualBtn.Enabled = true;
                Fan2StartBtn.Enabled = true;
                Fan2StopBtn.Enabled = true;
                DisconnectBtn.Enabled = true;

                Fan1SetBtn.Enabled = true;
                Prob1SetBtn.Enabled = false;

                Fan2SetBtn.Enabled = true;
                Prob2SetBtn.Enabled = false;

                Fan1StartBt.Enabled = true;
                Fan1StopBt.Enabled = true;
                Fan1SaveBt.Enabled = true;
                Fan1ClearBt.Enabled = true;


                Fan2StartBt.Enabled = true;
                Fan2StopBt.Enabled = true;
                Fan2SaveBt.Enabled = true;
                Fan2ClearBt.Enabled = true;

                Fan1ManualBtn.BackColor = Color.Green;
                Fan2ManualBtn.BackColor = Color.Green;

                Fan1StopBtn.BackColor = Color.Red;
                Fan2StopBtn.BackColor = Color.Red;

                Fan1StopBt.BackColor = Color.Red;
                Fan2StopBt.BackColor = Color.Red;
                ConnectionLbl.Text = "Connected";
                int[] write = new int[10] { 0,0,0,0,0,0,0,0,0,0};
                modbusClient.WriteMultipleRegisters(0, write);
            }
            
            catch (Exception)
            {
                ConnectionLbl.Text = "Disconnected";
                MessageBox.Show("Not Connected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected )
            {
                int[] write = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                modbusClient.WriteMultipleRegisters(0, write);
                modbusClient.Disconnect();
                MessageBox.Show("Bağlantı Kapatıldı","Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DeltaTime.Stop();
                ConnectionLbl.Text = "Disconnected";
                ConnectionLbl.BackColor = Color.Red;

                Fan1AutoBtn.Enabled = false;
                Fan1ManualBtn.Enabled = false;
                Fan1StartBtn.Enabled = false;
                Fan1StopBtn.Enabled = false;

                Fan1AutoBtn.BackColor = Color.Gainsboro;
                Fan1ManualBtn.BackColor = Color.Gainsboro;
                Fan1StartBtn.BackColor = Color.Gainsboro;
                Fan1StopBtn.BackColor = Color.Gainsboro;

                Fan2AutoBtn.Enabled = false;
                Fan2ManualBtn.Enabled = false;
                Fan2StartBtn.Enabled = false;
                Fan2StopBtn.Enabled = false;
                DisconnectBtn.Enabled = false;

                Fan2AutoBtn.BackColor = Color.Gainsboro;
                Fan2ManualBtn.BackColor = Color.Gainsboro;
                Fan2StartBtn.BackColor = Color.Gainsboro;
                Fan2StopBtn.BackColor = Color.Gainsboro;

                Fan1SetBtn.Enabled = false;
                Prob1SetBtn.Enabled = false;

                Fan1SetBtn.BackColor = Color.Gainsboro;
                Prob1SetBtn.BackColor = Color.Gainsboro;

                Fan2SetBtn.Enabled = false;
                Prob2SetBtn.Enabled = false;

                Fan2SetBtn.BackColor = Color.Gainsboro;
                Prob2SetBtn.BackColor = Color.Gainsboro;

                Fan1StartBt.Enabled = false;
                Fan1StopBt.Enabled = false;
                Fan1SaveBt.Enabled = false;
                Fan1ClearBt.Enabled = false;

                Fan1StartBt.BackColor = Color.Gainsboro;
                Fan1StopBt.BackColor = Color.Gainsboro;
                Fan1SaveBt.BackColor = Color.Gainsboro;
                Fan1ClearBt.BackColor = Color.Gainsboro;

                Fan2StartBt.Enabled = false;
                Fan2StopBt.Enabled = false;
                Fan2SaveBt.Enabled = false;
                Fan2ClearBt.Enabled = false;

                Fan2StartBt.BackColor = Color.Gainsboro;
                Fan2StopBt.BackColor = Color.Gainsboro;
                Fan2SaveBt.BackColor = Color.Gainsboro;
                Fan2ClearBt.BackColor = Color.Gainsboro;


            }
        }

        private void DeltaTime_Tick(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                tab_reg=modbusClient.ReadHoldingRegisters(0, 18);
                
                ConnectionLbl.BackColor = Color.Green;
                //test
                //ConnectionLbl.Text =tab_reg[RegisterTags.fan2_i].ToString();

                Fan1SpeedLbl.Text= (tab_reg[RegisterTags.fan1_yuzde] /10.0f).ToString();
                Fan2SpeedLbl.Text = (tab_reg[RegisterTags.fan2_yuzde] / 10.0f).ToString();

                Prop1TargetLbl.Text = (tab_reg[RegisterTags.sensor1_set] / 10.0f).ToString();
                Prop2TargetLbl.Text = (tab_reg[RegisterTags.sensor2_set] / 10.0f).ToString();


                Prop1SpeedLbl.Text = (tab_reg[RegisterTags.y1_sensor1_output] / 10.0f).ToString();
                Prop2SpeedLbl.Text = (tab_reg[RegisterTags.y2_sensor2_output] / 10.0f).ToString();

                if (Form2.SendSaves)
                {   int[]  Intarray = new int[Form2.values.Length];
                    for(int i=0;i< Form2.values.Length;i++)
                    {
                        Intarray[i] =Convert.ToInt32( Form2.values[i]*100.0f);
                    }
                    DeltaTime.Interval = Convert.ToInt32(Properties.Settings.Default.UpdateTime);
                    modbusClient.WriteMultipleRegisters(RegisterTags.fan1_p, Intarray);
                    Form2.SendSaves = false;

                }

                if(Fan1StartBtn.BackColor==Color.Green && Fan1AutoBtn.BackColor == Color.Green && Fan1StartBt.BackColor == Color.Green)
                {
                    if (!fan1Time.IsRunning)
                    {
                        fan1Time.Start();
                    }
                    var time = Math.Round(fan1Time.Elapsed.TotalMilliseconds / 1000.0f, 2);
                    Fan1Chart.Series[0].Points.AddXY(time , tab_reg[RegisterTags.fan1_yuzde] / 10.0f);
                    Fan1Chart.Series[1].Points.AddXY(time , tab_reg[RegisterTags.y1_sensor1_output] / 10.0f);
                    Fan1Speedlist.Add(tab_reg[RegisterTags.fan1_yuzde] / 10.0f);
                    Prob1Speedlist.Add(tab_reg[RegisterTags.y1_sensor1_output] / 10.0f);
                    fan1Timelist.Add(time);
                    Fan1Chart.ChartAreas[0].AxisX.Maximum = (time * 1.2f) ;

                }
                else { fan1Time.Stop(); }
            }
        }


        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionLbl.BackColor = Color.Red;
            Fan1AutoBtn.Enabled = false;
            Fan1ManualBtn.Enabled = false;
            Fan1StartBtn.Enabled = false;
            Fan1StopBtn.Enabled = false;

            Fan2AutoBtn.Enabled = false;
            Fan2ManualBtn.Enabled = false;
            Fan2StartBtn.Enabled = false;
            Fan2StopBtn.Enabled = false;
            DisconnectBtn.Enabled = false;

            Fan1SetBtn.Enabled = false;
            Prob1SetBtn.Enabled = false;

            Fan2SetBtn.Enabled = false;
            Prob2SetBtn.Enabled = false;

            Fan1StartBt.Enabled = false;
            Fan1StopBt.Enabled = false;
            Fan1SaveBt.Enabled = false;
            Fan1ClearBt.Enabled = false;


            Fan2StartBt.Enabled = false;
            Fan2StopBt.Enabled = false;
            Fan2SaveBt.Enabled = false;
            Fan2ClearBt.Enabled = false;

            Form2.values[0] = Properties.Settings.Default.Fan1P;
            Form2.values[1] = Properties.Settings.Default.Fan1I;
            Form2.values[2] = Properties.Settings.Default.Fan1D;


            Form2.values[3] = Properties.Settings.Default.Fan2P;
            Form2.values[4] = Properties.Settings.Default.Fan2I;
            Form2.values[5] = Properties.Settings.Default.Fan2D;
            Form2.SendSaves = true;

            
        }

        private void Fan1StartBtn_Click(object sender, EventArgs e)
        {
            
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 1 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan1_Start_Stop, write);
                Fan1StartBtn.BackColor = Color.Green;
                Fan1StopBtn.BackColor = Color.Gainsboro;



            }
        }

        private void Fan1StopBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 0 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan1_Start_Stop, write);
                Fan1StartBtn.BackColor = Color.Gainsboro; 
                Fan1StopBtn.BackColor = Color.Red;

            }
        }

        private void Fan1ManualBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 0 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan1_manual_oto, write);
                Fan1ManualBtn.BackColor = Color.Green;
                Fan1AutoBtn.BackColor = Color.Gainsboro;

                Fan1SetBtn.Enabled = true;
                Prob1SetBtn.Enabled = false;
            }
        }

        private void Fan1AutoBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 1 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan1_manual_oto, write);
                Fan1AutoBtn.BackColor = Color.Green;
                Fan1ManualBtn.BackColor = Color.Gainsboro;

                Fan1SetBtn.Enabled = false;
                Prob1SetBtn.Enabled = true;
            }
        }

        private void Fan2StartBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 1 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan2_Start_Stop, write);
                Fan2StartBtn.BackColor = Color.Green;
                Fan2StopBtn.BackColor = Color.Gainsboro;

            }
        }

        private void Fan2StopBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 0 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan2_Start_Stop, write);
                Fan2StartBtn.BackColor = Color.Gainsboro;
                Fan2StopBtn.BackColor = Color.Red;

            }
        }

        private void Fan2ManualBtn_Click(object sender, EventArgs e)
        {

            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 0 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan2_manual_oto, write);
                Fan2ManualBtn.BackColor = Color.Green;
                Fan2AutoBtn.BackColor = Color.Gainsboro;

                Fan2SetBtn.Enabled = true;
                Prob2SetBtn.Enabled = false;
            }
        }

        private void Fan2AutoBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] write = new int[1] { 1 };
                modbusClient.WriteMultipleRegisters(RegisterTags.fan2_manual_oto, write);
                Fan2AutoBtn.BackColor = Color.Green;
                Fan2ManualBtn.BackColor = Color.Gainsboro;

                Fan2SetBtn.Enabled = false;
                Prob2SetBtn.Enabled = true;

            }
        }

        private void Fan1SetBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                //float value
                int[] write = new int[1];
                if (float.TryParse(Fan1SpeedTb.Text, out float value))
                {
                    if (100 > value && value > 0)
                    {
                        write[0] = Convert.ToInt32(value * 10.0f);
                        modbusClient.WriteMultipleRegisters(RegisterTags.fan1_yuzde, write);
                    }

                }
            }
        }

        private void Fan2SetBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                //float value
                int[] write = new int[1];
                if (float.TryParse(Fan2SpeedTb.Text, out float value))
                {   if (100 > value && value > 0)
                    {
                        write[0] = Convert.ToInt32(value * 10.0f);
                        modbusClient.WriteMultipleRegisters(RegisterTags.fan2_yuzde, write);
                    }
                     
                }
            }
        }

        private void Prob1SetBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                //float value
                int[] write = new int[1];
                if (float.TryParse(Prob1TargetTb.Text, out float value))
                {
                        write[0] = Convert.ToInt32(value * 10.0f);
                        modbusClient.WriteMultipleRegisters(RegisterTags.sensor1_set, write);
                    

                }
            }
        }

        private void Prob2SetBtn_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                //float value
                int[] write = new int[1];
                if (float.TryParse(Prob2TargetTb.Text, out float value))
                {
                        write[0] = Convert.ToInt32(value * 10.0f);
                        modbusClient.WriteMultipleRegisters(RegisterTags.sensor2_set, write);
                    

                }
            }
        }
        private void Fan1StartBt_Click(object sender, EventArgs e)
        {
            Fan1StartBt.BackColor = Color.Green;
            Fan1StopBt.BackColor = Color.Gainsboro;
            Fan1SaveBt.Enabled = false;
        }
        private void Fan1StopBt_Click(object sender, EventArgs e)
        {
            Fan1StartBt.BackColor = Color.Gainsboro;
            Fan1StopBt.BackColor = Color.Red;
            fan1Time.Stop();
            Fan1SaveBt.Enabled = true;
        }
        private void Fan1ClearBt_Click(object sender, EventArgs e)
        {
            Fan1StartBt.BackColor = Color.Gainsboro;
            Fan1StopBt.BackColor = Color.Red;
            Fan1SaveBt.Enabled = true;
            Fan1Chart.Series[0].Points.Clear();
            Fan1Chart.Series[1].Points.Clear();
            fan1Time.Stop();
            fan1Time.Restart();
            Prob1Speedlist.Clear();
            Fan1Speedlist.Clear();
            fan1Timelist.Clear();
        }
        private void Fan1SaveBt_Click(object sender, EventArgs e)
        {
        Path:
            string FileName = Interaction.InputBox("Saving", "Enter file name", "Path");
            if (FileName != "")
            {
            
                try
                {
                    string pathString = AppDomain.CurrentDomain.BaseDirectory + "\\" + FileName;
                    Directory.CreateDirectory(pathString);
                    Fan1Chart.Series[0].Enabled = true;
                    Fan1Chart.Series[1].Enabled = true;
                    Fan1Chart.SaveImage(pathString + @"\" + FileName+" "+ Fan1Chart.Series[0].Name.ToString()+ "and " + Fan1Chart.Series[1].Name.ToString() + ".png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    Fan1Chart.Series[0].Enabled = true;
                    Fan1Chart.Series[1].Enabled = false;
                    Fan1Chart.ChartAreas[0].RecalculateAxesScale();
                    Fan1Chart.SaveImage(pathString + @"\" + FileName + " " + Fan1Chart.Series[0].Name.ToString()  + ".png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    Fan1Chart.Series[0].Enabled = false;
                    Fan1Chart.Series[1].Enabled = true;
                    Fan1Chart.ChartAreas[0].RecalculateAxesScale();
                    Fan1Chart.SaveImage(pathString + @"\" + FileName + " " + Fan1Chart.Series[1].Name.ToString() + ".png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                    List<string>  texts=new List<string>();
                    texts.Add("time(s),"+ Fan1Chart.Series[0].Name.ToString() + "," + Fan1Chart.Series[1].Name.ToString()  + Environment.NewLine);
                    for (int i = 0; i < fan1Timelist.Count; i++)
                    {
                        texts.Add( fan1Timelist[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + Prob1Speedlist[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + Fan1Speedlist[i].ToString(System.Globalization.CultureInfo.InvariantCulture)  + Environment.NewLine);

                    }
                    using (StreamWriter tw = new StreamWriter(pathString + @"\" + FileName + ".csv", true, Encoding.UTF8, 65536))
                    {
                        foreach (var text in texts)
                            tw.Write(text);
                        
                    }
                    texts.Clear();

                    Fan1Chart.Series["Prob Speed"].Enabled = Prob1SpeedCb.Checked;
                    Fan1Chart.Series["Fan Speed"].Enabled = Fan1SpeedCb.Checked;
                    Fan1Chart.ChartAreas[0].RecalculateAxesScale();
                }
                catch { MessageBox.Show("Enter valid path", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto Path; }
            }
        }

        private void Prob1SpeedCb_CheckedChanged(object sender, EventArgs e)
        {
              Fan1Chart.Series["Prob Speed"].Enabled = Prob1SpeedCb.Checked;
            Fan1Chart.ChartAreas[0].RecalculateAxesScale();
        }

        private void Fan1SpeedCb_CheckedChanged(object sender, EventArgs e)
        {
            Fan1Chart.Series["Fan Speed"].Enabled = Fan1SpeedCb.Checked;
            Fan1Chart.ChartAreas[0].RecalculateAxesScale();
        }

        private void Fan2SpeedCb_CheckedChanged(object sender, EventArgs e)
        {
            Fan2Chart.Series["Fan Speed"].Enabled = Fan2SpeedCb.Checked;
            Fan2Chart.ChartAreas[0].RecalculateAxesScale();
        }

        private void Prob2SpeedCb_CheckedChanged(object sender, EventArgs e)
        {
            Fan2Chart.Series["Prob Speed"].Enabled = Prob2SpeedCb.Checked;
            Fan2Chart.ChartAreas[0].RecalculateAxesScale();
        }


    }
}
