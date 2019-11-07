using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort.Model;
using Sort.Repository;

namespace Sort.Service
{
    class Numbers : INumbers
    {
        ITable table;

        public Numbers(ITable table)
        {
            this.table = table;
        }

        public Result? Add(Number number)
        {
            return table.Add(number);
        }

        public Result? FillFromSource(INumbers randomNumbers, List<int> orderedList)
        {
            for (int i = 0; i != orderedList.Count; i++)
                Add(randomNumbers.FindById(orderedList[i]));

                throw new NotImplementedException();
        }

        public Result? FillWithRandomNumbers(int count, int maxValue, int minValue)
        {
            for (int i = 0; i != count; i++)
            {
                Result? result = table.Add(new Number(new Random().Next(maxValue, minValue)));

                if (result.HasValue == false)
                    return result;
            }

            return Result.OK("Filling of " + count + " random numbers from interval " + minValue + " to " +maxValue+" is successful");
        }

        public List<int> FindAllIdByNumber(int number)
        {
            return table.FindAllIdByNumber(number);
        }

        public int GetMaxValue()
        {
            return table.GetMax();
        }

        public int GetMinValue()
        {
            return table.GetMin();
        }

        public Number FindById(int id)
        {
            return table.FindById(id);
        }
    }
}
