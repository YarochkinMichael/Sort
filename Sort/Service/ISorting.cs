using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sort.Model;

namespace Sort.Service
{
    interface ISorting
    {
        List<int> Sort(INumbers numbers);
    }
}
