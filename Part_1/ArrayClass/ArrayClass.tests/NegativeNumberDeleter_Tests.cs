using Custom_Array.NegativeNumberDeleter;

namespace NegativeNumberDeleter.tests {

    public class NegativeNumberDeleter_Tests {

        [Fact]
        public void ArrayWithAllNegatives_Should_ReturnTrueIfEmpty() {

            CustomArray arr = new CustomArray();
            arr.array = new int[]{-1, -2, -3, -4, -5};

            arr.deleteNegativeValues();

            Assert.True((int)arr == 0);
        }

        [Fact]
        public void ArrayWithAllPositives_Should_ReturnTrueIfNotChanged() {

            CustomArray arr = new CustomArray();
            arr.array = new int[]{1, 2, 3, 4, 5};

            CustomArray arrClone = arr;

            arr.deleteNegativeValues();

            Assert.True(arr == arrClone);

        }

    }
}
