using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_1
{
    public partial class Form1 : Form
    {
        public delegate void Delegate_moving(PictureBox pictureBox);
        public delegate void Delegate_production();

        static TabControl tabControl;
        static PictureBox pbProduction;
        static PictureBox pbStairs;
        static PictureBox pbWood;
        static PictureBox pbRope;
        static Label lblStairsCount;
        static Label lblWoodCount;
        static Label lblRopeCount;
        static Label lblAveragePerf;
        static Label lblDowntime;
        static Label lblWoodQueue;
        static Label lblRopeQueue;
        static FsProgressBar progBarStairs;
        static FsProgressBar progBarWorkingTime;
        CancellationTokenSource source;
        int sectionsValue;
        int timeValue;
        int woodValue;
        int woodtimeValue;
        int ropeValue;
        int ropetimeValue;
        int woodQueue;
        int ropeQueue;
        int time;
        int timer_for_mvmnt;
        int t1;
        int t2;
        int averagePerf;
        int seconds_of_downtime;
        int experimentsNumber = 0;
        double stairsCount;
        double counter;
        double efficiency;
        string status;
        bool terminateflag;
        bool isCrafting;
        DataGridView dataGridView;

        List<double> C;
        List<double> q;
        int broken_details;

        List<Control> controls_tabPage1;
        List<Control> controls_tabPage2;

        Random random;

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(1200, 570);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new List<double>(4) { 0.1225, 0.3065, 0.0096, 0.0454 };
            q = new List<double>();
            random = new Random();
            controls_tabPage1 = new List<Control>();
            controls_tabPage2 = new List<Control>();

            tabControl = new TabControl();
            tabControl.TabPages.Add("Модель");
            tabControl.TabPages.Add("Данные");
            tabControl.Size = new Size(1200, 570);
            this.Controls.Add(tabControl);

            pbProduction = new PictureBox();
            pbProduction.Size = new Size(200, 200);
            pbProduction.Location = new Point(600, 185);
            pbProduction.Image = Properties.Resources.Production;
            pbProduction.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduction.Enabled = false;
            controls_tabPage1.Add(pbProduction);

            pbStairs = new PictureBox();
            pbStairs.Size = new Size(100, 200);
            pbStairs.Location = new Point(1000, 185);
            pbStairs.Image = Properties.Resources.Rope_Stairs;
            pbStairs.SizeMode = PictureBoxSizeMode.StretchImage;
            controls_tabPage1.Add(pbStairs);

            PictureBox pbPointer = new PictureBox();
            pbPointer.Size = new Size(150, 100);
            pbPointer.Location = new Point(825, 250);
            pbPointer.Image = Properties.Resources.Pointer;
            pbPointer.SizeMode = PictureBoxSizeMode.StretchImage;
            controls_tabPage1.Add(pbPointer);

            lblStairsCount = new Label();
            lblStairsCount.Size = new Size(40, 25);
            lblStairsCount.Location = new Point(1030, 160);
            lblStairsCount.Font = new Font(lblStairsCount.Font.Name, 12, lblStairsCount.Font.Style);
            lblStairsCount.TextAlign = ContentAlignment.MiddleCenter;
            lblStairsCount.Text = "0";
            controls_tabPage1.Add(lblStairsCount);

            lblWoodCount = new Label();
            lblWoodCount.Size = new Size(200, 25);
            lblWoodCount.Location = new Point(600, 160);
            lblWoodCount.Font = new Font(lblStairsCount.Font.Name, 12, lblStairsCount.Font.Style);
            lblWoodCount.TextAlign = ContentAlignment.MiddleCenter;
            lblWoodCount.Text = "0";
            controls_tabPage1.Add(lblWoodCount);

            lblRopeCount = new Label();
            lblRopeCount.Size = new Size(200, 25);
            lblRopeCount.Location = new Point(600, 385);
            lblRopeCount.Font = new Font(lblStairsCount.Font.Name, 12, lblStairsCount.Font.Style);
            lblRopeCount.TextAlign = ContentAlignment.MiddleCenter;
            lblRopeCount.Text = "0";
            controls_tabPage1.Add(lblRopeCount);

            pbWood = new PictureBox();
            pbWood.Size = new Size(50, 50);
            pbWood.Location = new Point(425, 0);
            pbWood.Image = Properties.Resources.Wood;
            pbWood.SizeMode = PictureBoxSizeMode.StretchImage;
            controls_tabPage1.Add(pbWood);

            pbRope = new PictureBox();
            pbRope.Size = new Size(50, 50);
            pbRope.Location = new Point(425, 495);
            pbRope.Image = Properties.Resources.Rope;
            pbRope.SizeMode = PictureBoxSizeMode.StretchImage;
            controls_tabPage1.Add(pbRope);

            progBarStairs = new FsProgressBar();
            progBarStairs.Size = new Size(100, 25);
            progBarStairs.Location = new Point(1000, 385);
            progBarStairs.Style = ProgressBarStyle.Blocks;
            controls_tabPage1.Add(progBarStairs);

            progBarWorkingTime = new FsProgressBar();
            progBarWorkingTime.Size = new Size(buttonTerminate.ClientSize.Width, 25);
            progBarWorkingTime.Location = new Point(buttonTerminate.Location.X, 400);
            progBarWorkingTime.Style = ProgressBarStyle.Blocks;
            controls_tabPage1.Add(progBarWorkingTime);

            lblAveragePerf = new Label();
            lblAveragePerf.Location = new Point(600, 420);
            lblAveragePerf.Font = new Font(lblAveragePerf.Font.Name, 10, lblAveragePerf.Font.Style);
            lblAveragePerf.Text = "Средняя производительность: шт/с";
            lblAveragePerf.AutoSize = true;
            controls_tabPage1.Add(lblAveragePerf);

            lblDowntime = new Label();
            lblDowntime.Location = new Point(900, 420);
            lblDowntime.Font = new Font(lblDowntime.Font.Name, 10, lblDowntime.Font.Style);
            lblDowntime.Text = "Время простоя: с";
            lblDowntime.AutoSize = true;
            controls_tabPage1.Add(lblDowntime);

            lblWoodQueue = new Label();
            lblWoodQueue.Location = new Point(600, 480);
            lblWoodQueue.Font = new Font(lblWoodQueue.Font.Name, 10, lblWoodQueue.Font.Style);
            lblWoodQueue.Text = "Очередь досок: шт";
            lblWoodQueue.AutoSize = true;
            controls_tabPage1.Add(lblWoodQueue);

            lblRopeQueue = new Label();
            lblRopeQueue.Location = new Point(900, 480);
            lblRopeQueue.Font = new Font(lblRopeQueue.Font.Name, 10, lblRopeQueue.Font.Style);
            lblRopeQueue.Text = "Очередь веревок: шт";
            lblRopeQueue.AutoSize = true;
            controls_tabPage1.Add(lblRopeQueue);

            controls_tabPage1.Add(groupBox1);
            controls_tabPage1.Add(buttonTerminate);
            controls_tabPage1.Add(trackBar1);

            tabControl.TabPages[0].Controls.AddRange(controls_tabPage1.ToArray());

            dataGridView = new DataGridView();
            SetupDataGridView();

            tabControl.TabPages[1].Controls.Add(dataGridView);


            tabControl.TabPages[0].Paint += DrawScene;

            //timer1.Tick += Modelling;
        }

        private void SetupDataGridView()
        {
            dataGridView.ColumnCount = 5;

            dataGridView.ClientSize = tabControl.TabPages[1].ClientSize;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].Name = "t (сек)";
            dataGridView.Columns[1].Name = "Кол-во досок в секции №1";
            dataGridView.Columns[2].Name = "Кол-во веревок в секции №2";
            dataGridView.Columns[3].Name = "Состояние сборочного цеха";
            dataGridView.Columns[4].Name = "Количество готовых лестниц";
        }

        private void DrawScene(object sender, PaintEventArgs e)
        {

            Graphics g = tabControl.TabPages[0].CreateGraphics();
            Pen mainPen = new Pen(Color.Black);
            Point[] pointsUp = new Point[]
            {
                new Point(500, 0),
                new Point(500, 185),
                new Point(600, 185),
            };
            Point[] pointsDown = new Point[]
            {
                new Point(500, 570),
                new Point(500, 385),
                new Point(600, 385),
            };
            Point[] pointsCntrLine = new Point[]
            {
                new Point(400, 285),
                new Point(600, 285)
            };
            g.DrawLines(mainPen, pointsUp);
            g.DrawLines(mainPen, pointsDown);
            g.DrawLines(mainPen, pointsCntrLine);
            g.DrawLine(mainPen, new Point(400, 0), new Point(400, 570));
            g.Dispose();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            woodValue = Convert.ToInt32(mtbWoodValue.Text);
            ropeValue = Convert.ToInt32(mtbRopeValue.Text);

            buttonTerminate.Enabled = true;         
            terminateflag = false;

            dataGridView.Rows.Clear();

            progBarWorkingTime.Maximum = 864;
            progBarStairs.Maximum = timeValue*10;

            buttonStart.Enabled = false;
            Modelling();
        }

       

        private void mvmntWood(PictureBox pbWood)
        {
            if (!isCrafting && Convert.ToInt32(lblWoodCount.Text) < sectionsValue)
            {
                lblWoodCount.Text = (Convert.ToInt32(lblWoodCount.Text) + woodValue).ToString();                       
            }
            else
            {
                woodQueue += woodValue;
                lblWoodQueue.Text = $"Очередь досок: {woodQueue}шт";
            }
        }

        private void mvmntRope(PictureBox pbRope)
        {
            if (!isCrafting && Convert.ToInt32(lblRopeCount.Text) < sectionsValue)
            {
                lblRopeCount.Text = (Convert.ToInt32(lblRopeCount.Text) + ropeValue).ToString();             
            }
            else
            {
                ropeQueue += ropeValue;
                lblRopeQueue.Text = $"Очередь веревок: {ropeQueue}шт";
            }
        }

        private void Production()
        {
            if (progBarStairs.Value == progBarStairs.Maximum)
            {
                lblStairsCount.Text = (Convert.ToInt32(lblStairsCount.Text) + 1).ToString();
                progBarStairs.Value = 0;
                lblWoodCount.Text = (Convert.ToInt32(lblWoodCount.Text) - sectionsValue).ToString();
                lblRopeCount.Text = (Convert.ToInt32(lblRopeCount.Text) - sectionsValue).ToString();
                isCrafting = false;
                timer_for_mvmnt = 0;
            }
            else
            {
                isCrafting = true;
                progBarStairs.Value += timeValue;
            }
        }


        private void fill_dgw_n_data()
        {
            if (isCrafting)
            {
                status = "Собирается";
            }
            else
            {
                status = "Простаивает";
            }
            dataGridView.Rows.Add($"{time} сек.", lblWoodCount.Text, lblRopeCount.Text, status, $"{lblStairsCount.Text} шт.");
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            terminateflag = true;
            groupBox1.Enabled = true;
            buttonTerminate.Enabled = false;
            lblWoodCount.Text = "0";
            lblRopeCount.Text = "0";
            lblStairsCount.Text = "0";
            progBarStairs.Value = 0;
            pbProduction.Enabled = false;
            progBarWorkingTime.Value = 0;
            buttonStart.Enabled = true;
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                timer1.Interval = 1000;
            }
            else
            {
                timer1.Interval = 1000 / (trackBar1.Value * 100);
            }
        }

        private int Count_woodtimeValue(int m)
        {
            t1 = Convert.ToInt32(Math.Round(1 * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2 * Math.Log(random.NextDouble())) + m));
            if (t1 == 0)
            {
                Count_woodtimeValue(m);
            }
            return t1;            
        }

        private int Count_ropetimeValue(int L)
        {
            double l = Convert.ToDouble(L) / 100;
            t2 = Convert.ToInt32(Math.Round(-1 / l * Math.Log(random.NextDouble())));
            if (t2 == 0)
            {
                Count_ropetimeValue(L);
            }
            return t2;
        }
        
        private double RandomNormal(double M, double G)
        {
            return G * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2 * Math.Log(random.NextDouble())) + M;
        }

        public void Modelling()
        {
            var rnd = new Random();
            var results = new List<MS1.ResultLine>();


            foreach (var n3 in Enumerable.Range(5, 10))
            {
                foreach (var t3 in Enumerable.Range(5, 10))
                {
                    var result = runModelling(n3, t3);
                    results.Add(result);
                    ++experimentsNumber;
                }
            }


            using (var streamReader = new StreamWriter("Output.csv"))
            {
                using (var csvReader = new CsvWriter(streamReader, new CultureInfo("ru-RU")))
                {
                    csvReader.WriteRecords(results);
                }
            }

            GetPareto(results);

            using (var streamReader = new StreamWriter("OutputParetto.csv"))
            {
                using (var csvReader = new CsvWriter(streamReader, new CultureInfo("ru-RU")))
                {
                    csvReader.WriteRecords(results);
                }
            }

        }

        static void GetPareto(List<MS1.ResultLine> results)
        {
            var jIds = new List<int>();
            var j = results.FirstOrDefault();
            do
            {
                jIds.Add(j.Id);
                var k = results.FirstOrDefault(x => j.Id != x.Id && j.CompareTo(x) == -1);
                if (k != null)
                {
                    results.Remove(j);
                }

                j = results.FirstOrDefault(x => !jIds.Contains(x.Id));
            }
            while (j != null);
        }


        public MS1.ResultLine runModelling(int n3, int t3)
        {
            sectionsValue = n3;

            timeValue = t3;
            isCrafting = false;
            timer_for_mvmnt = 0;
            time = 0;
            woodQueue = 0;
            ropeQueue = 0;

            seconds_of_downtime = 0;

            lblWoodCount.Text = "0";
            lblRopeCount.Text = "0";
            lblStairsCount.Text = "0";

                for (int i = 0; i < 864; i++)
                {
                    time++;
                    woodtimeValue = Count_woodtimeValue(5);
                    ropetimeValue = Count_ropetimeValue(5);
                    if (!isCrafting)
                    {
                        timer_for_mvmnt++;
                    }
                    if (timer_for_mvmnt % woodtimeValue == 0)
                        mvmntWood(pbWood);
                    if (timer_for_mvmnt % ropetimeValue == 0)
                        mvmntRope(pbRope);
                    if (Convert.ToInt32(lblWoodCount.Text) >= sectionsValue && Convert.ToInt32(lblRopeCount.Text) >= sectionsValue)
                        Production();
                    else
                        lblDowntime.Text = $"Время простоя: {seconds_of_downtime++}c";
                    progBarWorkingTime.Value++;
                    averagePerf = Convert.ToInt32(Math.Round(Convert.ToDouble(lblStairsCount.Text) / time * 60, 0));
                    lblAveragePerf.Text = $"Средняя производительность: {averagePerf} шт/м";
                    fill_dgw_n_data();
                }
                buttonTerminate.Enabled = false;
                progBarStairs.Value = 0;
                progBarWorkingTime.Value = 0;

                buttonStart.Enabled = true;

            return new MS1.ResultLine
            {
                Id = experimentsNumber++,
                N3 = n3,
                T3 = t3,
                Seconds_of_downtime = seconds_of_downtime,
                AveragePerf = averagePerf,
                WoodQueue = woodQueue,
                RopeQueue = ropeQueue
            };
        }

    }
}
