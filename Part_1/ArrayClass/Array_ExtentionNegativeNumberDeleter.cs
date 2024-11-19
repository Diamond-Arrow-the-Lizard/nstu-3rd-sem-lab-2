using Custom_Array;

namespace Custom_Array.NegativeNumberDeleter {

        public static class NegativeNumberDeleter {

        public static CustomArray deleteNegativeValues(this CustomArray arr) {
                int[] newArray = arr.array;
                newArray = newArray.Where(val => val >= 0).ToArray();
                arr.array = newArray;
                return arr;
            }

    } // NegativeNumberDeletor extention end


}
