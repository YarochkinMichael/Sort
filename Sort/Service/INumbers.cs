using Sort.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Service
{
    interface INumbers
    {
        Result? Add(Number number);

        Result? FillWithRandomNumbers(int count, int maxValue, int minValue);
        Result? FillFromSource(INumbers randomNumbers, List<int> orderedList);

        int GetMaxValue();
        int GetMinValue();
        List<int> FindAllIdByNumber(int number);
        Number FindById(int id);
    }
}
