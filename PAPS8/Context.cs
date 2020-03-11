using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS8
{
    class Context
    {
        Dictionary<string, double> variables;
        public Context()
        {
            variables = new Dictionary<string, double>();
        }
        public void DefineVariable(string name, double value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }
        public double ExtractVariable(string name)
        {
            return variables[name];
        }
    }
}
