using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace Circles
{
    public partial class Form1 : Form
    {
        static CDrawer Canvas = new CDrawer(800,600,false);
        List<Ball> LBalls = new List<Ball>();
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
            casio.Enabled = true;
        }

        private void casio_Tick(object sender, EventArgs e)
        {
            Point vertex = new Point();            
            
            if (Canvas.GetLastMouseLeftClick(out vertex))
            {
                Ball bola = new Ball(Canvas,vertex);                

                foreach (Ball b in LBalls)
                {
                    bola.MarkOverlap(b);
                }

                LBalls.Add(bola);
            }
            Canvas.Clear();


            foreach (Ball b in LBalls)
            {
                b.Render();
            }

            Canvas.Render();
            if(Canvas.DrawerWindowSize.IsEmpty)
            {
                Application.Exit();
            }
        }
    }
}
