using System;
using Custom_Array;
using Custom_Array.NegativeNumberDeleter;
using Custom_Array.SymbolChecker;

namespace lab2_part1 {

    public class Program {

        public static void Main(string[] args) {

            CustomArray a1 = new CustomArray();

            CustomArray a2 = new CustomArray();
            a2.array = new int[]{1, 2, 3, 4, 5};

            CustomArray a3 = new CustomArray();
            a3.array = new int[]{-2, 3, 4, -5, 6};

            CustomArray a4 = new CustomArray();
            a4.array = new int[]{1, 2, 3, 4, 5};
            a3.array = new int[]{-2, 3, -4, 5, 6};

            Console.WriteLine(a1.array[0]);
            a1 = a2*a3; 
            Console.WriteLine(a1.array[0]);

            foreach (var item in a1.array) {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine(a1.hasSymbol('6'));
            Console.WriteLine(a1.hasSymbol('4'));

            a1.deleteNegativeValues();

            foreach (var item in a1.array) {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array size: " + (int)a1);
            Console.WriteLine(a2==a4);
            Console.WriteLine(a2==a3);
            Console.WriteLine(a1>a3);
            Console.WriteLine(a1.GetHashCode());

        }
    } // Program class end

} // namespace end

