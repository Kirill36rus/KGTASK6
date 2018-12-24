using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.Filters
{
    public class RotateFilter : IFilter
    {
        private float AngleRotate { get; set; }
        public RotateFilter(float angle)
        {
            this.AngleRotate = angle;
        }

        public Pixel[,] Process(Pixel[,] pixels)
        {
            Pixel[,] result = new Pixel[pixels.GetLength(0), pixels.GetLength(1)];
            var rotate13 = MyMath.Matrix2.Rotate1(AngleRotate);
            var rotate2 = MyMath.Matrix2.Rotate2(AngleRotate);
            for (int x = 0; x < pixels.GetLength(0); x++)
                for (int y = 0; y < pixels.GetLength(1); y++)
                {
                    var newPosition = rotate13 * new MyMath.Vector2(x, y);
                    newPosition = rotate2 * new MyMath.Vector2((int)newPosition.X, (int)newPosition.Y);
                    newPosition = rotate13 * new MyMath.Vector2((int)newPosition.X, (int)newPosition.Y);
                    result[x, y] = new Pixel((int)newPosition.X, (int)newPosition.Y, pixels[x, y]);
                }
            return result;
        }

        public static Photo Process(Photo original, float angleRotate)
        {
            var photo = new Photo(original.Width, original.Height);
            var rotate13 = MyMath.Matrix2.Rotate1(angleRotate);
            var rotate2 = MyMath.Matrix2.Rotate2(angleRotate);

            for (int x = 0; x < original.Width; x++)
                for (int y = 0; y < original.Height; y++)
                {
                    var newPosition = rotate13 * new MyMath.Vector2(x, y);
                    newPosition = rotate2 * new MyMath.Vector2((int)newPosition.X, (int)newPosition.Y);
                    newPosition = rotate13 * new MyMath.Vector2((int)newPosition.X,(int)newPosition.Y);
                    photo[x, y] = new Pixel((int)newPosition.X, (int)newPosition.Y, original[x, y]);
                }
            return photo;
        }
    }
}
