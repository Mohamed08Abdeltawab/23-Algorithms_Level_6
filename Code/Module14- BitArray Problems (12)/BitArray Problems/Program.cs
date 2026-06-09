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

            #region Problem3: Optimizing Space in Large Data
            Console.WriteLine("====== Problem 3 ======");

            BitArray bArr3 = new BitArray(1000); // 1000 bits initialized to false
            bArr3.Set(224, true); // Set the 225th bit to true
            bArr3.Set(433, true); // Set the 434th bit to true

            for(int i =0; i< bArr3.Length; i++)
            {
                if (bArr3[i])
                {
                    Console.WriteLine($"Bit at index {i} is set to true.");
                }
            }

            #endregion
        }
    }
}
