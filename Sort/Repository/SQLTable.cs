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
        DbContext context;
        DbSet<Number> table;

        public SQLTable(DbContext context, DbSet<Number> table)
        {
            this.context = context;
            this.table = table;
        }

        public Result? Add(Number number)
        {
            try
            {
                table.Add(number);

                context.SaveChanges();

                return Result.OK("New value " + number + " added");
            }
            catch (Exception e)
            { return Result.Failed("Failed to add number " + number + " : " + e.Message); }
        }

        public void Clear()
        {
            var all = from c in table select c;
            table.RemoveRange(all);
            context.SaveChanges();
        }

        public List<int> FindAllIdByNumber(int number)
        {
            return table
                .Where(n => n.Value == number)
                .Select(i=> i.Id)
                .Distinct()
                .ToList();
        }

        public Number FindById(int id)
        {
            return table.Find(id);
        }

        public int GetMax()
        {
            return table.Max(n => n.Value);
        }

        public int GetMin()
        {
            return table.Min(n => n.Value);
        }
    }
}
