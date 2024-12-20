using Custom_Array;

namespace Custom_Array.SymbolChecker {

    public static class SymbolChecker {

        public static bool hasSymbol(this CustomArray a, char symbol) {
            string arrayString = a.getAsString();
            foreach (char item in arrayString) {
                if(item == symbol) 
                    return true;
            }
            return false;
        }


    } // SymbolChecker extention end

}
