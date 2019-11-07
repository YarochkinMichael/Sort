using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Model
{
    public class Number
    {
        public Number(int v)
        {
            Value = v;
        }

        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
    }
}
