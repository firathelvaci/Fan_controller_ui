namespace BapProjesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectionLbl = new System.Windows.Forms.Label();
            this.DeltaTime = new System.Windows.Forms.Timer(this.components);
            this.Fan1StartBtn = new System.Windows.Forms.Button();
            this.Fan1StopBtn = new System.Windows.Forms.Button();
            this.Fan1ManualBtn = new System.Windows.Forms.Button();
            this.Fan1AutoBtn = new System.Windows.Forms.Button();
            this.Fan2SpeedLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fan1SpeedLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Prop2SpeedLbl = new System.Windows.Forms.Label();
            this.Prop1TargetLbl = new System.Windows.Forms.Label();
            this.Temp1SetBtn = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.Fan2SpeedTb = new System.Windows.Forms.TextBox();
            this.Fan2SetBtn = new System.Windows.Forms.Button();
            this.Prop2TargetLbl = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Prop1SpeedLbl = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.ConfigBtn = new System.Windows.Forms.Button();
            this.Fan1SetBtn = new System.Windows.Forms.Button();
            this.Fan1SpeedTb = new System.Windows.Forms.TextBox();
            this.Prob1TargetTb = new System.Windows.Forms.TextBox();
            this.Prob1SetBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Prob2TargetTb = new System.Windows.Forms.TextBox();
            this.Prob2SetBtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Fan2AutoBtn = new System.Windows.Forms.Button();
            this.Fan2ManualBtn = new System.Windows.Forms.Button();
            this.Fan2StopBtn = new System.Windows.Forms.Button();
            this.Fan2StartBtn = new System.Windows.Forms.Button();
            this.Fan1Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Fan1StartBt = new System.Windows.Forms.Button();
            this.Fan1StopBt = new System.Windows.Forms.Button();
            this.Fan1ClearBt = new System.Windows.Forms.Button();
            this.Fan1SaveBt = new System.Windows.Forms.Button();
            this.Fan2SaveBt = new System.Windows.Forms.Button();
            this.Fan2ClearBt = new System.Windows.Forms.Button();
            this.Fan2StopBt = new System.Windows.Forms.Button();
            this.Fan2StartBt = new System.Windows.Forms.Button();
            this.Fan1SpeedCb = new System.Windows.Forms.CheckBox();
            this.Prob1SpeedCb = new System.Windows.Forms.CheckBox();
            this.Prob2SpeedCb = new System.Windows.Forms.CheckBox();
            this.Fan2SpeedCb = new System.Windows.Forms.CheckBox();
            this.Fan2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Fan1Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fan2Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(30, 266);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(101, 48);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(30, 320);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(101, 48);
            this.DisconnectBtn.TabIndex = 1;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectionLbl
            // 
            this.ConnectionLbl.AutoSize = true;
            this.ConnectionLbl.BackColor = System.Drawing.Color.White;
            this.ConnectionLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectionLbl.Location = new System.Drawing.Point(44, 250);
            this.ConnectionLbl.Name = "ConnectionLbl";
            this.ConnectionLbl.Size = new System.Drawing.Size(73, 13);
            this.ConnectionLbl.TabIndex = 2;
            this.ConnectionLbl.Text = "Disconnected";
            // 
            // DeltaTime
            // 
            this.DeltaTime.Tick += new System.EventHandler(this.DeltaTime_Tick);
            // 
            // Fan1StartBtn
            // 
            this.Fan1StartBtn.Location = new System.Drawing.Point(12, 29);
            this.Fan1StartBtn.Name = "Fan1StartBtn";
            this.Fan1StartBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan1StartBtn.TabIndex = 4;
            this.Fan1StartBtn.Tag = "deneme";
            this.Fan1StartBtn.Text = "Fan 1 Start";
            this.Fan1StartBtn.UseVisualStyleBackColor = true;
            this.Fan1StartBtn.Click += new System.EventHandler(this.Fan1StartBtn_Click);
            // 
            // Fan1StopBtn
            // 
            this.Fan1StopBtn.Location = new System.Drawing.Point(12, 83);
            this.Fan1StopBtn.Name = "Fan1StopBtn";
            this.Fan1StopBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan1StopBtn.TabIndex = 5;
            this.Fan1StopBtn.Text = "Fan 1 Stop";
            this.Fan1StopBtn.UseVisualStyleBackColor = true;
            this.Fan1StopBtn.Click += new System.EventHandler(this.Fan1StopBtn_Click);
            // 
            // Fan1ManualBtn
            // 
            this.Fan1ManualBtn.Location = new System.Drawing.Point(12, 137);
            this.Fan1ManualBtn.Name = "Fan1ManualBtn";
            this.Fan1ManualBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan1ManualBtn.TabIndex = 6;
            this.Fan1ManualBtn.Text = "Fan 1 Manual";
            this.Fan1ManualBtn.UseVisualStyleBackColor = true;
            this.Fan1ManualBtn.Click += new System.EventHandler(this.Fan1ManualBtn_Click);
            // 
            // Fan1AutoBtn
            // 
            this.Fan1AutoBtn.Location = new System.Drawing.Point(12, 191);
            this.Fan1AutoBtn.Name = "Fan1AutoBtn";
            this.Fan1AutoBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan1AutoBtn.TabIndex = 6;
            this.Fan1AutoBtn.Text = "Fan 1 Auto";
            this.Fan1AutoBtn.UseVisualStyleBackColor = true;
            this.Fan1AutoBtn.Click += new System.EventHandler(this.Fan1AutoBtn_Click);
            // 
            // Fan2SpeedLbl
            // 
            this.Fan2SpeedLbl.AutoSize = true;
            this.Fan2SpeedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Fan2SpeedLbl.Location = new System.Drawing.Point(216, 348);
            this.Fan2SpeedLbl.Name = "Fan2SpeedLbl";
            this.Fan2SpeedLbl.Size = new System.Drawing.Size(30, 24);
            this.Fan2SpeedLbl.TabIndex = 11;
            this.Fan2SpeedLbl.Text = "26";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fan 2 Speed (%) :";
            // 
            // Fan1SpeedLbl
            // 
            this.Fan1SpeedLbl.AutoSize = true;
            this.Fan1SpeedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Fan1SpeedLbl.Location = new System.Drawing.Point(222, 61);
            this.Fan1SpeedLbl.Name = "Fan1SpeedLbl";
            this.Fan1SpeedLbl.Size = new System.Drawing.Size(30, 24);
            this.Fan1SpeedLbl.TabIndex = 23;
            this.Fan1SpeedLbl.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fan 1 Speed (%) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Prop 1 Speed (%) :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Prop 2 Speed (%) : ";
            // 
            // Prop2SpeedLbl
            // 
            this.Prop2SpeedLbl.AutoSize = true;
            this.Prop2SpeedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Prop2SpeedLbl.Location = new System.Drawing.Point(470, 348);
            this.Prop2SpeedLbl.Name = "Prop2SpeedLbl";
            this.Prop2SpeedLbl.Size = new System.Drawing.Size(30, 24);
            this.Prop2SpeedLbl.TabIndex = 28;
            this.Prop2SpeedLbl.Text = "30";
            // 
            // Prop1TargetLbl
            // 
            this.Prop1TargetLbl.AutoSize = true;
            this.Prop1TargetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Prop1TargetLbl.Location = new System.Drawing.Point(347, 61);
            this.Prop1TargetLbl.Name = "Prop1TargetLbl";
            this.Prop1TargetLbl.Size = new System.Drawing.Size(30, 24);
            this.Prop1TargetLbl.TabIndex = 29;
            this.Prop1TargetLbl.Text = "50";
            // 
            // Temp1SetBtn
            // 
            this.Temp1SetBtn.Location = new System.Drawing.Point(188, 124);
            this.Temp1SetBtn.Name = "Temp1SetBtn";
            this.Temp1SetBtn.Size = new System.Drawing.Size(101, 48);
            this.Temp1SetBtn.TabIndex = 64;
            this.Temp1SetBtn.Text = "Fan 1 Speed Set";
            this.Temp1SetBtn.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(200, 99);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(75, 20);
            this.textBox18.TabIndex = 65;
            // 
            // Fan2SpeedTb
            // 
            this.Fan2SpeedTb.Location = new System.Drawing.Point(198, 389);
            this.Fan2SpeedTb.Name = "Fan2SpeedTb";
            this.Fan2SpeedTb.Size = new System.Drawing.Size(75, 20);
            this.Fan2SpeedTb.TabIndex = 67;
            this.Fan2SpeedTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fan2SetBtn
            // 
            this.Fan2SetBtn.Location = new System.Drawing.Point(185, 413);
            this.Fan2SetBtn.Name = "Fan2SetBtn";
            this.Fan2SetBtn.Size = new System.Drawing.Size(101, 48);
            this.Fan2SetBtn.TabIndex = 66;
            this.Fan2SetBtn.Text = "Fan 2 Speed Set";
            this.Fan2SetBtn.UseVisualStyleBackColor = true;
            this.Fan2SetBtn.Click += new System.EventHandler(this.Fan2SetBtn_Click);
            // 
            // Prop2TargetLbl
            // 
            this.Prop2TargetLbl.AutoSize = true;
            this.Prop2TargetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Prop2TargetLbl.Location = new System.Drawing.Point(350, 348);
            this.Prop2TargetLbl.Name = "Prop2TargetLbl";
            this.Prop2TargetLbl.Size = new System.Drawing.Size(30, 24);
            this.Prop2TargetLbl.TabIndex = 70;
            this.Prop2TargetLbl.Text = "40";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(317, 321);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 13);
            this.label28.TabIndex = 69;
            this.label28.Text = "Prop 2 Target (%) : ";
            // 
            // Prop1SpeedLbl
            // 
            this.Prop1SpeedLbl.AutoSize = true;
            this.Prop1SpeedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Prop1SpeedLbl.Location = new System.Drawing.Point(470, 61);
            this.Prop1SpeedLbl.Name = "Prop1SpeedLbl";
            this.Prop1SpeedLbl.Size = new System.Drawing.Size(30, 24);
            this.Prop1SpeedLbl.TabIndex = 72;
            this.Prop1SpeedLbl.Text = "70";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(311, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 13);
            this.label29.TabIndex = 71;
            this.label29.Text = "Prop 1 Target (%) : ";
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.Location = new System.Drawing.Point(30, 374);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(101, 48);
            this.ConfigBtn.TabIndex = 73;
            this.ConfigBtn.Text = "Config";
            this.ConfigBtn.UseVisualStyleBackColor = true;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            // 
            // Fan1SetBtn
            // 
            this.Fan1SetBtn.Location = new System.Drawing.Point(187, 124);
            this.Fan1SetBtn.Name = "Fan1SetBtn";
            this.Fan1SetBtn.Size = new System.Drawing.Size(101, 48);
            this.Fan1SetBtn.TabIndex = 64;
            this.Fan1SetBtn.Text = "Fan 1 Speed Set";
            this.Fan1SetBtn.UseVisualStyleBackColor = true;
            this.Fan1SetBtn.Click += new System.EventHandler(this.Fan1SetBtn_Click);
            // 
            // Fan1SpeedTb
            // 
            this.Fan1SpeedTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fan1SpeedTb.Location = new System.Drawing.Point(200, 99);
            this.Fan1SpeedTb.Name = "Fan1SpeedTb";
            this.Fan1SpeedTb.Size = new System.Drawing.Size(75, 20);
            this.Fan1SpeedTb.TabIndex = 65;
            this.Fan1SpeedTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prob1TargetTb
            // 
            this.Prob1TargetTb.Location = new System.Drawing.Point(324, 99);
            this.Prob1TargetTb.Name = "Prob1TargetTb";
            this.Prob1TargetTb.Size = new System.Drawing.Size(75, 20);
            this.Prob1TargetTb.TabIndex = 76;
            this.Prob1TargetTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prob1SetBtn
            // 
            this.Prob1SetBtn.Location = new System.Drawing.Point(311, 124);
            this.Prob1SetBtn.Name = "Prob1SetBtn";
            this.Prob1SetBtn.Size = new System.Drawing.Size(101, 48);
            this.Prob1SetBtn.TabIndex = 74;
            this.Prob1SetBtn.Text = "Prob 1 Speed Set";
            this.Prob1SetBtn.UseVisualStyleBackColor = true;
            this.Prob1SetBtn.Click += new System.EventHandler(this.Prob1SetBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(324, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 77;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 48);
            this.button3.TabIndex = 75;
            this.button3.Text = "Fan 1 Speed Set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Prob2TargetTb
            // 
            this.Prob2TargetTb.Location = new System.Drawing.Point(327, 389);
            this.Prob2TargetTb.Name = "Prob2TargetTb";
            this.Prob2TargetTb.Size = new System.Drawing.Size(75, 20);
            this.Prob2TargetTb.TabIndex = 80;
            this.Prob2TargetTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prob2SetBtn
            // 
            this.Prob2SetBtn.Location = new System.Drawing.Point(314, 413);
            this.Prob2SetBtn.Name = "Prob2SetBtn";
            this.Prob2SetBtn.Size = new System.Drawing.Size(101, 48);
            this.Prob2SetBtn.TabIndex = 78;
            this.Prob2SetBtn.Text = "Prob 2 Speed Set";
            this.Prob2SetBtn.UseVisualStyleBackColor = true;
            this.Prob2SetBtn.Click += new System.EventHandler(this.Prob2SetBtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 389);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 81;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(314, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 48);
            this.button5.TabIndex = 79;
            this.button5.Text = "Fan 1 Speed Set";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Fan2AutoBtn
            // 
            this.Fan2AutoBtn.Location = new System.Drawing.Point(81, 191);
            this.Fan2AutoBtn.Name = "Fan2AutoBtn";
            this.Fan2AutoBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan2AutoBtn.TabIndex = 84;
            this.Fan2AutoBtn.Text = "Fan 2 Auto";
            this.Fan2AutoBtn.UseVisualStyleBackColor = true;
            this.Fan2AutoBtn.Click += new System.EventHandler(this.Fan2AutoBtn_Click);
            // 
            // Fan2ManualBtn
            // 
            this.Fan2ManualBtn.Location = new System.Drawing.Point(81, 137);
            this.Fan2ManualBtn.Name = "Fan2ManualBtn";
            this.Fan2ManualBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan2ManualBtn.TabIndex = 85;
            this.Fan2ManualBtn.Text = "Fan 2 Manual";
            this.Fan2ManualBtn.UseVisualStyleBackColor = true;
            this.Fan2ManualBtn.Click += new System.EventHandler(this.Fan2ManualBtn_Click);
            // 
            // Fan2StopBtn
            // 
            this.Fan2StopBtn.Location = new System.Drawing.Point(81, 83);
            this.Fan2StopBtn.Name = "Fan2StopBtn";
            this.Fan2StopBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan2StopBtn.TabIndex = 83;
            this.Fan2StopBtn.Text = "Fan 2 Stop";
            this.Fan2StopBtn.UseVisualStyleBackColor = true;
            this.Fan2StopBtn.Click += new System.EventHandler(this.Fan2StopBtn_Click);
            // 
            // Fan2StartBtn
            // 
            this.Fan2StartBtn.Location = new System.Drawing.Point(81, 29);
            this.Fan2StartBtn.Name = "Fan2StartBtn";
            this.Fan2StartBtn.Size = new System.Drawing.Size(63, 48);
            this.Fan2StartBtn.TabIndex = 82;
            this.Fan2StartBtn.Text = "Fan 2 Start";
            this.Fan2StartBtn.UseVisualStyleBackColor = true;
            this.Fan2StartBtn.Click += new System.EventHandler(this.Fan2StartBtn_Click);
            // 
            // Fan1Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Fan1Chart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend3.DockedToChartArea = "ChartArea1";
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.IsDockedInsideChartArea = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend1";
            this.Fan1Chart.Legends.Add(legend3);
            this.Fan1Chart.Location = new System.Drawing.Point(582, 17);
            this.Fan1Chart.Name = "Fan1Chart";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Prob Speed";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Fan Speed";
            this.Fan1Chart.Series.Add(series5);
            this.Fan1Chart.Series.Add(series6);
            this.Fan1Chart.Size = new System.Drawing.Size(554, 282);
            this.Fan1Chart.TabIndex = 86;
            this.Fan1Chart.Text = "Fan1Chart";
            title3.Name = "Title1";
            title3.Text = "Fan 1";
            this.Fan1Chart.Titles.Add(title3);
            // 
            // Fan1StartBt
            // 
            this.Fan1StartBt.Location = new System.Drawing.Point(443, 99);
            this.Fan1StartBt.Name = "Fan1StartBt";
            this.Fan1StartBt.Size = new System.Drawing.Size(40, 40);
            this.Fan1StartBt.TabIndex = 87;
            this.Fan1StartBt.Text = "Start";
            this.Fan1StartBt.UseVisualStyleBackColor = true;
            this.Fan1StartBt.Click += new System.EventHandler(this.Fan1StartBt_Click);
            // 
            // Fan1StopBt
            // 
            this.Fan1StopBt.Location = new System.Drawing.Point(489, 99);
            this.Fan1StopBt.Name = "Fan1StopBt";
            this.Fan1StopBt.Size = new System.Drawing.Size(40, 40);
            this.Fan1StopBt.TabIndex = 88;
            this.Fan1StopBt.Text = "Stop";
            this.Fan1StopBt.UseVisualStyleBackColor = true;
            this.Fan1StopBt.Click += new System.EventHandler(this.Fan1StopBt_Click);
            // 
            // Fan1ClearBt
            // 
            this.Fan1ClearBt.Location = new System.Drawing.Point(443, 145);
            this.Fan1ClearBt.Name = "Fan1ClearBt";
            this.Fan1ClearBt.Size = new System.Drawing.Size(40, 40);
            this.Fan1ClearBt.TabIndex = 89;
            this.Fan1ClearBt.Text = "Clear";
            this.Fan1ClearBt.UseVisualStyleBackColor = true;
            this.Fan1ClearBt.Click += new System.EventHandler(this.Fan1ClearBt_Click);
            // 
            // Fan1SaveBt
            // 
            this.Fan1SaveBt.Location = new System.Drawing.Point(489, 145);
            this.Fan1SaveBt.Name = "Fan1SaveBt";
            this.Fan1SaveBt.Size = new System.Drawing.Size(40, 40);
            this.Fan1SaveBt.TabIndex = 90;
            this.Fan1SaveBt.Text = "Save";
            this.Fan1SaveBt.UseVisualStyleBackColor = true;
            this.Fan1SaveBt.Click += new System.EventHandler(this.Fan1SaveBt_Click);
            // 
            // Fan2SaveBt
            // 
            this.Fan2SaveBt.Location = new System.Drawing.Point(489, 424);
            this.Fan2SaveBt.Name = "Fan2SaveBt";
            this.Fan2SaveBt.Size = new System.Drawing.Size(40, 40);
            this.Fan2SaveBt.TabIndex = 94;
            this.Fan2SaveBt.Text = "Save";
            this.Fan2SaveBt.UseVisualStyleBackColor = true;
            // 
            // Fan2ClearBt
            // 
            this.Fan2ClearBt.Location = new System.Drawing.Point(443, 424);
            this.Fan2ClearBt.Name = "Fan2ClearBt";
            this.Fan2ClearBt.Size = new System.Drawing.Size(40, 40);
            this.Fan2ClearBt.TabIndex = 93;
            this.Fan2ClearBt.Text = "Clear";
            this.Fan2ClearBt.UseVisualStyleBackColor = true;
            // 
            // Fan2StopBt
            // 
            this.Fan2StopBt.Location = new System.Drawing.Point(489, 378);
            this.Fan2StopBt.Name = "Fan2StopBt";
            this.Fan2StopBt.Size = new System.Drawing.Size(40, 40);
            this.Fan2StopBt.TabIndex = 92;
            this.Fan2StopBt.Text = "Stop";
            this.Fan2StopBt.UseVisualStyleBackColor = true;
            // 
            // Fan2StartBt
            // 
            this.Fan2StartBt.Location = new System.Drawing.Point(443, 378);
            this.Fan2StartBt.Name = "Fan2StartBt";
            this.Fan2StartBt.Size = new System.Drawing.Size(40, 40);
            this.Fan2StartBt.TabIndex = 91;
            this.Fan2StartBt.Text = "Start";
            this.Fan2StartBt.UseVisualStyleBackColor = true;
            // 
            // Fan1SpeedCb
            // 
            this.Fan1SpeedCb.AutoSize = true;
            this.Fan1SpeedCb.Checked = true;
            this.Fan1SpeedCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Fan1SpeedCb.Location = new System.Drawing.Point(451, 191);
            this.Fan1SpeedCb.Name = "Fan1SpeedCb";
            this.Fan1SpeedCb.Size = new System.Drawing.Size(78, 17);
            this.Fan1SpeedCb.TabIndex = 96;
            this.Fan1SpeedCb.Text = "Fan Speed";
            this.Fan1SpeedCb.UseVisualStyleBackColor = true;
            this.Fan1SpeedCb.CheckedChanged += new System.EventHandler(this.Fan1SpeedCb_CheckedChanged);
            // 
            // Prob1SpeedCb
            // 
            this.Prob1SpeedCb.AutoSize = true;
            this.Prob1SpeedCb.Checked = true;
            this.Prob1SpeedCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Prob1SpeedCb.Location = new System.Drawing.Point(451, 208);
            this.Prob1SpeedCb.Name = "Prob1SpeedCb";
            this.Prob1SpeedCb.Size = new System.Drawing.Size(82, 17);
            this.Prob1SpeedCb.TabIndex = 97;
            this.Prob1SpeedCb.Text = "Prob Speed";
            this.Prob1SpeedCb.UseVisualStyleBackColor = true;
            this.Prob1SpeedCb.CheckedChanged += new System.EventHandler(this.Prob1SpeedCb_CheckedChanged);
            // 
            // Prob2SpeedCb
            // 
            this.Prob2SpeedCb.AutoSize = true;
            this.Prob2SpeedCb.Checked = true;
            this.Prob2SpeedCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Prob2SpeedCb.Location = new System.Drawing.Point(451, 487);
            this.Prob2SpeedCb.Name = "Prob2SpeedCb";
            this.Prob2SpeedCb.Size = new System.Drawing.Size(82, 17);
            this.Prob2SpeedCb.TabIndex = 100;
            this.Prob2SpeedCb.Text = "Prob Speed";
            this.Prob2SpeedCb.UseVisualStyleBackColor = true;
            this.Prob2SpeedCb.CheckedChanged += new System.EventHandler(this.Prob2SpeedCb_CheckedChanged);
            // 
            // Fan2SpeedCb
            // 
            this.Fan2SpeedCb.AutoSize = true;
            this.Fan2SpeedCb.Checked = true;
            this.Fan2SpeedCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Fan2SpeedCb.Location = new System.Drawing.Point(451, 470);
            this.Fan2SpeedCb.Name = "Fan2SpeedCb";
            this.Fan2SpeedCb.Size = new System.Drawing.Size(78, 17);
            this.Fan2SpeedCb.TabIndex = 99;
            this.Fan2SpeedCb.Text = "Fan Speed";
            this.Fan2SpeedCb.UseVisualStyleBackColor = true;
            this.Fan2SpeedCb.CheckedChanged += new System.EventHandler(this.Fan2SpeedCb_CheckedChanged);
            // 
            // Fan2Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.Fan2Chart.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            legend4.DockedToChartArea = "ChartArea1";
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.IsDockedInsideChartArea = false;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend4.Name = "Legend1";
            this.Fan2Chart.Legends.Add(legend4);
            this.Fan2Chart.Location = new System.Drawing.Point(582, 321);
            this.Fan2Chart.Name = "Fan2Chart";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Prob Speed";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Fan Speed";
            this.Fan2Chart.Series.Add(series7);
            this.Fan2Chart.Series.Add(series8);
            this.Fan2Chart.Size = new System.Drawing.Size(554, 282);
            this.Fan2Chart.TabIndex = 101;
            this.Fan2Chart.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Fan 1";
            this.Fan2Chart.Titles.Add(title4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1153, 614);
            this.Controls.Add(this.Fan2Chart);
            this.Controls.Add(this.Prob2SpeedCb);
            this.Controls.Add(this.Fan2SpeedCb);
            this.Controls.Add(this.Prob1SpeedCb);
            this.Controls.Add(this.Fan1SpeedCb);
            this.Controls.Add(this.Fan2SaveBt);
            this.Controls.Add(this.Fan2ClearBt);
            this.Controls.Add(this.Fan2StopBt);
            this.Controls.Add(this.Fan2StartBt);
            this.Controls.Add(this.Fan1SaveBt);
            this.Controls.Add(this.Fan1ClearBt);
            this.Controls.Add(this.Fan1StopBt);
            this.Controls.Add(this.Fan1StartBt);
            this.Controls.Add(this.Fan1Chart);
            this.Controls.Add(this.Fan2AutoBtn);
            this.Controls.Add(this.Fan2ManualBtn);
            this.Controls.Add(this.Fan2StopBtn);
            this.Controls.Add(this.Fan2StartBtn);
            this.Controls.Add(this.Prob2TargetTb);
            this.Controls.Add(this.Prob2SetBtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Prob1TargetTb);
            this.Controls.Add(this.Prob1SetBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ConfigBtn);
            this.Controls.Add(this.Prop1SpeedLbl);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.Prop2TargetLbl);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Fan2SpeedTb);
            this.Controls.Add(this.Fan2SetBtn);
            this.Controls.Add(this.Fan1SpeedTb);
            this.Controls.Add(this.Fan1SetBtn);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.Temp1SetBtn);
            this.Controls.Add(this.Prop1TargetLbl);
            this.Controls.Add(this.Prop2SpeedLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Fan1SpeedLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Fan2SpeedLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fan1AutoBtn);
            this.Controls.Add(this.Fan1ManualBtn);
            this.Controls.Add(this.Fan1StopBtn);
            this.Controls.Add(this.Fan1StartBtn);
            this.Controls.Add(this.ConnectionLbl);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bap Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fan1Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fan2Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Label ConnectionLbl;
        private System.Windows.Forms.Timer DeltaTime;
        private System.Windows.Forms.Button Fan1StartBtn;
        private System.Windows.Forms.Button Fan1StopBtn;
        private System.Windows.Forms.Button Fan1ManualBtn;
        private System.Windows.Forms.Button Fan1AutoBtn;
        private System.Windows.Forms.Label Fan2SpeedLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fan1SpeedLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Prop2SpeedLbl;
        private System.Windows.Forms.Label Prop1TargetLbl;
        private System.Windows.Forms.Button Temp1SetBtn;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox Fan2SpeedTb;
        private System.Windows.Forms.Button Fan2SetBtn;
        private System.Windows.Forms.Label Prop2TargetLbl;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label Prop1SpeedLbl;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button ConfigBtn;
        private System.Windows.Forms.Button Fan1SetBtn;
        private System.Windows.Forms.TextBox Fan1SpeedTb;
        private System.Windows.Forms.TextBox Prob1TargetTb;
        private System.Windows.Forms.Button Prob1SetBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Prob2TargetTb;
        private System.Windows.Forms.Button Prob2SetBtn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Fan2AutoBtn;
        private System.Windows.Forms.Button Fan2ManualBtn;
        private System.Windows.Forms.Button Fan2StopBtn;
        private System.Windows.Forms.Button Fan2StartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Fan1Chart;
        private System.Windows.Forms.Button Fan1StartBt;
        private System.Windows.Forms.Button Fan1StopBt;
        private System.Windows.Forms.Button Fan1ClearBt;
        private System.Windows.Forms.Button Fan1SaveBt;
        private System.Windows.Forms.Button Fan2ClearBt;
        private System.Windows.Forms.Button Fan2StopBt;
        private System.Windows.Forms.Button Fan2StartBt;
        private System.Windows.Forms.Button Fan2SaveBt;
        private System.Windows.Forms.CheckBox Fan1SpeedCb;
        private System.Windows.Forms.CheckBox Prob1SpeedCb;
        private System.Windows.Forms.CheckBox Prob2SpeedCb;
        private System.Windows.Forms.CheckBox Fan2SpeedCb;
        private System.Windows.Forms.DataVisualization.Charting.Chart Fan2Chart;
    }
}

