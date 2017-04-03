using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 1);
            Pen pen1 = new Pen(Color.Yellow, 5);
            Pen pen2 = new Pen(Color.Green, 1);
            e.Graphics.FillEllipse(pen1.Brush,new RectangleF(1200,800,25,25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(60, 200, 25, 25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(790, 160, 25, 25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(700, 230, 25, 25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(210, 400, 25, 25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(300, 150, 25, 25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(500, 280, 25, 25));
            e.Graphics.FillEllipse(pen.Brush, new RectangleF(100,50,25,25));

          


            e.Graphics.FillEllipse(pen2.Brush, new RectangleF(420, 140, 30, 8));//bullet
            e.Graphics.FillEllipse(pen2.Brush, new RectangleF(430, 130, 8, 30));//bullet
            //ship
            Point[] points = { new Point(360, 200), new Point(420, 180), new Point(420, 280),new Point(360, 260) };
            e.Graphics.FillPolygon(new SolidBrush (Color.Yellow), points);
           Point[] points2 = { new Point(420, 280), new Point(420, 180), new Point(480, 200), new Point(480, 260) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Yellow), points2);
            //gun
            e.Graphics.FillRectangle(pen2.Brush, new RectangleF(410, 220, 20, 35));
            
            Point[] points3 = { new Point(400, 220), new Point(420, 200), new Point(440, 220) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Green), points3);
            
            //asteroid

            Point[] points4 = { new Point(150, 150), new Point(170, 180), new Point(130, 180) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points4);
            Point[] points5 = { new Point(150, 190), new Point(170, 160), new Point(130, 160) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points5);

            Point[] points6 = { new Point(220, 270), new Point(240, 300), new Point(200, 300) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points6);
            Point[] points7 = { new Point(220, 310), new Point(240, 280), new Point(200, 280) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points7);

            Point[] points8 = { new Point(650, 350), new Point(670, 380), new Point(630, 380) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points8);
            Point[] points9 = { new Point(650, 390), new Point(670, 360), new Point(630, 360) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points9);


            Point[] points10 = { new Point(400, 50), new Point(420, 80), new Point(380, 80) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points10);
            Point[] points11 = { new Point(400, 90), new Point(420, 60), new Point(380, 60) };
            e.Graphics.FillPolygon(new SolidBrush(Color.Red), points11);


        }
       

        

    }

        
    }

