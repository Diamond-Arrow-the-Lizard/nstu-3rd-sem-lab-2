using Custom_Array.SymbolChecker;
namespace SymbolChecker.tests;

public class SymbolChecker_Tests {

    [Theory]
    [InlineData('0')]
    [InlineData('1')]
    [InlineData('a')]
    [InlineData('Ф')]
    public void CheckingForSymbolInNewArray_Should_ReturnTrueIfFound(char value) {

        CustomArray arr = new CustomArray();
        if(arr.hasSymbol(value) == true)
            Assert.True(arr.hasSymbol(value));
        else
            Assert.False(arr.hasSymbol(value));

    } 

}
