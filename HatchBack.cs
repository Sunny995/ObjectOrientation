using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class HatchBack : IAssemble
    {
        public void Assemble()
        {
            Console.WriteLine("HatchBack Assembled");
        }
    }
}
