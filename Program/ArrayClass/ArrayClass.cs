
namespace custom_array {

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

}
