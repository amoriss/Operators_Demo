using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Demo;
internal class Methods
{
    public static void NullCoalesc(List<int> numbers)
    {
        //null coalescing
        //provides fall back value if numbers is null        
        numbers = numbers ?? new List<int>();
        numbers.Add(42);
        numbers.Add(29);

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }

    public static void NullConditional(List<int> numbers)
    {
        //null conditional
        //will only do operation when NON-NULL       
        numbers?.Add(42);
        numbers?.Add(29);   //only adds to the list if it's not null
        




        //numbers = numbers ?? new List<int>();
        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}

       

    }

}
//