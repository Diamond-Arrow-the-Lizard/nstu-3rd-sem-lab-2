using custom_array;

namespace custom_array.NegativeNumberDeleter {

        public static class NegativeNumberDeleter {

        public static Array deleteNegativeValues(this Array arr) {
                int[] newArray = arr.array;
                newArray = newArray.Where(val => val >= 0).ToArray();
                arr.array = newArray;
                return arr;
            }

    } // NegativeNumberDeletor extention end


}
