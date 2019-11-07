using Sort.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Repository
{
    public class SQLTableContent : DbContext
    {
        public SQLTableContent(string tableName) : base(tableName)
        {
        }

        public DbSet<Number> Numbers { get; set; }
    }
}
