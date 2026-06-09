using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine("\n====== Problem 2 ======");

            BitArray bArr2 = new BitArray(new bool[10] { false, true, false, true, false, true, false, true, false, true });
            for (int i = 0; i < bArr2.Length; i++)
            {
                Console.WriteLine($"User {i + 1} -> {(bArr2[i] ? "Yes" : "No")}");
            }

            #endregion

            #region Problem3: Optimizing Space in Large Data
            Console.WriteLine("\n====== Problem 3 ======");

            BitArray bArr3 = new BitArray(1000); // 1000 bits initialized to false
            bArr3.Set(224, true); // Set the 225th bit to true
            bArr3.Set(433, true); // Set the 434th bit to true

            for (int i = 0; i < bArr3.Length; i++)
            {
                if (bArr3[i])
                {
                    Console.WriteLine($"Bit at index {i} is set to true.");
                }
            }

            #endregion


            #region Problem4: Scheduling Tasks
            Console.WriteLine("\n====== Problem 4 ======");

            BitArray bArr4 = new BitArray(7,true); // 7 days of the week
            bArr4.Set(0, false); // Monday
            bArr4.Set(2, false); // Wednesday

            Console.WriteLine("Scheduled tasks for the week:");
            for (int i = 0; i < bArr4.Length; i++)
            {
                if (!bArr4[i])
                {
                    Console.WriteLine($"Day {(DaysOfWeek)i} is free!");
                }
            }

            #endregion

            #region Problem5: Password Strength Checker
            Console.WriteLine("\n====== Problem 5 ======");

            BitArray bArr5 = new BitArray(4,false); // 4 bits for password strength criteria
            string password = "Pssw0rd";
            foreach(char ch in password)
            {
                if(char.IsUpper(ch)) bArr5[0] = true; // Uppercase letter
                if (char.IsLower(ch)) bArr5[1] = true; // Lowercase letter
                if (char.IsDigit(ch)) bArr5[2] = true; // Digit
                if(!char.IsLetterOrDigit(ch)) bArr5[3] = true; //special character
            }

            var allTrue = bArr5.Cast<bool>().All(b => b);
            if (allTrue)
                Console.WriteLine($"Yes Password is strong: {bArr5[0]}, {bArr5[1]}, {bArr5[2]}, {bArr5[3]}");
            else
                Console.WriteLine($"No Password is weak: {bArr5[0]}, {bArr5[1]}, {bArr5[2]}, {bArr5[3]}");

            #endregion



            #region Problem6: Password Policy Enforcement
            Console.WriteLine("\n====== Problem 6 ======");

            BitArray bArr6 = new BitArray(4, false); // 4 bits for password policy criteria
            string password2 = "Pssw0rd!";

            foreach(char ch in password2)
            {
                bArr6[0] = password2.Any(char.IsUpper); // Uppercase letter
                bArr6[1] = password2.Any(char.IsLower); // Lowercase letter
                bArr6[2] = password2.Any(char.IsDigit); // Digit
                bArr6[3] = password2.Any(c => "!@#$%^&*".Contains(c)); // Special character
            }

            var allTrue2 = bArr6.Cast<bool>().All(b => b);
            Console.WriteLine($"is passowrd valid: {(allTrue2 ? "Yes" : "No")}");

            #endregion


            #region Problem7: Traffic Light Simulation
            Console.WriteLine("\n====== Problem 7 ======");

            BitArray bArr7 = new BitArray(3, false); // 3 bits for traffic light states: Red, Yellow, Green
            bArr7[0] = true; // Red light is on

            Console.WriteLine("Traffic Light States:");
            Console.WriteLine($"Red: {(bArr7[0] ? "On" : "Off")}");
            Console.WriteLine($"Yellow: {(bArr7[1] ? "On" : "Off")}");
            Console.WriteLine($"Green: {(bArr7[2] ? "On" : "Off")}");

            #endregion
        }
        // Enum for Problem 4
        public enum DaysOfWeek
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
    }
}
