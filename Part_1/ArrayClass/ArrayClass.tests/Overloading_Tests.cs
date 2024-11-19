namespace ArrayClass.tests;

public class ArrayClass_OverloadTests {
    
    [Fact]
    public void NewArrayMultiplication_Should_Succeed() {
        CustomArray a = new CustomArray();
        CustomArray b = new CustomArray();
        
        a.array[0] *= b.array[0];
    }

    [Fact]
    public void NewArray_Should_ReturnTrueIfEqual() {
        CustomArray a = new CustomArray();
        CustomArray b = new CustomArray();

        Assert.True(a == b);

    }

    [Fact]
    public void NewArray_Should_ReturnTrueIfNotEqual() {
        CustomArray a = new CustomArray();
        CustomArray b = new CustomArray();

        b.array[0] = 1;

        Assert.True(a != b);

    }

    [Fact]
    public void NewArray_Should_ReturnTrueIfOneGreaterOtherSmaller() {
        CustomArray a = new CustomArray();
        CustomArray b = new CustomArray();
        b.array = new int[2];

        Assert.True(b > a);
        Assert.True(a < b);

    }

    [Fact]
    public void NewArray_Should_ReturnTrueIfLenOfArrayIsCorrectlyGot() {
        CustomArray a = new CustomArray();

        int Length = 1;

        Assert.True( (int)a == Length );
    }

}
