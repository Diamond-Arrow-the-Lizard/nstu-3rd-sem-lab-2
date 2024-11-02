using System;

namespace lab2_part2 {
    
    interface IProduct
    {
        
        virtual void PrintInfo() {

        }
        
    }


    public abstract class Tech : IProduct {

    }

    public sealed class Computer: Tech {

    }

    public sealed class Tablet: Tech {

    }


    public abstract class PrintingTool : Tech {

    }

    public sealed class Scanner : PrintingTool {

    }

    
    public class Program {

        public static void Main(string[] args) {
            
        }

    }

}
