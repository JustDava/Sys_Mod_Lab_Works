using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_1
{
    public partial class Form1 : Form
    {
        static PictureBox pbProduction;
        static PictureBox pbStairs;
        static PictureBox pbWood;
        static PictureBox pbRope;
        static Label lblStairsCount;
        static Label lblWoodCount;
        static Label lblRopeCount;
        static FsProgressBar progBarStairs;
        CancellationTokenSource source;
        int sectionsValue;
        int timeValue;

        //static MaskedTextBox mtbSectionsValue;
        //static MaskedTextBox mtbTimeValue;

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(1200, 570);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbProduction = new PictureBox();
            pbProduction.Size = new Size(200, 200);
            pbProduction.Location = new Point(600, 185);
            pbProduction.Image = Properties.Resources.Production;
            pbProduction.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduction.Enabled = false;

            pbStairs = new PictureBox();
            pbStairs.Size = new Size(100, 200);
            pbStairs.Location = new Point(1000, 185);
            pbStairs.Image = Properties.Resources.Rope_Stairs;
            pbStairs.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox pbPointer = new PictureBox();
            pbPointer.Size = new Size(150, 100);
            pbPointer.Location = new Point(825, 250);
            pbPointer.Image = Properties.Resources.Pointer;
            pbPointer.SizeMode = PictureBoxSizeMode.StretchImage;

            lblStairsCount = new Label();
            lblStairsCount.Size = new Size(40, 25);
            lblStairsCount.Location = new Point(1030, 160);
            lblStairsCount.Font = new Font(lblStairsCount.Font.Name, 12, lblStairsCount.Font.Style);
            lblStairsCount.TextAlign = ContentAlignment.MiddleCenter;
            lblStairsCount.Text = "0";

            lblWoodCount = new Label();
            lblWoodCount.Size = new Size(200, 25);
            lblWoodCount.Location = new Point(600, 160);
            lblWoodCount.Font = new Font(lblStairsCount.Font.Name, 12, lblStairsCount.Font.Style);
            lblWoodCount.TextAlign = ContentAlignment.MiddleCenter;
            lblWoodCount.Text = "0";

            lblRopeCount = new Label();
            lblRopeCount.Size = new Size(200, 25);
            lblRopeCount.Location = new Point(600, 385);
            lblRopeCount.Font = new Font(lblStairsCount.Font.Name, 12, lblStairsCount.Font.Style);
            lblRopeCount.TextAlign = ContentAlignment.MiddleCenter;
            lblRopeCount.Text = "0";

            pbWood = new PictureBox();
            pbWood.Size = new Size(50, 50);
            pbWood.Location = new Point(425, 0);
            pbWood.Image = Properties.Resources.Wood;
            pbWood.SizeMode = PictureBoxSizeMode.StretchImage;

            pbRope = new PictureBox();
            pbRope.Size = new Size(50, 50);
            pbRope.Location = new Point(425, 520);
            pbRope.Image = Properties.Resources.Rope;
            pbRope.SizeMode = PictureBoxSizeMode.StretchImage;

            progBarStairs = new FsProgressBar();
            progBarStairs.Size = new Size(100, 25);
            progBarStairs.Location = new Point(1000, 385);
            progBarStairs.Style = ProgressBarStyle.Blocks;

            groupBox1.Location = new Point(99, 182);
            buttonTerminate.Location = new Point(103, 360);

            //mtbSectionsValue = new MaskedTextBox();
            //mtbSectionsValue.Size = new Size(150, 26);
            //mtbSectionsValue.Location = new Point(125, 229);
            //mtbSectionsValue.Mask = "000";
            //mtbSectionsValue.Font = new Font(mtbSectionsValue.Font.Name, 12, mtbSectionsValue.Font.Style);
            //mtbSectionsValue.TextAlign = HorizontalAlignment.Center;

            //mtbTimeValue = new MaskedTextBox();
            //mtbTimeValue.Size = new Size(150, 26);
            //mtbTimeValue.Location = new Point(125, 275);
            //mtbTimeValue.Mask = "000";
            //mtbTimeValue.Font = new Font(mtbTimeValue.Font.Name, 12, mtbTimeValue.Font.Style);
            //mtbTimeValue.TextAlign = HorizontalAlignment.Center;

            this.Controls.Add(pbProduction);
            this.Controls.Add(pbStairs);
            this.Controls.Add(pbPointer);
            this.Controls.Add(lblStairsCount);
            this.Controls.Add(pbWood);
            this.Controls.Add(pbRope);
            this.Controls.Add(lblWoodCount);
            this.Controls.Add(lblRopeCount);
            this.Controls.Add(progBarStairs);
            //this.Controls.Add(mtbSectionsValue);
            //this.Controls.Add(mtbTimeValue);

            lblWoodCount.TextChanged += label_textChanged;
            lblRopeCount.TextChanged += label_textChanged;
            pbProduction.EnabledChanged += pbProduction_EnabledChanged;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Pen mainPen = new Pen(Color.Black);
            Point[] pointsUp = new Point[]
            {
                new Point(500, 0),
                new Point(500, 185),
                new Point(600, 185),
                //new Point(700, 200),
                //new Point(1000, 200),
            };
            Point[] pointsDown = new Point[]
            {
                new Point(500, 570),
                new Point(500, 385),
                new Point(600, 385),
                //new Point(700, 370),
                //new Point(1000, 370),
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

        private async void mvmntWood(PictureBox pbWood)
        {
            Point startPos = pbWood.Location;
            int y_dist = 0;
            int x_dist = pbWood.Location.X;
            try
            {
                await Task.Delay(1000, source.Token);
                if (Convert.ToInt32(lblWoodCount.Text) < sectionsValue)
                {
                    while (pbWood.Location.Y != 210)
                    {
                        y_dist++;
                        pbWood.Location = new Point(pbWood.Location.X, y_dist);
                    };
                    while (pbWood.Location.X != 550)
                    {
                        x_dist++;
                        pbWood.Location = new Point(x_dist, pbWood.Location.Y);
                    };
                    if (pbWood.Location.X >= 550 && pbWood.Location.Y >= 210)
                    {
                        lblWoodCount.Text = (Convert.ToInt32(lblWoodCount.Text) + 5).ToString();
                        pbWood.Location = startPos;

                        this.mvmntWood(pbWood);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
            

        }

        private async void mvmntRope(PictureBox pbRope)
        {
            Point startPos = pbRope.Location;
            int y_dist = 520;
            int x_dist = pbRope.Location.X;
            try
            {
                await Task.Delay(4000, source.Token);
                if (Convert.ToInt32(lblRopeCount.Text) < sectionsValue)
                {
                    while (pbRope.Location.Y != 310)
                    {
                        y_dist--;
                        pbRope.Location = new Point(pbRope.Location.X, y_dist);
                    };
                    while (pbRope.Location.X != 550)
                    {
                        x_dist++;
                        pbRope.Location = new Point(x_dist, pbRope.Location.Y);
                    }
                    if (pbRope.Location.X >= 550 && pbRope.Location.Y >= 310)
                    {
                        lblRopeCount.Text = (Convert.ToInt32(lblRopeCount.Text) + 20).ToString();
                        pbRope.Location = startPos;
                        this.mvmntRope(pbRope);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }            
        }

        private void label_textChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblWoodCount.Text) >= sectionsValue && Convert.ToInt32(lblRopeCount.Text) >= sectionsValue)
            {
                pbProduction.Enabled = true;
            }
        }

        async private void pbProduction_EnabledChanged(object sender, EventArgs e)
        {
            try
            {
                if (pbProduction.Enabled == true)
                {
                    for (int i = 0; i < timeValue; i++)
                    {
                        await Task.Delay(1000, source.Token);
                        progBarStairs.Value++;
                    }
                    lblStairsCount.Text = (Convert.ToInt32(lblStairsCount.Text) + 1).ToString();
                    pbProduction.Enabled = false;
                    progBarStairs.Value = 0;
                    lblWoodCount.Text = (Convert.ToInt32(lblWoodCount.Text) - sectionsValue).ToString();
                    lblRopeCount.Text = (Convert.ToInt32(lblRopeCount.Text) - sectionsValue).ToString();
                    mvmntWood(pbWood);
                    mvmntRope(pbRope);
                }
            }
            catch (Exception)
            {
                return;                
            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            source = new CancellationTokenSource();
            sectionsValue = Convert.ToInt32(mtbSectionsValue.Text);
            timeValue = Convert.ToInt32(mtbTimeValue.Text);
            progBarStairs.Maximum = timeValue;
            mvmntWood(pbWood);
            mvmntRope(pbRope);
            groupBox1.Enabled = false;
            buttonTerminate.Enabled = true;
            
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
            source.Cancel();
            groupBox1.Enabled = true;
            buttonTerminate.Enabled = false;
            lblRopeCount.Text = "0";
            lblWoodCount.Text = "0";
            lblStairsCount.Text = "0";
            progBarStairs.Value = 0;
            pbProduction.Enabled = false;
        }
    }
}
