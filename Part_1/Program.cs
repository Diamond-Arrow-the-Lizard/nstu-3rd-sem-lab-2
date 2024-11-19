using System;
using custom_array;
using custom_array.NegativeNumberDeleter;
using custom_array.SymbolChecker;

namespace lab2_part1 {

    public class Program {

        public static void Main(string[] args) {

            Array a1 = new Array();

            Array a2 = new Array();
            a2.array = new int[]{1, 2, 3, 4, 5};

            Array a3 = new Array();
            a3.array = new int[]{-2, 3, 4, -5, 6};

            Array a4 = new Array();
            a4.array = new int[]{1, 2, 3, 4, 5};
            a3.array = new int[]{-2, 3, -4, 5, 6};

            a1 = a2*a3; 

            foreach (var item in a1.array) {
                Console.WriteLine(item);
            }

            Console.WriteLine(a1.hasSymbol('6'));
            Console.WriteLine(a1.hasSymbol('4'));

            a1.deleteNegativeValues();

            foreach (var item in a1.array) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array size: " + (int)a1);
            Console.WriteLine(a2==a4);
            Console.WriteLine(a2==a3);
            Console.WriteLine(a1>a3);

        }
    } // Program class end

} // namespace end

