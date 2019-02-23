using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    // Here defined a template for implementing which is called Interface type.
    public interface ICalculate
    {
        // Calculate method is a template and after every inheriting it must be implement
        int Calculate(DateTime date);
    }
}
