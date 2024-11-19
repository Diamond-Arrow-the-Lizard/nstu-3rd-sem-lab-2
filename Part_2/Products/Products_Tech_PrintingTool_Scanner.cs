namespace Products;

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
            return $"{Name} is broken!\n";
        }

        string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
        formattedOutput += $"\nCan print multicolour: {isMulticolour}";
        formattedOutput += $"\nScanner Type: {scannerType}";
        return formattedOutput + '\n';

    }

}


