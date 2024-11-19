namespace Products;

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
            return $"{Name} is broken!\n";
        }

        string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
        formattedOutput += $"\nCan print multicolour: {isMulticolour}";
        return formattedOutput + '\n';

    }

}


