
namespace Custom_Array {

    public class CustomArray {

        private int[] _array;
        public int[] array {
            set {
                _array = value;
            } 
            get {
                return _array;
            } 
        }

        public CustomArray() {

            _array = new int[] {0};
        }

        public static CustomArray operator *(CustomArray a, CustomArray b) {
            CustomArray c = new CustomArray();
            c.array = new int[a.array.Length];
            for(int i = 0; i < a.array.Length; i++) {
                c.array[i] = a.array[i];
            }
            for (int i = 0;  i < a.array.Length; i++) { 
                c.array[i] = a.array[i] * b.array[i];
            }            
            return c;

        }

        public static bool operator !=(CustomArray a, CustomArray b) {
            if(a.array.Length != b.array.Length) return true;
            
            for(int i = 0; i < a.array.Length; i++) {
                if(a.array[i] != b.array[i]) return true;
            }

            return false;
        }

        public static bool operator ==(CustomArray a, CustomArray b) {
            if(a.array.Length != b.array.Length) return false;
            
            for(int i = 0; i < a.array.Length; i++) {
                if(a.array[i] != b.array[i]) return false;
            }

            return true;
        }

        public static bool operator <(CustomArray a, CustomArray b) {
            if(a.array.Length < b.array.Length) return true;
            return false;
        }

        public static bool operator >(CustomArray a, CustomArray b) {
            if(a.array.Length > b.array.Length) return true;
            return false;
        }

        public static bool operator false(CustomArray a) {
            foreach(int item in a.array) {
                if(item < 0) {
                    return false;
                }
            }
            return true;
        }

        public static bool operator true(CustomArray a) {
            foreach(int item in a.array) {
                if(item < 0) {
                    return false;
                }
            }
            return true;
        }

        
        public static explicit operator int(CustomArray a) {
            return a.array.Length;
        }


    } // CustomArray class end

}
