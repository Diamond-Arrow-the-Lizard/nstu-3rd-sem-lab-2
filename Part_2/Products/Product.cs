namespace Products;

public abstract class Product {

    public string Type {set; get;} = "None";

    private bool _is_broken = false;
    public bool isBroken {
        set {
            _is_broken = value;
        }

        get => _is_broken;

    }

    public override abstract string ToString();

    public abstract bool breakProduct();
    public abstract bool repairProduct();

}

