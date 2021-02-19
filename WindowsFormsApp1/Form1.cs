using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
  
        public void drawning()
        {
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Gold);
            float centerX = 200;
            float radius = 20;
            float centerY = 200;
            g.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius);

        }
        public void drawningPluto()
        {
            Timer timer = new Timer();
            timer.Interval = 5; // каждые n миллисекунд
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.White);
            float centerX = 200;
            float radius = 2;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);              
                centerX2 = centerX2 + 185 * Math.Cos((Math.PI * i* 0.002) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 185 * Math.Sin((Math.PI * i * 0.002) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;
               
            });
            timer.Start();
        }

        public void drawningNeptune()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.LightBlue);
            float centerX = 200;
            float radius = 7;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 165 * Math.Cos((Math.PI * i * 0.003) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 165 * Math.Sin((Math.PI * i * 0.003) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningJupiter()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Orange);
            float centerX = 200;
            float radius = 12;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 90 * Math.Cos((Math.PI * i * 0.042) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 90 * Math.Sin((Math.PI * i * 0.042) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningUranus()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.DarkBlue);
            float centerX = 200;
            float radius = 6;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 145 * Math.Cos((Math.PI * i * 0.006) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 145 * Math.Sin((Math.PI * i * 0.006) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningMars()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.DarkRed);
            float centerX = 200;
            float radius = 4;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 65 * Math.Cos((Math.PI * i * 0.265) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 65 * Math.Sin((Math.PI * i * 0.265) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningEarth()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            float centerX = 200;
            float radius = 4;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 50 * Math.Cos((Math.PI * i * 0.5) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 50 * Math.Sin((Math.PI * i * 0.5) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningVenus()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.WhiteSmoke);
            float centerX = 200;
            float radius = 3;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 35 * Math.Cos((Math.PI * i * 0.81) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 35 * Math.Sin((Math.PI * i * 0.81) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningMercury()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Gray);
            float centerX = 200;
            float radius = 2;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 25 * Math.Cos((Math.PI * i * 2.07) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 25 * Math.Sin((Math.PI * i * 2.07) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        public void drawningSaturn()
        {
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Beige);
            float centerX = 200;
            float radius = 10;
            float centerY = 200;
            double i = 1;
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + 120 * Math.Cos((Math.PI * i * 0.016) / 180);
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - 120 * Math.Sin((Math.PI * i * 0.016) / 180);
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();
        }
        private void button_Click(object sender, EventArgs e)
        {
            drawning();
            drawningPluto();
            drawningUranus();
            drawningSaturn();
            drawningJupiter();
            drawningMars();
            drawningEarth();
            drawningVenus();
            drawningMercury();
            drawningNeptune();
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Timer timer = new Timer();
            timer.Interval = 5;
            Graphics g = pictureBox.CreateGraphics();
            Pen pen = new Pen(Brushes.Gold);
            string RadiusOrbit = textBox2.Text;          
            float centerX = 200;           
            string RadiusPlanet = textBox1.Text;             
            float radius = Convert.ToSingle(RadiusPlanet)/3000;
            float centerY = 200;
            double RadiusOrbit2 = Convert.ToDouble(RadiusOrbit)*20;
            float radius2 = 20;
            g.DrawEllipse(pen, centerX - radius2, centerY - radius2, radius2 + radius2, radius2 + radius2);
            pen.Color = colorDialog1.Color;          
            double i = 1;
            double R = Convert.ToDouble(RadiusOrbit);
            timer.Tick += new EventHandler((o, ev) =>
            {
                double centerX2 = Convert.ToDouble(centerX);
                double centerY2 = Convert.ToDouble(centerY);
                centerX2 = centerX2 + RadiusOrbit2* 7/3 * Math.Cos((Math.PI * i * Math.Pow(R, -4)/350));
                int centerX3 = Convert.ToInt32(centerX2);
                centerY2 = centerY2 - RadiusOrbit2* 7/3 * Math.Sin((Math.PI * i * Math.Pow(R, -4) / 350));
                int centerY3 = Convert.ToInt32(centerY2);
                g.DrawEllipse(pen, centerX3 - radius, centerY3 - radius, radius + radius, radius + radius);
                i++;

            });
            timer.Start();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
