using System;

namespace lab2_part2 {

    public abstract class Product {

        public string Type {set; get;} = "None";

        private bool _is_broken = false;
        public bool isBroken {
            set {
                _is_broken = value;
            }

            get => _is_broken;

        }

        public override abstract string ToString();

        public abstract bool breakProduct();
        public abstract bool repairProduct();

    }


    public class Tech : Product {

        public string Vendor {set; get;} = "None";
        public string Name {set; get;} = "None";
        public int Price {set; get;} = 0;

        public Tech() {

            Type = "Tech";
        }

        public override bool breakProduct() {
            if(isBroken == true) { 
                Console.WriteLine("It's already broken!");
                return isBroken;
            }

            Console.WriteLine($"You broke {Name}. Here goes your {Price} rubles...");
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            if(isBroken == false) { 
                Console.WriteLine("It's fine, no need for a repair");
                return isBroken;
            }

            Console.WriteLine($"{Name} was repaired and is ready to work!");
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!\n";
            }

            string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
            return formattedOutput + '\n';

        }

    }

    public class Computer: Tech {

        public string CPU {set; get;} = "None";
        public string GPU {set; get;} = "None";
        public string OS {set; get;} = "None";

        public Computer() {

            Type = "Computer";
        }

        public override bool breakProduct() {
            if(isBroken == true) { 
                Console.WriteLine("It's already broken!");
                return isBroken;
            }

            Console.WriteLine($"You broke {Name}. All the money for {CPU} and {GPU} for nothing..."); 
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            if(isBroken == false) { 
                Console.WriteLine("It's fine, no need for a repair");
                return isBroken;
            }

            Console.WriteLine($"{Name} was repaired. It only cost you a kidney!");
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!\n";
            }

            string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
            formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
            return formattedOutput + '\n';

        }

    }

    public sealed class Tablet: Computer {

        private bool _has_stylus = false;
        bool hasStylus {
            set {
                _has_stylus = value;
            }
            get => _has_stylus;
        } 

        public Tablet() {

            Type = "Tablet";
        }

        public override bool breakProduct() {
            if(isBroken == true) { 
                Console.WriteLine("It's already broken!");
                return isBroken;
            }

            Console.WriteLine($"You broke {Name}. No more YouTube for you...");
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            if(isBroken == false) { 
                Console.WriteLine("It's fine, no need for a repair");
                return isBroken;
            }

            Console.WriteLine($"{Name} was repaired and is ready to destroy your eyesight...");
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!\n";
            }

            string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
            formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
            formattedOutput += $"\nHas Stylus support: {hasStylus}";
            return formattedOutput + '\n';

        }

    }


    public class PrintingTool : Tech {

        private bool _is_multicolour = false;
        public bool isMulticolour {
            set {
                _is_multicolour = value;
            } 
            get => _is_multicolour;
        } 

        public PrintingTool() {

            Type = "Printing Tool";
        }

        public override bool breakProduct() {
            if(isBroken == true) { 
                Console.WriteLine("It's already broken!");
                return isBroken;
            }

            if(isMulticolour == false) {
                Console.WriteLine($"You broke {Name}. Now you'll have to pay to print things...");
            } else {
                Console.WriteLine($"You broke {Name}. And it was multicolour! Repair will ruin you...");
            }

            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            if(isBroken == false) { 
                Console.WriteLine("It's fine, no need for a repair");
                return isBroken;
            }

            if(isMulticolour == false) {
                Console.WriteLine($"{Name} was repaired and is ready to print your papers...");
            } else {
                Console.WriteLine($"{Name} was repaired and is ready to pring your jpegs");
            }

            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!\n";
            }

            string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
            formattedOutput += $"\nCan print multicolour: {isMulticolour}";
            return formattedOutput + '\n';

        }

    }

    public sealed class Scanner : PrintingTool {

        string scannerType {set; get;} = "None";

        public Scanner() {

            Type = "Scanner";
        }

        public override bool breakProduct() {
            if(isBroken == true) { 
                Console.WriteLine("It's already broken!");
                return isBroken;
            }

            Console.WriteLine($"You broke {Name}. Here goes your {Price}...");
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            if(isBroken == false) { 
                Console.WriteLine("It's fine, no need for a repair");
                return isBroken;
            }

            Console.WriteLine($"{Name} was repaired and is ready to work");
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!\n";
            }

            string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
            formattedOutput += $"\nCan print multicolour: {isMulticolour}";
            formattedOutput += $"\nScanner Type: {scannerType}";
            return formattedOutput + '\n';

        }

    }


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
                CPU = "AMD",
                GPU = "AMD Radeon",
                OS = "Debian 12",
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

            coolPC.breakProduct();

            foreach(var i in techList)
                Console.WriteLine(i);

        }

    }

}
