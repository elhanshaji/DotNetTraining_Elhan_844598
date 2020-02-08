using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFApproachExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TRM1 ctx = new TRM1();
            var res = ctx.Users;
            foreach (var obj in res)
            {
                Console.WriteLine(obj.FullName);
            }
        }
    }
}
