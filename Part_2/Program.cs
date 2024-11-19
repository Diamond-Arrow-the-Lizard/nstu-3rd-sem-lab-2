using System;
using Products;

namespace lab2_part2 {



    public class Program {

        public static void Main(string[] args) {

            List<Tech> techList = new List<Tech>();

            Scanner scammer = new Scanner() {
                Vendor = "Ricoh",
                Name = "HP 150",
                Price = 2300000
            };

            Computer coolPC = new Computer() {
                Vendor = "DNS",
                Name = "Gaming PC",
                CPU = "AMD Ryzen",
                GPU = "AMD Radeon",
                OS = "Temple OS",
                Price = 4300000
            };

            Tablet iPad = new Tablet() {
                Vendor = "Apple",
                Name = "iPad",
                OS = "iOS",
                Price = 1000000000
            };

            techList.Add(scammer);
            techList.Add(coolPC);
            techList.Add(iPad);

            iPad.breakProduct();
            iPad.repairProduct();
            iPad.repairProduct();

            scammer.breakProduct();

            foreach(var i in techList)
                Console.WriteLine(i);

        }

    }

}
