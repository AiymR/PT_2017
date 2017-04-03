using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddLine(100, 100, 70, 120);
            path.AddLine(70, 120, 100, 140);
            path.AddLine(100, 140, 130, 120);
            path.AddLine(130, 120, 100, 100);
            path.CloseFigure();
            SolidBrush brush = new SolidBrush(Color.Red);
            e.Graphics.FillPath(brush, path);
        }
    }
}
