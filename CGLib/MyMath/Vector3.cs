using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.MyMath
{
    public struct Vector3
    {
        private float[] crd;

        public Vector3(float x, float y, float z)
        {
            this.crd = new float[] { x, y, z };
        }

        public float X { get => this.crd[0]; set => this.crd[0] = value; }
        public float Y { get => this.crd[1]; set => this.crd[1] = value; }
        public float Z { get => this.crd[2]; set => this.crd[2] = value; }

        public float this[int i]
        {
            get => this.crd[i];
            set => this.crd[i] = value;
        }

        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            if (object.ReferenceEquals(null, v1) && object.ReferenceEquals(null, v2))
                return true;
            else
                return (v1.X - v2.X < 1e-10 && v1.Y - v2.Y < 1e-10 && v1.Z - v2.Z < 1e-10);
        }

        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            if (object.ReferenceEquals(null, v1) || object.ReferenceEquals(null, v2))
                return false;
            else
                return (v1.X - v2.X > 1e-10 || v1.Y - v2.Y > 1e-10 || v1.Z - v2.Z > 1e-10);
        }

        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        public static Vector3 operator *(Vector3 v, float a)
        {
            return new Vector3(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3 operator /(Vector3 v, float a)
        {
            return new Vector3(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1[0] + v2[0], v1[1] + v2[1], v1[2] + v2[2]);
        }

        public static Vector3 operator +(Vector3 v, float f)
        {
            return new Vector3(v.X + f, v.Y + f, v.Z + f);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1[0] - v2[0], v1[1] - v2[1], v1[2] - v2[2]);
        }

        public static Vector3 operator -(Vector3 v, float f)
        {
            return new Vector3(v.X - f, v.Y - f, v.Z - f);
        }

        public static Vector3 NewVector3(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v2.X - v1.X, v2.Y - v1.Y, v2.Z - v1.Z);
        }

        public static Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }

        public static Vector3 CrossProduct(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.Y * v2.Z - v2.Y * v1.Z, v1.Z * v2.X - v2.Z * v1.X, v1.X * v2.Y - v2.X * v1.Y);
        }

        public static float DotProduct(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3 Normalize(Vector3 v)
        {
            float length = (float)Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);
            // make sure we don't divide by 0.
            if (length > 0.00001)
                return new Vector3(v[0] / length, v[1] / length, v[2] / length);
            else return Vector3.Zero();
        }

        public static float Abs(Vector3 v1, Vector3 v2)
        {
            return (float)Math.Sqrt((v2.X - v1.X) * (v2.X - v1.X) + (v2.Y - v1.Y) * (v2.Y - v1.Y) + (v2.Z - v1.Z) * (v2.Z - v1.Z));
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
        }
    }
}
