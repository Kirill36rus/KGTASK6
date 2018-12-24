using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.MyMath
{
    public struct Line
    {
        public Vector2 Point1 { get; set; }
        public Vector2 Point2 { get; set; }
        private float A;
        private float B;
        private float C;

        public Line(Vector2 p1, Vector2 p2)
        {
            this.Point1 = p1;
            this.Point2 = p2;
            this.A = -(Point2.Y - Point1.Y);
            this.B = Point2.X - Point1.X;
            this.C = -(A * Point1.X + B * Point1.Y);
        }

        public int Compare(float x, float y)
        {
            float D = A * x + B * y + C;
            if (Math.Abs(D) < 1e-10)
                return 0;
            else if (D > 0)
                return 1;
            else
                return -1;
        }
    }
}
