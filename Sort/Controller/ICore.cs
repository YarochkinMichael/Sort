using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sort.Model;

namespace Sort.Controller
{
    public interface ICore
    {
        Result? FillInitialTable();

        event EventHandler DataFilled;

        Result? SortValues();

        event EventHandler DataSorted;

        event EventHandler ProgressReport;

    }

}
