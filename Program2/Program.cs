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

    public sealed class Computer: Tech {
        
        string CPU {set; get;} = "None";
        string GPU {set; get;} = "None";
        string OS {set; get;} = "None";

        public new void PrintInfo() {
             
            base.PrintInfo();
            Console.WriteLine("CPU: {0}\nGPU: {1}\nOS: {2}",
                    CPU, GPU, OS);
        }

    }

    public sealed class Tablet: Tech {

        public new void PrintInfo() {

        }

    }


    public abstract class PrintingTool : Tech {

        public new void PrintInfo() {

        }
    }

    public sealed class Scanner : PrintingTool {

    }

    
    public class Program {

        public static void Main(string[] args) {

            Computer pc = new Computer();

            pc.PrintInfo();
            
        }

    }

}
