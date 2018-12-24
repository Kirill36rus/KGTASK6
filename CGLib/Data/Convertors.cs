using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FastBitmapLib;

namespace CGLib
{
    public class Convertors
    {
        public static Photo Bitmap2Photo(Bitmap bmp)
        {
            var photo = new Photo(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    var pixel = bmp.GetPixel(x, y);
                    photo[x, y] = new Pixel(x, y, 1f, (float)pixel.R / 255, (float)pixel.G / 255, (float)pixel.B / 255);
                }
            return photo;
        }

        public static Bitmap Photo2Bitmap(Photo photo)
        {
            Bitmap bmp = new Bitmap(photo.Width, photo.Height);
            FastBitmap fbmp = new FastBitmap(bmp);
            fbmp.Lock();
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    fbmp.SetPixel(x, y, Color.FromArgb((byte)((photo[x, y].A) * 255),
                        (byte)((photo[x, y].R) * 255),
                        (byte)((photo[x, y].G) * 255),
                         (byte)((photo[x, y].B) * 255)));
                }
            fbmp.Dispose();
            return bmp;
        }

        //public static Bitmap Photo2Bitmap(Photo photo)
        //{
        //    var bmp = new Bitmap(photo.Width, photo.Height);
            
        //    Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        //    System.Drawing.Imaging.BitmapData bmpData = 
        //        bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
        //        bmp.PixelFormat);
            
        //    IntPtr ptr = bmpData.Scan0;
        //    int bytes = /*Math.Abs(bmpData.Stride)*/ bmp.Width * bmp.Height;

        //    Int32[] rgbValues = new Int32[bytes];
        //    int index;
        //    for (int x = 0; x < bmp.Width; x++)
        //        for (int y = 0; y < bmp.Height; y++)
        //        {
        //            index = x * y + y;
        //            //index *= 4;
        //            rgbValues[index] = Color.FromArgb((byte)(Pixel.Trim(photo[x, y].A) * 255),
        //                (byte)(Pixel.Trim(photo[x, y].R) * 255),
        //                (byte)(Pixel.Trim(photo[x, y].G) * 255),
        //                 (byte)(Pixel.Trim(photo[x, y].B) * 255)).ToArgb();
        //            //rgbValues[index+1] = (byte)(Pixel.Trim(photo[x, y].R) * 255);
        //            //rgbValues[index+2] = (byte)(Pixel.Trim(photo[x, y].G) * 255);
        //            //rgbValues[index+3] = (byte)(Pixel.Trim(photo[x, y].B) * 255);
        //        }
        //    System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
        //    bmp.UnlockBits(bmpData);
        //    return bmp;
        //}

        private static void CompletePhoto(Photo main, Photo compl)
        {
            for (int i = 0; i < compl.Width; i++)
                for (int j = 0; j < compl.Height; j++)
                    if (main.Width > compl[i, j].X && compl[i,j].X>-1 && compl[i,j].Y>-1 && main.Height > compl[i, j].Y && main[compl[i, j].X, compl[i, j].Y].A < 1e-10)
                        main[compl[i, j].X, compl[i, j].Y] = compl[i, j];
        }

        public static Photo CreateMainPhoto(List<Photo> photos, int width, int height)
        {
            Photo main = new Photo(width, height);
            foreach (Photo p in photos)
                CompletePhoto(main, p);
            return main;
        }
    }
}
