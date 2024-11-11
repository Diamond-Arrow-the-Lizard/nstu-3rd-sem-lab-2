using System;

namespace lab2_part2 {
    
    public abstract class IProduct
    {
        protected string type {set; get;} = "Nan";
        
        
    }


    public class Tech : IProduct {

        protected string vendor {set; get;} = "None";
        protected string name {set; get;} = "None";
        protected int price {set; get;} = 0;

        public Tech() {

            type = "Technology";
        }

    }

    public class Computer: Tech {
        
        protected string CPU {set; get;} = "None";
        protected string GPU {set; get;} = "None";
        protected string OS {set; get;} = "None";

        public Computer() {

            type = "Computer";
        }

    }

    public sealed class Tablet: Computer {

        bool hasStylus {set; get;} = false;

        public Tablet() {

            type = "Tablet";
        }

    }


    public class PrintingTool : Tech {
        
        protected bool isMulticolour {set; get;} = false;

        public PrintingTool() {

            type = "Printing Tool";
        }

    }

    public sealed class Scanner : PrintingTool {

        string scannerType {set; get;} = "None";

        public Scanner() {

            type = "Scanner";
        }

    }

    
    public class Program {

        public static void Main(string[] args) {

            Computer pc = new Computer();
            Tablet tab = new Tablet();
            Scanner scammer = new Scanner();

            
        }

    }

}
