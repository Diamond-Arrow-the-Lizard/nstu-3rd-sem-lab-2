using System;


namespace Lab2 {
    public class Array {

        private int[] _array;
        public int[] array {
            set {
                _array = value;
            } 
            get {
                return _array;
            } 
        }

        public Array() {

            _array = new int[] {0};
        }

        public static Array operator *(Array a, Array b) {
            Array c = new Array();
            c.array = new int[a.array.Length];
            for(int i = 0; i < a.array.Length; i++) {
                c.array[i] = a.array[i];
            }
            for (int i = 0;  i < a.array.Length; i++) { 
                c.array[i] = a.array[i] * b.array[i];
            }            
            return c;

        }

        public static bool operator false(Array a) {
            foreach(int item in a.array) {
                if(item < 0) {
                    return false;
                }
            }
            return true;
        }

        public static bool operator true(Array a) {
            foreach(int item in a.array) {
                if(item < 0) {
                    return false;
                }
            }
            return true;
        }


    } // Array class end

    public static class SymbolChecker {

        public static bool hasSymbol(this Array a, char symbol) {
            string arrayString = String.Join("", a.array);
            foreach (char item in arrayString) {
                if(item == symbol) 
                    return true;
            }
            return false;
        }


    } // SymbolChecker extention end

    public static class NegativeDeleter {

        public static Array deleteNegativeElements(this Array a) {
            List<int> positiveElements = new List<int>();
            foreach (int item in a.array) {
                if(item >= 0) {
                    positiveElements.Add(item);
                }
            }
            Console.WriteLine("Debug:\n");
            foreach (int item in positiveElements)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Debug end:");

            Array newArray = new Array();
            newArray.array = new int[positiveElements.Count];

            int i = 0;
            foreach(int item in positiveElements) {
                newArray.array[i] = item;
                ++i;
            }
            Console.WriteLine("Debug:\n");
            foreach (int item in newArray.array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Debug end:");
            return newArray;
        }


    } // NegativeDeleter extention end

    public class Program {

        public static void Main(string[] args) {

            Array a1 = new Array();

            Array a2 = new Array();
            a2.array = new int[]{1, 2, 3, 4, 5};

            Array a3 = new Array();
            a3.array = new int[]{-2, 3, -4, 5, 6};

            a1 = a2*a3; 

            foreach (var item in a1.array) {
                Console.WriteLine(item);
            }

            Console.WriteLine(a1.hasSymbol('6'));
            Console.WriteLine(a1.hasSymbol('4'));

            a1.deleteNegativeElements();
            foreach (var item in a1.array) {
                Console.WriteLine(item);
            }


        }

    } // Program class end

} // namespace end

