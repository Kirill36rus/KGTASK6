using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLib.Filters
{
    public interface IFilter
    {
        Pixel[,] Process(Pixel[,] pixels);
    }
}
