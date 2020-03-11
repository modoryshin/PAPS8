using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определяем переменные
            double x = 8, y = 6, z = 3;
            //Создаем новый контекст
            Context context = new Context();
            //Добавляем в контекст пременные
            context.DefineVariable("xvar", x);
            context.DefineVariable("yvar", y);
            context.DefineVariable("zvar", z);
            //Определяем выражение z+y-x
            IExpression expression = new AddExpresion(new SubstractExpresion(new NumberExpression("yvar"), new NumberExpression("xvar")), new NumberExpression("zvar"));
            //Присваиваем результаты вычислений в переменную result
            double result = expression.Interpret(context);
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
