using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib
{
    public class Pixel
    {
        private float a;
        private float r;
        private float g;
        private float b;
        public int X { get; set; }
        public int Y { get; set; }
        public float A { get => this.a; set => Check(value); }
        public float R { get => this.r; set => Check(value); }
        public float G { get => this.g; set => Check(value); }
        public float B { get => this.b; set => Check(value); }
        private float Check(float val)
        {
            if (val < 0 || val > 1) throw new ArgumentException();
            return val;
        }

        public Pixel(int x, int y, float a, float r, float g, float b)
        {
            this.X = x;
            this.Y = y;
            this.a = a;
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public Pixel(int x, int y, float r, float g, float b)
        {
            this.X = x;
            this.Y = y;
            this.a = 0;
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public Pixel(int x, int y, Pixel p)
        {
            this.X = x;
            this.Y = y;
            this.a = p.A;
            this.r = p.R;
            this.g = p.G;
            this.b = p.B;
        }

        public static float Trim(float val)
        {
            if (val < 0)
                return 0;
            else if (val > 1)
                return 1;
            else
                return val;
        }

        public static Pixel operator *(Pixel p, float f)
        {
            return new Pixel(p.X, p.Y, p.A, p.R * f, p.G * f, p.B * f);
        }
        public static Pixel operator *(float f, Pixel p)
        {
            return new Pixel(p.X, p.Y, p.A, p.R * f, p.G * f, p.B * f);
        }
        public static Pixel operator /(Pixel p, float f)
        {
            return new Pixel(p.X, p.Y, p.A, p.R / f, p.G / f, p.B / f);
        }

        public static Pixel operator *(Pixel p, MyMath.Vector3 v)
        {
            return new Pixel(p.X, p.Y, p.A, p.R * v.X, p.G * v.Y, p.B * v.Z);
        }

        public static bool operator ==(Pixel p1, Pixel p2)
        {
            return Math.Abs(p1.R - p2.R) < 1e-10 && Math.Abs(p1.G - p2.G) < 1e-10 && Math.Abs(p1.B - p2.B) < 1e-10;
        }

        public static bool operator !=(Pixel p1, Pixel p2)
        {
            return Math.Abs(p1.R - p2.R) > 1e-10 && Math.Abs(p1.G - p2.G) > 1e-10 && Math.Abs(p1.B - p2.B) > 1e-10;
        }

        public static bool Compare(Pixel p1, Pixel p2, float d)
        {
            return Math.Abs(p1.R - p2.R) < d && Math.Abs(p1.G - p2.G) < d && Math.Abs(p1.B - p2.B) < d;
        }
    }
}
