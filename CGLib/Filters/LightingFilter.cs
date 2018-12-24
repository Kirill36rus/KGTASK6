using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.Filters
{
    public class LightingFilter : IFilter
    {
        private LightingMap Map { get; set; }
        float c;
        public LightingFilter(LightingMap map, float c)
        {
            this.Map = map;
            this.c = c;
        }

        public Pixel[,] Process(Pixel[,] pixels)
        {
            Pixel[,] result = new Pixel[pixels.GetLength(0), pixels.GetLength(1)];
            for (int x = 0; x < pixels.GetLength(0); x++)
                for (int y = 0; y < pixels.GetLength(1); y++)
                {
                    //photo[x, y] = original[x, y] * c;
                        result[x, y] = new Pixel(pixels[x, y].X, pixels[x, y].Y, pixels[x, y].A, pixels[x, y].R * Pixel.Trim(Map[x, y].X),
                            pixels[x, y].G * Pixel.Trim(Map[x, y].Y), pixels[x, y].B * Pixel.Trim(Map[x, y].Z));
                }
            return result;
        }

        public static Photo Process(Photo original, float c, LightingMap map)
        {
            Photo photo = new Photo(original.Width, original.Height);
            for (int x = 0; x < photo.Width; x++)
                for (int y = 0; y < photo.Height; y++)
                {
                    //photo[x, y] = original[x, y] * c;
                    if (map != null)
                        photo[x, y] = new Pixel(original[x, y].X, original[x, y].Y, original[x, y].A, original[x, y].R * Pixel.Trim( map[x, y].X),
                            original[x, y].G * Pixel.Trim( map[x, y].Y), original[x, y].B * Pixel.Trim( map[x, y].Z));
                }
            return photo;
        }
    }
}
