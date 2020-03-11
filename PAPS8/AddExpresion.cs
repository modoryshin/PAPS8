using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS8
{
    class AddExpresion:IExpression
    {
        IExpression firstExpression;
        IExpression secondExpression;
        public AddExpresion(IExpression first, IExpression second)
        {
            firstExpression = first;
            secondExpression = second;
        }
        public double Interpret(Context context)
        {
            return firstExpression.Interpret(context) + secondExpression.Interpret(context);
        }
    }
}
