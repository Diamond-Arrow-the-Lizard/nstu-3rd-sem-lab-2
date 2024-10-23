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
/*
        public static bool operator ==(Array a, Array b) {
            
        }

*/

    } // Array class end

    public class Program {

        public static void Main(string[] args) {

            Array a1 = new Array();

            Array a2 = new Array();
            a2.array = new int[]{1, 2, 3, 4, 5};

            Array a3 = new Array();
            a3.array = new int[]{2, 3, 4, 5, 6};

            a1 = a2*a3; 

            foreach (var item in a1.array) {
                Console.WriteLine(item);
            }

        }

    } // Program class end

} // namespace end

