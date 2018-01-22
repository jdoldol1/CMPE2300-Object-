using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;

namespace Circles
{
    public class Ball
    {
        private readonly CDrawer _canvas = null;
        private const int Radius = 50;
        private Point _point;
        public Color Color { get; private set; }
        public Point PointProperty
        {
            get { return _point; }
            set
            {
                _point.X = Math.Min(Math.Max(Radius, value.X), _canvas.m_ciWidth - Radius);
                _point.Y = Math.Min(Math.Max(Radius, value.Y), _canvas.m_ciHeight - Radius);
            }
        }               

        public Ball(CDrawer canvas, Point point)
        {
            _canvas = canvas;
            PointProperty = point;
            Color = Color.Yellow;
        }
        public static double GetDisplacement(Ball b1, Ball b2)
        {
            GetCount++;
            //return absolute point to point distance between two balls
            if (b1._point.X == b2._point.X)
            {
                return Math.Abs(b1._point.Y - b2._point.Y);
            }
            else if (b1._point.Y == b2._point.Y)
            {
                return Math.Abs(b1._point.X - b2._point.X);
            }
            else
            {
                double a = Math.Abs(b1._point.X - b2._point.X);
                double b = Math.Abs(b1._point.Y - b2._point.Y);
                return Math.Abs(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            }
        }
        public void MarkOverlap(Ball ball)
        {
            //set color of the invoking ball to red if it overlaps 
            if(GetDisplacement(this, ball) < Radius*2)
            {
                Color = Color.Red;
            }
        }
        public static int GetCount { get; private set; }
        public void Render()
        {
            _canvas.AddCenteredEllipse((int)_point.X, (int)_point.Y, Radius*2, Radius*2, Color, 2, Color.White);
            //_canvas.AddText(GetCount.ToString(), 15, (int)_point.X - 30, (int)_point.Y - 30, 60, 60, Color.Black);
            _canvas.AddText(GetCount.ToString(), 20, new Rectangle(new Point(PointProperty.X-Radius,PointProperty.Y-Radius),new Size(Radius*2,Radius*2)), Color.Black);
        }

    }
}
