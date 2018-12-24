using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.Filters
{
    public class DeleteColorFilter : IFilter
    {
        private Pixel ToDelete { get; set; }
        private float Delta { get; set; }
        public DeleteColorFilter(Pixel toDelete, float delta)
        {
            this.ToDelete = toDelete;
            this.Delta = delta;
        }
        public Pixel[,] Process(Pixel[,] pixels)
        {
            Pixel[,] result = new Pixel[pixels.GetLength(0), pixels.GetLength(1)];
            for (int x = 0; x < pixels.GetLength(0); x++)
                for (int y = 0; y < pixels.GetLength(1); y++)
                    if (Pixel.Compare(pixels[x, y], ToDelete, Delta))
                        result[x, y] = new Pixel(pixels[x, y].X, pixels[x, y].Y, 0, pixels[x, y].R, pixels[x, y].G, pixels[x, y].B);
                    else
                        result[x, y] = pixels[x, y];
            return result;
        }
        public static Photo Process(Photo original, Pixel toDelete, float delta)
        {
            Photo p = new Photo(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
                for (int y = 0; y < original.Height; y++)
                    if (Pixel.Compare(original[x, y], toDelete, delta))
                        p[x, y] = new Pixel(original[x, y].X, original[x, y].Y, 0, original[x, y].R, original[x, y].G, original[x, y].B);
                    else
                        p[x, y] = original[x, y];
            return p;
        }
    }
}
