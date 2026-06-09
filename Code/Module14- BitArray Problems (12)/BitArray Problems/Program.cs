using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1: Light Control System
            Console.WriteLine("====== Problem 1 ======");
            BitArray bArr1 = new BitArray(new bool[] { false, true, false, true, false, true, false, true });

            Console.WriteLine(string.Join(", ", bArr1.Cast<bool>()));

            Console.WriteLine("After turn off light");
            bArr1.SetAll(false);
            Console.WriteLine(string.Join(", ", bArr1.Cast<bool>()));

            #endregion

            #region Problem2: User Survey Results
            Console.WriteLine("====== Problem 2 ======");

            BitArray bArr2 = new BitArray(new bool[10] { false, true, false, true, false, true, false, true, false, true });
            for(int i = 0; i< bArr2.Length; i++)
            {
                Console.WriteLine($"User {i + 1} -> {(bArr2[i]? "Yes" : "No")}");
            }

            #endregion
        }
    }
}
