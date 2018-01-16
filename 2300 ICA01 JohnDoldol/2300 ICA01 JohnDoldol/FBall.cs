using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace _2300_ICA01_JohnDoldol
{
    class FBall
    {
        private CDrawer m_canvas;
        private Random rand = new Random();
        private const int radius = 25;
        public PointF BSpeed { get; private set; }
        public Color BColor { get; private set; }
        private PointF _ballPoint;
        public PointF BallProperty
        {
            get { return _ballPoint; }
            set
            {
                //reposition ball to stay inside the cdrawer windows
                //adjust only on the axis that violates bounds and only in same direction
                _ballPoint.X = Math.Min(Math.Max(25, value.X), m_canvas.m_ciWidth-radius);
                _ballPoint.Y = Math.Min(Math.Max(25, value.Y), m_canvas.m_ciHeight-radius);
            }
        }
        private FBall(CDrawer canvas)
        {
            m_canvas = canvas;
            BSpeed = new PointF((float)(rand.NextDouble()*5 - 2.5),(float)(rand.NextDouble()*5-2.5));
        }
        public FBall(CDrawer canvas, Color palette)
            : this(canvas)
        {
            BColor = palette;
        }
        public FBall(CDrawer canvas, PointF bpoint, Color palette)
            : this(canvas, palette)
        {
            BallProperty = bpoint;
        }
        public void Render()
        {
            m_canvas.AddCenteredEllipse((int)_ballPoint.X, (int)_ballPoint.Y, radius * 2, radius * 2, BColor, 2, Color.Yellow);
        }
        public void Tick()
        {
            //check if position is within bounds then flip if out of bounds
            if (BallProperty.X <= radius || BallProperty.X >= m_canvas.m_ciWidth - radius)
            {
                BSpeed = new PointF(BSpeed.X * -1, BSpeed.Y);
            }
            else if (BallProperty.Y <= radius || BallProperty.Y >= m_canvas.m_ciHeight - radius)
            {
                BSpeed = new PointF(BSpeed.X, BSpeed.Y*-1);
            }

            //change ball property to next point
            BallProperty = new PointF(BallProperty.X + BSpeed.X, BallProperty.Y + BSpeed.Y);            
        }
    }
}
