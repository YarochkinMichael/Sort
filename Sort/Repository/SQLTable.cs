using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Sort.Model;

namespace Sort.Repository
{
    class SQLTable : ITable
    {
        SQLTableContent content;

        public SQLTable(string tableName)
        {
            content = new SQLTableContent(tableName);
        }

        public Result? Add(Number number)
        {
            try
            {
                content.Numbers.Add(number);

                return Result.OK("New value " + number + " added");
            }
            catch (Exception e)
            { return Result.Failed("Failed to add number " + number); }
        }

        public List<int> FindAllIdByNumber(int number)
        {
            return content.Numbers
                .Where(n => n.Value == number)
                .Select(n => n.Value)
                .Distinct()
                .ToList();
        }

        public Number FindById(int id)
        {
            return content.Numbers.Find(id);
        }

        public int GetMax()
        {
            return content.Numbers.Max(n => n.Value);
        }

        public int GetMin()
        {
            return content.Numbers.Min(n => n.Value);
        }
    }
}
