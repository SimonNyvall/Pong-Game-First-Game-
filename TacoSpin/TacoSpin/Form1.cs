using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TacoSpin
{
    public partial class TacoSpin : Form
    {
        Image img;
        int angle = 0;
        int spins = -1;

        string ImageOne;
        string ImageTwo;
        string ImageThree;

        int SpinSpeed = 0;

        int newWidth;
        int newHeight;

        enum tacos
        {
            ImageNum1, ImageNum2, ImageNum3
        }
        string TypeTaco;
        public TacoSpin()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 40; i++)
            {
                if (360 % i == 0)
                {
                    comboBox1.Items.Add(i);
                }
            }
            comboBox1.Text = "1";
        }

        private void Start_Spin_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;

            newWidth = 0;
            newHeight = 0;
            try
            {
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                if (angle <= 90)
                {
                    newWidth = (int)(bmp.Width * Math.Cos(2 * Math.PI * angle / 360) + bmp.Height * Math.Sin(2 * Math.PI * angle / 360));
                    newHeight = (int)(bmp.Height * Math.Cos(2 * Math.PI * angle / 360) + bmp.Width * Math.Sin(2 * Math.PI * angle / 360));
                }
                else if (angle >= 90 && angle <= 180)
                {
                    newWidth = (int)(bmp.Width * -Math.Cos(2 * Math.PI * angle / 360) + bmp.Height * Math.Sin(2 * Math.PI * angle / 360));
                    newHeight = (int)(bmp.Height * -Math.Cos(2 * Math.PI * angle / 360) + bmp.Width * Math.Sin(2 * Math.PI * angle / 360));
                }
                else if (angle >= 180 && angle <= 270)
                {
                    newWidth = (int)(bmp.Width * -Math.Cos(2 * Math.PI * angle / 360) + bmp.Height * -Math.Sin(2 * Math.PI * angle / 360));
                    newHeight = (int)(bmp.Height * -Math.Cos(2 * Math.PI * angle / 360) + bmp.Width * -Math.Sin(2 * Math.PI * angle / 360));
                }
                else if (angle >= 270 && angle <= 360)
                {
                    newWidth = (int)(bmp.Width * Math.Cos(2 * Math.PI * angle / 360) + bmp.Height * -Math.Sin(2 * Math.PI * angle / 360));
                    newHeight = (int)(bmp.Height * Math.Cos(2 * Math.PI * angle / 360) + bmp.Width * -Math.Sin(2 * Math.PI * angle / 360));
                }

                Rotation.Text = angle.ToString() + " %%" + newWidth.ToString() + " %%" + newHeight.ToString();

                Bitmap bit_map = new Bitmap(newWidth, newHeight);
                Graphics gfx = Graphics.FromImage(bit_map);
                gfx.TranslateTransform(newWidth / 2, newHeight / 2);
                gfx.RotateTransform(angle);
                gfx.TranslateTransform(-img.Width / 2, -img.Height / 2);
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

                gfx.DrawImage(img, 0, 0);
                e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
                e.Graphics.DrawImage(bit_map, -bit_map.Width / 2, -bit_map.Height / 2);
            }
            catch (Exception) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TypeTaco == Convert.ToString(tacos.ImageNum1))
            {
                img = Image.FromFile(ImageOne);
            }
            else if (TypeTaco == Convert.ToString(tacos.ImageNum2))
            {
                img = Image.FromFile(ImageTwo);
            }
            else if (TypeTaco == Convert.ToString(tacos.ImageNum3))
            {
                img = Image.FromFile(ImageThree);
            }

            if (SpinSpeed == 0)
            {
                SpinSpeed = 1;
            }
            else
            {
                angle += SpinSpeed;
            }
            if (newHeight == 0 && newWidth == 0)
            {
                angle = 0;
                spins++;
            }
            Taco_Spins.Text = "Spins: " + spins;

            Invalidate();
        }

        private void Spin_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Taco1_Click(object sender, EventArgs e)
        {
            TypeTaco = Convert.ToString(tacos.ImageNum1);
        }

        private void Taco2_Click(object sender, EventArgs e)
        {
            TypeTaco = Convert.ToString(tacos.ImageNum2);
        }

        private void Taco3_Click(object sender, EventArgs e)
        {
            TypeTaco = Convert.ToString(tacos.ImageNum3);
        }

        private void NumberOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    ImageOne = System.IO.Path.GetFullPath(fileName);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("File Not Found");
                }
            }
        }

        private void NumberTwo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    ImageTwo = System.IO.Path.GetFullPath(fileName);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("File Not Found");
                }
            }
        }

        private void NumberThree_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    ImageThree = System.IO.Path.GetFullPath(fileName);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("File Not Found");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpinSpeed = Convert.ToInt32(comboBox1.Text);
        }
    }
}
