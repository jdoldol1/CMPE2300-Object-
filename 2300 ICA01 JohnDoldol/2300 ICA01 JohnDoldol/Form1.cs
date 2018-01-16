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
        Random rand = new Random();
        public tlabel()
        {
            InitializeComponent();
            this.Visible = false;
            casio.Enabled = true;
        }
        private void casio_Tick(object sender, EventArgs e)
        {
            //Tick all FBall in list
            if (LBalls != null) { foreach (FBall fb in LBalls) { fb.Tick(); } }     

            //IF user clicks mouse, create newpoint and random number
            Point vertex = new Point();
            
            if (canvas.GetLastMouseLeftClick(out vertex))
            {
                Draw(vertex, Color.FromArgb(rand.Next(50, 255), rand.Next(0,255), rand.Next(0, 255), rand.Next(0, 255)));
            }
            else if(canvas.GetLastMouseRightClick(out vertex))
            {
                Draw(new Point(0,0), Color.Black);           
            }

            //clear then render all FBalls
            canvas.Clear();
            foreach (FBall fb in LBalls)
            {
                fb.Render();
            }

            //show all FBalls on CDrawer canvas
            canvas.Render();

            //check if canvas is closed
            if(canvas == null)
            {
                Application.Exit();
            }
        }        
        private void Draw(PointF vertex, Color colour)
        {
            FBall bola = new FBall(canvas, vertex, colour);
            LBalls.Add(bola); //add FBall to list            
            bola.Render(); //render the newly created FBall            
        }
        
    }
}
