namespace Products;

public class Computer: Tech {

    public string CPU {set; get;} = "None";
    public string GPU {set; get;} = "None";
    public string OS {set; get;} = "None";

    public Computer() {

        Type = "Computer";
    }

    public override bool breakProduct() {
        if(isBroken == true) { 
            Console.WriteLine("It's already broken!");
            return isBroken;
        }

        Console.WriteLine($"You broke {Name}. All the money for {CPU} and {GPU} for nothing..."); 
        isBroken = true;
        return isBroken;
    }

    public override bool repairProduct() {
        if(isBroken == false) { 
            Console.WriteLine("It's fine, no need for a repair");
            return isBroken;
        }

        Console.WriteLine($"{Name} was repaired. It only cost you a kidney!");
        isBroken = false;
        return isBroken;
    }

    public override string ToString() {
        if (isBroken == true) {
            return $"{Name} is broken!\n";
        }

        string formattedOutput = $"Product Type: {Type}\nVendor: {Vendor}\nProduct Name: {Name}\nPrice: {Price}";
        formattedOutput += $"\nCPU: {CPU}\nGPU: {GPU}\nOS: {OS}";
        return formattedOutput + '\n';

    }

}
