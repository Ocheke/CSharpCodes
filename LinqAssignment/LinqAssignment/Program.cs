
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //1. Where operator and OfType operator.
            //2. IEnumerable and IQueryable.
            //3. 
            var data = new List<Assignment>()
            {
                new Assignment()
                {
                    List1 = "Abigail",
                    List2 = 4, 
                }
            };

            var MethodSyntax = data.Where(x => x.List1 == "Abigail");
            var MdSyntax = data.Where(x => x.List1.Length > 5 || x.List1.Length >= 5);


            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item.List1);
            }



            //4. Sorting operator is used to arrange data in a particular order on the datasource.
            // The five times of sorting operators are:
            //1. OrderBy
            //2. OrderByDescending
            //3. ThenBy
            //4. ThenByDescending
            //5. Reverse


            //5.
            List<int> order = new List<int>() { 5, 2, 4, 7, 6, 2, 1, 0, 9, 8 };

            var ms = order.OrderBy(x=>x);

            var dms = order.OrderByDescending(x => x).ToList();


            //6. 
            var oms = data.OrderBy(x => x.List1).ThenBy(x => x.List2);


            //7. 
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var reverse = num.Reverse();

            foreach(var ord in num)
            {
                Console.WriteLine(ord);
            }

           
        }
        
    }
}


 

