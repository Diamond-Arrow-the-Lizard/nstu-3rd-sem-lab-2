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

        public static bool operator !=(Array a, Array b) {
            if(a.array.Length != b.array.Length) return true;
            
            for(int i = 0; i < a.array.Length; i++) {
                if(a.array[i] != b.array[i]) return true;
            }

            return false;
        }

        public static bool operator ==(Array a, Array b) {
            if(a.array.Length != b.array.Length) return false;
            
            for(int i = 0; i < a.array.Length; i++) {
                if(a.array[i] != b.array[i]) return false;
            }

            return true;
        }

        public static bool operator <(Array a, Array b) {
            if(a.array.Length < b.array.Length) return true;
            return false;
        }

        public static bool operator >(Array a, Array b) {
            if(a.array.Length > b.array.Length) return true;
            return false;
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

        
        public static explicit operator int(Array a) {
            return a.array.Length;
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

    public static class NegativeNumberDeletor {

        public static Array deleteNegativeValues(this Array arr) {
                int[] newArray = arr.array;
                newArray = newArray.Where(val => val >= 0).ToArray();
                arr.array = newArray;
                return arr;
            }

    } // NegativeNumberDeletor extention end

    public class Program {

        public static void Main(string[] args) {

            Array a1 = new Array();

            Array a2 = new Array();
            a2.array = new int[]{1, 2, 3, 4, 5};

            Array a3 = new Array();
            a3.array = new int[]{-2, 3, 4, -5, 6};

            Array a4 = new Array();
            a4.array = new int[]{1, 2, 3, 4, 5};

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

