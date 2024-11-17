using System;

namespace lab2_part2 {

    public abstract class Product {

        protected string type {set; get;} = "None";

        private bool _is_broken = false;
        protected bool isBroken {
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

        protected string vendor {set; get;} = "None";
        protected string name {set; get;} = "None";
        protected int price {set; get;} = 0;

        public Tech() {

            type = "Tech";
        }

        public override bool breakProduct() {
            Console.WriteLine($"You broke {name}. Here goes your {price} rubles...");
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            Console.WriteLine($"{name} was repaired and is ready to wo...");;
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!";
            }

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

        public override bool breakProduct() {
            Console.WriteLine($"You broke {name}. All the money for {CPU} and {GPU} for nothing...");; 
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            Console.WriteLine($"{name} was repaired. It only cost you a kidn...");;
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!";
            }

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
            return formattedOutput;

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

            type = "Tablet";
        }

        public override bool breakProduct() {
            Console.WriteLine($"You broke {name}. No more YouTube for you...");
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            Console.WriteLine($"{name} was repaired and is ready to destroy your eyesig...");;
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!";
            }

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
            formattedOutput += $"\nHas Stylus support: {hasStylus}";
            return formattedOutput;

        }

    }


    public class PrintingTool : Tech {
        
        private bool _is_multicolour = false;
        protected bool isMulticolour {
            set {
                _is_multicolour = value;
            } 
            get => _is_multicolour;
        } 

        public PrintingTool() {

            type = "Printing Tool";
        }

        public override bool breakProduct() {
            if(isMulticolour == false) {
                Console.WriteLine($"You broke {name}. Now you'll have to pay to print things...");
            } else {
                Console.WriteLine($"You broke {name}. And it was multicolour! Repair will ruin you...");
            }

            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            if(isMulticolour == false) {
                Console.WriteLine($"{name} was repaired and is ready to print your pape...");;
            } else {
                Console.WriteLine($"{name} was repaired and is ready to pring your jpe...");;
            }

            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!";
            }

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

        public override bool breakProduct() {
            Console.WriteLine($"You broke {name}. Here goes your {price}...");;
            isBroken = true;
            return isBroken;
        }

        public override bool repairProduct() {
            Console.WriteLine($"{name} was repaired and is ready to wo...");;;
            isBroken = false;
            return isBroken;
        }

        public override string ToString() {
            if (isBroken == true) {
                return "It's broken!";
            }

            string formattedOutput = $"Product type: {type}\nVendor: {vendor}\nProduct name: {name}\nPrice: {price}";
            formattedOutput += $"\nCan print multicolour: {isMulticolour}";
            formattedOutput += $"\nScanner Type: {scannerType}";
            return formattedOutput;

        }

    }


    public class Program {

        public static void Main(string[] args) {

        List<Tech> techList = new List<Tech>();


        }

    }

}
