using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.MyMath
{
    public struct Matrix2
    {
        public float[,] Value { get; private set; }

        public Matrix2(float[,] val)
        {
            this.Value = new float[2, 2];
            for (int i = 0; i < this.Value.GetLength(0); i++)
                for (int j = 0; j < this.Value.GetLength(1); j++)
                    this.Value[i, j] = val[i, j];
        }

        public float this[int i, int j]
        {
            get => this.Value[i, j];
            set => this.Value[i, j] = value;
        }

        public static Matrix2 Matrix2Zero()
        {
            return new Matrix2(new float[,] { { 0, 0 }, { 0, 0 } });
        }

        public static Matrix2 Matrix21()
        {
            return new Matrix2(new float[,] { { 1, 0 }, { 0, 1 } });
        }

        public static Matrix2 Rotate1(float angle)
        {
            return new Matrix2(new float[,] { { 1, -(float)Math.Tan(angle / 2) }, { 0, 1 } });
        }

        public static Matrix2 Rotate2(float angle)
        {
            return new Matrix2(new float[,] { { 1, 0 }, { (float)Math.Sin(angle), 1 } });
        }

        public static Vector2 operator *(Matrix2 m, Vector2 v)
        {
            return new Vector2(m[0, 0] * v.X + m[0, 1] * v.Y, m[1, 0] * v.X + m[1, 1] * v.Y);
        }
    }
}
