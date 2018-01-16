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
        private CDrawer _canvas;
        private Random _rand = new Random();
        private const int Radius = 25;
        private PointF _ballPoint;

        public PointF BSpeed { get; private set; }
        public Color BColor { get; private set; }
        
        public PointF BallProperty
        {
            get { return _ballPoint; }
            set
            {
                //reposition ball to stay inside the cdrawer windows
                //adjust only on the axis that violates bounds and only in same direction
                _ballPoint.X = Math.Min(Math.Max(25, value.X), _canvas.m_ciWidth-Radius);
                _ballPoint.Y = Math.Min(Math.Max(25, value.Y), _canvas.m_ciHeight-Radius);
            }
        }
        private FBall(CDrawer canvas)
        {
            _canvas = canvas;
            BSpeed = new PointF((float)(_rand.NextDouble()*5 - 2.5),(float)(_rand.NextDouble()*5-2.5));
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
            _canvas.AddCenteredEllipse((int)_ballPoint.X, (int)_ballPoint.Y, Radius * 2, Radius * 2, BColor, 2, Color.Yellow);
        }
        public void Tick()
        {
            //check if position is within bounds then flip if out of bounds
            if (BallProperty.X <= Radius || BallProperty.X >= _canvas.m_ciWidth - Radius)
            {
                BSpeed = new PointF(BSpeed.X * -1, BSpeed.Y);
            }
            if (BallProperty.Y <= Radius || BallProperty.Y >= _canvas.m_ciHeight - Radius)
            {
                BSpeed = new PointF(BSpeed.X, BSpeed.Y*-1);
            }

            //change ball property to next point
            BallProperty = new PointF(BallProperty.X + BSpeed.X, BallProperty.Y + BSpeed.Y);            
        }
    }
}
