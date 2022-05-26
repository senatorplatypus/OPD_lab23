using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class SortByMaxElement:IBaseAlgorithm
    {
        public int Handle(int[] row)
        {
            return row.Max();
        }
    }
}
