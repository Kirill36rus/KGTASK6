using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGLib.MyMath;

namespace CGLib.Lighting
{
    public interface ILight
    {
        Vector3 Position { get; set; }
        Vector3 Color { get; }
        Vector3 GetColorIn(Vector3 point);
        bool IsThis(int x, int y);
    }
}
