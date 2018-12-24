using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.Filters
{
    public class ScalingFilter : IFilter
    {
        private int NewWidth { get; set; }
        private int NewHeight { get; set; }

        public ScalingFilter(int width, int height)
        {
            this.NewWidth = width;
            this.NewHeight = height;
        }

        public Pixel[,] Process(Pixel[,] pixels)
        {
            if (NewHeight < 1 || NewWidth < 1)
                return pixels;
            Pixel[,] temp = new Pixel[NewWidth, NewHeight];
            float x_ratio = pixels.GetLength(0) / (float)NewWidth;
            float y_ratio = pixels.GetLength(1) / (float)NewHeight;
            float px, py;
            for (int i = 0; i < temp.GetLength(1); i++)
            {
                for (int j = 0; j < temp.GetLength(0); j++)
                {
                    px = (j * x_ratio);
                    py = (i * y_ratio);
                    temp[j, i] = new Pixel(j, i, pixels[(int)(px), (int)(py)]);
                }
            }
            return temp;
        }
        public static Photo Process(Photo original, int newWidth, int newHeight)
        {
            Photo temp = new Photo(newWidth, newHeight);
            float x_ratio = original.Width / (float)temp.Width;
            float y_ratio = original.Height / (float)temp.Height;
            float px, py;
            for (int i = 0; i < temp.Height; i++)
            {
                for (int j = 0; j < temp.Width; j++)
                {
                    px = (j * x_ratio);
                    py = (i * y_ratio);
                    temp[j, i] = new Pixel(j,i,original[(int)(px), (int)(py)]);
                }
            }
            return temp;
        }
    }
}
