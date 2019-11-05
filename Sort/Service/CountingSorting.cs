using Sort.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Service
{
    class CountingSorting : ISorting
    {
        public List<int> Sort(INumbers numbers)
        {
            List<int> list = new List<int>();

            int minValue = numbers.GetMinValue();
            int maxValue = numbers.GetMaxValue();

            for (int i = minValue; i != maxValue; i++)
                list.AddRange(numbers.FindAllIdByNumber(i));

            return list;
        }
    }
}
