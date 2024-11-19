namespace Products;

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
            return $"{Name} is broken!\n";
        }

        string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
        formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
        formattedOutput += $"\nHas Stylus support: {hasStylus}";
        return formattedOutput + '\n';

    }

}

