using Sort.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Repository
{
    interface ITable
    {
        Result? Add(int number);
    }
}
