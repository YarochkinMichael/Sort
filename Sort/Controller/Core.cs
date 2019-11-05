using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sort.Model;
using Sort.Service;

namespace Sort.Controller
{
    class Core : ICore
    {

        private ISorting sorting;
        private INumbers randomNumbers;
        private INumbers sortedNumbers;

        private int maxValue=1;
        private int minValue = 10;

        public Core(ISorting sorting, INumbers randomNumbers, INumbers sortedNumbers)
        {
            this.sorting = sorting;
            this.randomNumbers = randomNumbers;
            this.sortedNumbers = sortedNumbers;
        }

        //also can make it async. but it will take another day :)
        public event EventHandler DataFilled;
        public event EventHandler DataSorted;
        public event EventHandler ProgressReport;

        public Result? FillInitialTable(int count)
        {
            try {
                return randomNumbers.FillWithRandomNumbers(count, maxValue, minValue);
            }
            catch (Exception e)
            {
                return Result.Failed(e.Message);
            }
        }

        public Result? SortValues()
        {
            try
            {
                List<int> orderedList = sorting.Sort(randomNumbers);

                return sortedNumbers.FillFromSource(randomNumbers, orderedList);
            }
            catch (Exception e)
            {
                return Result.Failed(e.Message);
            }
        }

    }
}
