using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS8
{
    interface IExpression
    {
        double Interpret(Context context);
    }
}
