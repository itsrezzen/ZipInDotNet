using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip
{
    public class LinqService
    {
        public void ZipExample01()
        {
            var numbers01 = new int[] { 1, 2, 3, 4, 5 };
            var numbers02 = new int[] { 5, 4, 3, 2, 1 };

            var result = numbers01.Zip(numbers02);

            foreach (var valueTuple in result)
            {
                Console.WriteLine(valueTuple.First + "  " + valueTuple.Second);
            }
        }

        public void ZipExample02()
        {
            var numbers01 = new int[] { 1, 2, 3, 4, 5 };
            var numbers02 = new int[] { 5, 4, 3, 2, 1 };
            var numbers03 = new int[] { 6, 7, 8, 9, 2 };

            var result = numbers01.Zip(numbers02 , numbers03);

            foreach (var valueTuple in result)
            {
                Console.WriteLine(valueTuple.First + "  " + valueTuple.Second + "  " + valueTuple.Third);
            }
        }

        public void ZipExample03()
        {
            var numbers01 = new int[] { 1, 2, 3 };
            var letters = new string[] { "A", "B", "C", "D", "E" };

            var result = letters.Zip(numbers01,(l, n) => l+n.ToString());

            foreach (var valueTuple in result)
            {
                Console.WriteLine(valueTuple);
            }
        }
    }
}
