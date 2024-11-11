using System;

namespace lab2_part2 {

    public abstract class Product {

        protected string type {set; get;} = "None";

        public override abstract string ToString();

    }


    public class Tech : Product {

        protected string vendor {set; get;} = "None";
        protected string name {set; get;} = "None";
        protected int price {set; get;} = 0;

        public Tech() {

            type = "Tech";
        }

        public override string ToString() {

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            return formattedOutput;

        }

    }

    public class Computer: Tech {

        protected string CPU {set; get;} = "None";
        protected string GPU {set; get;} = "None";
        protected string OS {set; get;} = "None";

        public Computer() {

            type = "Computer";
        }

        public override string ToString() {

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
            return formattedOutput;

        }

    }

    public sealed class Tablet: Computer {

        bool hasStylus {set; get;} = false;

        public Tablet() {

            type = "Tablet";
        }

        public override string ToString() {

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
            formattedOutput += $"\nHas Stylus support: {hasStylus}";
            return formattedOutput;

        }

    }


    public class PrintingTool : Tech {

        protected bool isMulticolour {set; get;} = false;

        public PrintingTool() {

            type = "Printing Tool";
        }

        public override string ToString() {

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCan print multicolour: {isMulticolour}";
            return formattedOutput;

        }

    }

    public sealed class Scanner : PrintingTool {

        string scannerType {set; get;} = "None";

        public Scanner() {

            type = "Scanner";
        }

        public override string ToString() {

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCan print multicolour: {isMulticolour}";
            formattedOutput += $"\nScanner Type: {scannerType}";
            return formattedOutput;

        }

    }


    public class Program {

        public static void Main(string[] args) {

            Computer pc = new Computer();
            Tablet tab = new Tablet();
            Scanner scammer = new Scanner();

            Console.WriteLine($"{pc}\n\n{tab}\n\n{scammer}");


        }

    }

}
