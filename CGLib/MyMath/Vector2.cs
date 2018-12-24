using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.MyMath
{
    public struct Vector2
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static float DotProduct(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static Vector2 Normolize(Vector2 v)
        {
            float d = (float)Math.Sqrt(v.X * v.X + v.Y * v.Y);
            return new Vector2(v.X / d, v.Y / d);
        }
    }
}
