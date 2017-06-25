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
    public partial class frmDrawing : Form
    {
        private IList<Point> _pointList = new List<Point>();
        bool isDrawCommand = false;
        Point[] curvePoints = new Point[900];
        int count = 0;
        public frmDrawing()
        {
            InitializeComponent();

            this.MouseClick += FrmDrawing_MouseClick;
            this.KeyPress += FrmDrawing_KeyPress;
        }

        private void FrmDrawing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                _pointList.RemoveAt(_pointList.Count - 1);

                Refresh();
            }
        }

        private void FrmDrawing_MouseClick(object sender, MouseEventArgs e)
        {
            curvePoints[count] = new Point(e.X, e.Y);
            count++;
            _pointList.Add(new Point(e.X, e.Y));
            DrawPoints(e.X, e.Y);
            //Refresh();
        }

        private void frmDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            //if (mouseIsDown)
            //{
            //    curvePoints[count]  = new Point(e.X, e.Y);
            //    count++;
            //    _pointList.Add(new Point(e.X, e.Y));
            //    Refresh();
            //}
        }

        private void frmDrawing_Paint(object sender, PaintEventArgs e)
        {
            if (_pointList.Count > 1 && isDrawCommand)
            {
                Point[] pt = _pointList.ToArray();

                Pen pen = new Pen(Color.Red, 5.0F);

                switch (cmDrawTypes.Text)
                {
                    case "Straight Line":
                        e.Graphics.DrawLines(pen, pt);
                        break;

                    case "Curve":
                        e.Graphics.DrawCurve(pen, pt);
                        break;

                    default:
                        e.Graphics.DrawCurve(pen, pt);
                        break;
                }

                isDrawCommand = false;
            }
        }

        private void frmDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //    mouseIsDown = true;
        }

        private void frmDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            //mouseIsDown = false;
        }

        private void DrawPoints(int x, int y)
        {
            //Label lbl = new Label();
            //lbl.Location = new Point(x, y);
            //lbl.Name = "lbl" + x.ToString() + y.ToString();
            //lbl.ForeColor = Color.Green;
            ////lbl.Width = 100;
            ////lbl.Height = 100;
            //lbl.Size = new Size(5, 5);
            //lbl.Text = "*";
            //lbl.BackColor = Color.Green;
            //this.Controls.Add(lbl);

            RoundButton btn = new RoundButton();
            btn.Location = new Point(x-7, y-7);
            btn.Name = "btn" + x.ToString() + y.ToString();
            btn.ForeColor = Color.Green;
            btn.Size = new Size(15, 15);
            btn.Text = "*";
            btn.BackColor = Color.Green;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(btn, "Points: X: " + x.ToString() + ", Y: " + y.ToString());

            this.Controls.Add(btn);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            isDrawCommand = true;
            Refresh();
        }
    }
}
