using System;

namespace lab2_part2 {
    
    public abstract class IProduct
    {
        
        public virtual void PrintInfo() {

            Console.WriteLine("Default info");
        }
        
    }


    public class Tech : IProduct {

        protected string vendor {set; get;} = "None";
        protected string name {set; get;} = "None";
        protected int price {set; get;} = 0;

        public override void PrintInfo() {
            
            Console.WriteLine("Vendor: {0}\nName: {1}\nPrice: {2}",
                    vendor, name, price);
        }

    }

    public class Computer: Tech {
        
        protected string CPU {set; get;} = "None";
        protected string GPU {set; get;} = "None";
        protected string OS {set; get;} = "None";

        public new void PrintInfo() {
             
            base.PrintInfo();
            Console.WriteLine("CPU: {0}\nGPU: {1}\nOS: {2}",
                    CPU, GPU, OS);
        }

    }

    public sealed class Tablet: Computer {

        bool hasStylus {set; get;} = false;

        public new void PrintInfo() {

            base.PrintInfo();
            Console.WriteLine("Has Stylus: {0}", hasStylus);
        }


    }


    public class PrintingTool : Tech {
        
        protected bool isMulticolour {set; get;} = false;

        public new void PrintInfo() {
            
            base.PrintInfo();
            Console.WriteLine("Supports multicolour: {0}", isMulticolour);

        }

    }

    public sealed class Scanner : PrintingTool {

        string scannerType {set; get;} = "None";

        public new void PrintInfo() {

            base.PrintInfo();
            Console.WriteLine("Scanner Type: {0}", scannerType);
        }

    }

    
    public class Program {

        public static void Main(string[] args) {

            Computer pc = new Computer();
            Tablet tab = new Tablet();
            Scanner scammer = new Scanner();

            pc.PrintInfo();
            Console.Write('\n');

            tab.PrintInfo();
            Console.Write('\n');

            scammer.PrintInfo();
            Console.Write('\n');
            
        }

    }

}
