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

        public Result? Add(Number number)
        {
            throw new NotImplementedException();
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
                Result? result = table.Add(new Random().Next(maxValue, minValue));

                if (result.HasValue == false)
                    return result;
            }

            return Result.OK("Filling of " + count + " random numbers from interval " + minValue + " to " +maxValue+" is successful");
        }

        public List<int> FindAllIdByNumber(int number)
        {
            throw new NotImplementedException();
        }

        public int GetMaxValue()
        {
            throw new NotImplementedException();
        }

        public int GetMinValue()
        {
            throw new NotImplementedException();
        }

        public Number FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
