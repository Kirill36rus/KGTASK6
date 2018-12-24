using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGLib.MyMath;
using CGLib.Lighting;

namespace CGLib
{
    public class LightingMap
    {
        public Vector3[,] Map { get; private set; }
        public List<ILight> Light { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private float lightingConst;
        public float Const { get => lightingConst; set => lightingConst = Pixel.Trim(value); }

        public Vector3 this[int x, int y]
        {
            get => this.Map[x, y];
        }

        public LightingMap(int width, int height)
        {
            this.Const = 0.1f;
            this.Map = new Vector3[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    this.Map[x, y] = new Vector3(Const, Const, Const);
            this.Width = width;
            this.Height = height;
            this.Light = new List<ILight>();
        }

        public LightingMap(int width, int height, float c, List<ILight> lights)
        {
            this.Const = c;
            this.Map = new Vector3[width, height];
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    this.Map[x, y] = new Vector3(Const, Const, Const);
            this.Width = width;
            this.Height = height;
            this.Light = lights;
            UpdateMap();
        }

        public void AddLight(Vector3 position, Vector3 veiw, float angle, Vector3 color)
        {
            this.Light.Add(new Spotlight(position, veiw, angle, color));
            UpdateMap();
        }

        private void UpdateMap()
        {
            for (int x = 0; x < this.Width; x++)
                for (int y = 0; y < this.Height; y++)
                {
                    Vector3 result = new Vector3(Const, Const, Const);
                    foreach (ILight l in this.Light)
                        result += l.GetColorIn(new Vector3(x, y, 0));
                    this.Map[x,y] = new Vector3(Pixel.Trim(result.X), Pixel.Trim(result.Y), Pixel.Trim(result.Z));
                }
        }

        public int GetIndexSpotlight(Vector3 v)
        {
            foreach (ILight light in this.Light)
                if (light is Spotlight && (light as Spotlight).Veiw == v)
                    return this.Light.IndexOf(light);
            return -1;
        }
    }
}
