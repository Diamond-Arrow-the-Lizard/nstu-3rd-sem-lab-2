using System;

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

        public override int GetHashCode() {
            return HashCode.Combine(this.array);
        }

        public string getAsString() {
            return Convert.ToString(this.array);
        }

        public static CustomArray operator *(CustomArray a, CustomArray b) {
            if(a.array == null || b.array == null) {
                Console.WriteLine("ERROR: Array null value met. Returning null.");
                    return null;
            }

            CustomArray c = a;
            if (a.array.Length != b.array.Length) {
                Console.WriteLine("WARNING: Arrays' lengths do not match.");
            }
            int ArrayLength = Math.Max(a.array.Length, b.array.Length);
            for (int i = 0;  i < ArrayLength; i++) { 
                c.array[i] = a.array[i] * b.array[i];
            }            
            return c;

        }

        public static bool operator !=(CustomArray a, CustomArray b) {
            if(a.GetHashCode() != b.GetHashCode()) return true;
            else if (a.array.Length != b.array.Length) return true;
            else return false;
        }

        public static bool operator ==(CustomArray a, CustomArray b) {
            if(a.GetHashCode() == b.GetHashCode()) return true;
            else if (a.array.Length == b.array.Length) return true;
            else return false;
        }

        public bool Equals(CustomArray b) {
            if(this.GetHashCode() == b.GetHashCode()) return true;
            else if (this.array.Length == b.array.Length) return true;
            else return false;
        }

        public static bool operator <(CustomArray a, CustomArray b) {
            if(a.array.Length < b.array.Length) return true;
            else return false;
        }

        public static bool operator >(CustomArray a, CustomArray b) {
            if(a.array.Length > b.array.Length) return true;
            else return false;
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
