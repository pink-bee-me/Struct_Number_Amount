using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Number_Amount
{
    class Program
    {
        static void Main(string[] args)
        {
            Number amount1 = new Number();
            amount1.Amount = .5678M;
            Console.WriteLine("The Decimal Amount is " + amount1.Amount);
            Console.ReadLine();
        }
    }
}

