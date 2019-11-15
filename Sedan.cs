using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class Sedan : IAssemble
    {
        public void Assemble()
        {
            Console.WriteLine("Sedan Assembled");
        }
    }
}
