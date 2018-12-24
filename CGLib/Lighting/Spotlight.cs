using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGLib.MyMath;

namespace CGLib.Lighting
{
    public class Spotlight : ILight
    {
        public Vector3 Position { get; set; }
        public Vector3 Veiw { get; set; }
        
        public float CutOff { get; private set; }
        public float OuterCutOff { get; private set; }
        public Vector3 Color { get; private set; }

        public Spotlight(Vector3 position, Vector3 veiw, double angle, Vector3 color)
        {
            this.Position = position;
            this.Veiw = veiw;
            this.CutOff = (float)Math.Cos(angle/2);
            this.OuterCutOff = (float)Math.Cos(angle);
            this.Color = color;
        }

        public MyMath.Vector3 GetColorIn(Vector3 point)
        {
            var direction = this.Position - this.Veiw;
            var lightDir = this.Position - point;
            var phi = Vector3.DotProduct(Vector3.Normalize(direction), Vector3.Normalize(lightDir));
            if (phi > this.OuterCutOff)
            {
                float diff = Vector3.DotProduct(new Vector3(0, 0, 1), Vector3.Normalize(lightDir));
                
                float theta = Vector3.DotProduct(Vector3.Normalize(lightDir), Vector3.Normalize(direction));
                float epsilon = this.CutOff - this.OuterCutOff;
                float intensity = (theta - this.OuterCutOff) / epsilon;
                intensity = Pixel.Trim(intensity);
                return this.Color * diff * intensity;
            }
            else
                return Vector3.Zero();
        }

        public bool IsThis(int x, int y)
        {
            var direction = this.Position - this.Veiw;
            var lightDir = this.Position - new Vector3(x, y, 0);
            var phi = Vector3.DotProduct(Vector3.Normalize(direction), Vector3.Normalize(lightDir));
            return phi > this.OuterCutOff;
        }

        public void Move(int dx, int dy)
        {
            this.Veiw = new Vector3(this.Veiw.X + dx, this.Veiw.Y + dy, 0);
        }
    }
}
