namespace Products;

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
