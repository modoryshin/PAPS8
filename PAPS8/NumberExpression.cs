using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS8
{
    class NumberExpression:IExpression
    {
        string varname;
        public NumberExpression(string name)
        {
            varname = name;
        }
        public double Interpret(Context context)
        {
            return context.ExtractVariable(varname);
        }
    }
}
