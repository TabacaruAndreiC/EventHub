using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive
{
    public class DelegateExamples
    {
        public delegate string MyMethodDelegate(int prop);

        public string MyMethod(int prop)
        {
            return $"{prop} is my favourite number!";
        }

        public string MySecondMethod(int prop)
        {
            return $"I don't like number {prop} at all.";
        }

    }
}
