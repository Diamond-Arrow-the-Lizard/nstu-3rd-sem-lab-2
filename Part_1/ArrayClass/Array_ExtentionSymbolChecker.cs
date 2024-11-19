using custom_array;

namespace custom_array.SymbolChecker {

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

}
