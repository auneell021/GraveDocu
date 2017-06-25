using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graveyard
{
    public partial class Form1 : Form
    {
        Point[] curvePoints = new Point[10];
        List<Point> pointLst = new List<Point>();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create pens.
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points that define curve.
            Point point1 = new Point(100, 200);
            Point point2 = new Point(700, 200);
            Point point3 = new Point(400, 300);
            //Point point4 = new Point(800, 200);
            ////Point point5 = new Point(300, 100);
            ////Point point6 = new Point(350, 200);
            ////Point point7 = new Point(250, 250);
            Point[] curvePoints = { point1, point2, point3};

            // Draw lines between original points to screen.
            //e.Graphics.DrawLines(redPen, curvePoints);
            e.Graphics.DrawCurve(greenPen, curvePoints);
            //if (curvePoints != null && counter > 1)
            //{ 
                
            //    // Draw curve to screen.
            //    var arr = pointLst.ToArray();

            //e.Graphics.DrawCurve(greenPen, curvePoints);
            //}
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            curvePoints[counter] = e.Location;
            counter++;
            pointLst.Add(e.Location);
            Refresh();

            Label lbl = new Label();
            lbl.Location = new Point(e.X, e.Y);
            lbl.Name = "lbl"+counter.ToString();
            lbl.ForeColor = Color.Red;
            lbl.Size = new Size(10, 10);
            lbl.Text = "*";
            this.Controls.Add(lbl);
        }
    }
}
