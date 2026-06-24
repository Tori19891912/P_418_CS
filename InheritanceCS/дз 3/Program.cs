using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_3_29
{
    public partial class Form1 : Form
    {

        double[] nx, ny;
        const int NP = 100;
        Random r = new Random();
        const int WH = 200;
        private int cshft, pshft;
        Color[] col, colors;
        Panel[] panels;
        PointF[] points;
        PointF[] pnts;
        int np, pn, cn;


        void GenPoints()
        {
            for (int i = 0; i < NP; i++)
            {
                nx[i] = r.NextDouble() * WH;
                ny[i] = r.NextDouble() * WH;
            }
            for (int i = 0; i < NP; i++) pshft = r.Next(NP);
        }

        public Form1()
        {
            InitializeComponent();
            nx = new double[NP]; ny = new double[NP]; points = new PointF[21]; colors = new Color[7];
            col = new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.BlueViolet, Color.LemonChiffon, Color.Lime, Color.Magenta, Color.Brown };
            GenPoints();
            cshft = r.Next(10);
            panels = new Panel[7];
            panels[0] = panel1; panels[1] = panel2; panels[2] = panel3; panels[3] = panel4; panels[4] = panel5; panels[5] = panel6; panels[6] = panel7;
            Init();
        }

        private void panels_Paint(object sender, PaintEventArgs e)
        {
            pnts = new PointF[3];
            Graphics g = e.Graphics;
            Pen p = new Pen(col[np], 2);
            Brush b = new SolidBrush(col[np]);
            pnts[0] = new Point(100, 56);
            pnts[1] = new Point(45, 123);
            pnts[2] = new Point(12, 40);
            g.DrawPolygon(p, pnts);
            g.FillPolygon(b, pnts);
            Invalidate();
        }

        private void Init()
        {
            pn = pshft;
            for (int i = 0; i < 21; i++)
            {
                pn %= NP;
                points[i] = new PointF((float)nx[pn], (float)ny[pn]);
                pn++;
            }

            cn = cshft;
            for (int i = 0; i < 7; i++)
            {
                cn %= 10;
                colors[i] = col[cn];
                cn++;
            }
            for (np = 0; np < 7; np++)
            {
                panels[np].Paint += new PaintEventHandler(panels_Paint);
            }
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            cshft = r.Next(10);
            Init();
        }

        private void bPlace_Click(object sender, EventArgs e)
        {
            pshft = r.Next(NP);
            Init();
        }

    }
}