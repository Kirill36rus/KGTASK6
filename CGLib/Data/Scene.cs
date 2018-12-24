using System;
using System.Collections.Generic;
using System.Drawing;
using CGLib.Filters;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib
{
    public class Scene
    {
        private int width;
        private int height;
        public Photo Main { get; private set; }
        public LightingMap Map { get; private set; }
        public List<Photo> Photos { get; private set; }
        public int Width { get => this.width; set => Resize(value, this.height); }
        public int Height { get => this.height; set => Resize(this.width, value); }

        public Scene(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.Main = new Photo(width, height);
            this.Map = new LightingMap(width, height);
            this.Photos = new List<Photo>();
        }

        public void Resize(int newWidth, int newHeight)
        {
            if (newWidth < 1 || newHeight < 1)
                throw new ArgumentException();
            this.width = newWidth;
            this.height = newHeight;
            this.Main = Convertors.CreateMainPhoto(this.Photos, this.width, this.height);
            this.Map = new LightingMap(this.width, this.height, this.Map.Const, this.Map.Light);
        }

        public int GetIndexPhoto(int x, int y)
        {
            foreach (Photo p in this.Photos)
                if (p.IsThis(x, y))
                    return this.Photos.IndexOf(p);
            return -1;
        }

        public int GetIndexLigh(int x, int y)
        {
            return this.Map.GetIndexSpotlight(new MyMath.Vector3(x, y, 0));
        }

        public void UpdatePhotos()
        {
            this.Main = Convertors.CreateMainPhoto(this.Photos, this.width, this.height);
            //for (int x = 0; x < Width; x++)
            //    for (int y = 0; y < Height; y++)
            //        if (Main[x, y].A < 1e-10)
            //        {
            //            Main[x, y].A = 1;
            //            Main[x, y].R = 0;
            //            Main[x, y].G = 0;
            //            Main[x, y].B = 0;
            //        }
                        

        }

        public void UpdateLightingMap()
        {
            this.Map = new LightingMap(this.width, this.height, this.Map.Const, this.Map.Light);
           
        }

        public Bitmap GetBitmap(bool isLighting = false)
        {
            if (isLighting)
                return Convertors.Photo2Bitmap(this.Main);
            else
                return Convertors.Photo2Bitmap(LightingFilter.Process(this.Main, 0.1f, this.Map));
        }
    }
}
