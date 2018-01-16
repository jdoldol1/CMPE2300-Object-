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

namespace _2300_ICA01_JohnDoldol
{
   
    public partial class tlabel : Form
    {
        private CDrawer canvas = new CDrawer(900,400,false, true);
        private List<FBall> LBalls = new List<FBall>();
        public tlabel()
        {
            InitializeComponent();
            flabel.Font = new Font("Arial",16);
            clabel.Font = new Font("Arial",16);
            labelt.Font = new Font("Arial",16);
            labela.Font = new Font("Arial",16);
            labelv.Font = new Font("Arial",16);
            this.Visible = true;
            casio.Enabled = true;
        }
        private void casio_Tick(object sender, EventArgs e)
        {
            //Tick all FBall in list
            if (LBalls != null) { foreach (FBall fb in LBalls) { fb.Tick(); } }     

            //IF user clicks mouse
            Point vertex = new Point();
            Random rand = new Random();
            if (canvas.GetLastMouseLeftClick(out vertex))
            {
                Draw(vertex, Color.FromArgb(rand.Next(50, 255), rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255)));
            }
            else if(canvas.GetLastMouseRightClick(out vertex))
            {
                Draw(vertex, Color.Black);           
            }

            //clear then render all FBalls
            canvas.Clear();
            foreach (FBall fb in LBalls) { fb.Render(); }
            canvas.Render();
        }        
        private void Draw(PointF vertex, Color colour)
        {
            FBall bola = new FBall(canvas, vertex, colour);
            LBalls.Add(bola); //add FBall to list            
            bola.Render(); //render the newly created FBall

            //update label values
            labela.Text = string.Format("{0:N2} px/s",AverageSpeed());
            labelt.Text = LBalls.Count.ToString();
        }
        private double AverageSpeed()
        {
            double total = 0;
            double average;
            foreach(FBall fb in LBalls)
            {
                total += Math.Abs(fb.BSpeed.X);
                total += Math.Abs(fb.BSpeed.Y);
            }
            average = total / LBalls.Count * 2;
            return average;
        }
    }
}
