using Sort.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Repository
{
    public class SQLSortedTableContent : DbContext
    {
        private string tableName;

        public SQLSortedTableContent(string baseName, string tableName) : base("Data Source=.\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=" + baseName)
        {
            this.tableName = tableName;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Number>().ToTable(tableName);
        }

        public DbSet<Number> Numbers { get; set; }
    }
}
