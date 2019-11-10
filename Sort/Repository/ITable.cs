using Sort.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Repository
{
    interface ITable
    {
        void Clear();

        Result? Add(Number number);

        int GetMax();
        int GetMin();

        List<int> FindAllIdByNumber(int number);

        Number FindById(int id);
    }
}
