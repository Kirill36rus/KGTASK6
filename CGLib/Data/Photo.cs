using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGLib.MyMath;
using System.Drawing;
using CGLib.Filters;

namespace CGLib
{
    public class Photo
    {
        private int x;
        private int y;
        public int X { get => this.x; set => ChangeX(value); }
        public int Y { get => this.y; set => ChangeY(value); }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Pixel[,] Data { get; private set; }
        public List<IFilter> Filters { get; private set; }
        public Photo(int width, int height)
        {
            if (width < 1 || height < 1) return;//throw new ArgumentException();
            this.x = 0;
            this.y = 0;
            this.Width = width;
            this.Height = height;
            this.Data = new Pixel[width, height];
            this.Filters = new List<IFilter>();
            for (int i = 0; i < this.Data.GetLength(0); i++)
                for (int j = 0; j < this.Data.GetLength(1); j++)
                    this.Data[i, j] = new Pixel(i,j,0,0,0,0);
        }

        public Photo(int width, int height, int x, int y)
        {
            if (width < 1 || height < 1) throw new ArgumentException();
            this.x = x;
            this.y = y;
            this.Width = width;
            this.Height = height;
            this.Data = new Pixel[width, height];
            this.Filters = new List<IFilter>();
            for (int i = 0; i < this.Data.GetLength(0); i++)
                for (int j = 0; j < this.Data.GetLength(1); j++)
                    this.Data[i, j] = new Pixel(i,j,0,0,0,0);
        }

        public Photo(Pixel[,] original, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Width = original.GetLength(0);
            this.Height = original.GetLength(1);
            this.Data = new Pixel[this.Width, this.Height];
            this.Filters = new List<IFilter>();
            for (int i = 0; i < this.Data.GetLength(0); i++)
                for (int j = 0; j < this.Data.GetLength(1); j++)
                    this.Data[i, j] = new Pixel(this.X + i, this.Y + j, original[i, j].A, original[i, j].R, original[i, j].G, original[i, j].B);
        }

        public void Move(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
            for (int i = 0; i < this.Width; i++)
                for (int j = 0; j < this.Height; j++)
                {
                    this.Data[i, j].X += dx;
                    this.Data[i, j].Y += dy;
                }
        }

        public void ChangeXY(int x, int y)
        {
            int dx = x-this.x, dy = y-this.y;
            this.x = x; this.y = y;
            for(int i=0;i<this.Width;i++)
                for(int j=0;j<this.Height;j++)
                {
                    this.Data[i, j].X += dx;
                    this.Data[i, j].Y += dy;
                }
        }

        public void ChangeX(int x)
        {
            this.x = x;
            for (int i = 0; i < this.Width; i++)
                for (int j = 0; j < this.Height; j++)
                    this.Data[i, j].X = x + i;
        }
        public void ChangeY(int y)
        {
            this.y = y;
            for (int i = 0; i < this.Width; i++)
                for (int j = 0; j < this.Height; j++)
                    this.Data[i, j].Y = y + j;
        }

        public void Process(IFilter filter)
        {
            int x = this.X, y = this.Y;
            this.Data = filter.Process(this.Data);
            this.x = this.Data[0, 0].X;
            this.y = this.Data[0, 0].Y;
            this.Width = this.Data.GetLength(0);
            this.Height = this.Data.GetLength(1);
            ChangeXY(x, y);
        }
        public Pixel GetPixel(int x, int y)
        {
            //for (int i = 0; i < this.Data.GetLength(0); i++)
            //    for (int j = 0; j < this.Data.GetLength(1); j++)
            //        if (x == this.Data[i, j].X && y == this.Data[i, j].Y)
            //            return this.Data[i, j];
            if (x >= 0 && x < this.Data.GetLength(0) && y >= 0 && y < this.Data.GetLength(1))
                return this.Data[x, y];
            else
                return null;
        }
        public Photo GetPhoto()
        {

            Pixel[,] r = new Pixel[0, 0];
            foreach (IFilter filter in this.Filters)
                r = filter.Process(this.Data);
            return new Photo(r, this.X, this.Y);
        }

        public bool IsThis(int x, int y)
        {
            Vector2 lt = new Vector2(this.Data[0, 0].X, this.Data[0, 0].Y);
            Vector2 rt = new Vector2(this.Data[0, this.Height - 1].X, this.Data[0, this.Height - 1].Y);
            Vector2 rb = new Vector2(this.Data[this.Width - 1, this.Height - 1].X, this.Data[this.Width - 1, this.Height - 1].Y);
            Vector2 lb = new Vector2(this.Data[this.Width - 1, 0].X, this.Data[this.Width - 1, 0].Y);

            Line line1 = new Line(lt, rt);
            Line line2 = new Line(rt, rb);
            Line line3 = new Line(rb, lb);
            Line line4 = new Line(lb, lt);
            return line1.Compare(x, y) != 1 && line2.Compare(x, y) != 1 && line3.Compare(x, y) != 1 && line4.Compare(x, y) != 1;
        }

        public Pixel this[int x, int y]
        {
            get => this.Data[x, y];
            set => this.Data[x, y] = value;
        }

        public Point[] GetPointsToRect()
        {
            return new Point[] { new Point(Data[0, 0].X, Data[0, 0].Y),
                new Point(Data[0, Height-1].X, Data[0, Height-1].Y),
                new Point(Data[Width-1, Height-1].X, Data[Width-1, Height-1].Y),
                new Point(Data[Width-1, 0].X, Data[Width-1, 0].Y),
                new Point(Data[0, 0].X, Data[0, 0].Y)};
        }
    }
}
