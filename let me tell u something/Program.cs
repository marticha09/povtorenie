using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace let_me_tell_u_something
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //proverqva dali dve nakloneni vuvejdame 4islo ot 1 do 100
            //ako 4isloto e pod 1 i nad 100 izvejda suobshtenie
            Console.Write("vuvedi edno 4islo ");
            var num = int.Parse(Console.ReadLine());
            while (num > 1 & num < 100)
            {
                Console.WriteLine("lemme tell u something");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("4isloto e:{0} i e pod diapazona 1-100", num);


        }
            
           
        
    }
}
