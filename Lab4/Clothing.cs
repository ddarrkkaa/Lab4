namespace Lab4;

public class Clothing
{
    public string Brand { get; set; }
    public string Color { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Clothing clothing = (Clothing)obj;
        return Brand == clothing.Brand &&
               Color == clothing.Color;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Brand, Color);
    }
    public override string ToString()
    {
        return $"{Color}, {Brand}";
    }
    public virtual void GetDone()
    {
        Console.WriteLine("Zip up the cloth");
    }
    public void GetDressed(int num)
    {
        Jacket jacket = new Jacket();
        Shirt shirt = new Shirt();
        Shoes shoes = new Shoes();
        Pants pants = new Pants();

        if (num == 1)
        {
            jacket.Color = "green";
            jacket.HasHood = true;
            Console.WriteLine("jacket is picked");
            Console.WriteLine(jacket.ToString());
            jacket.GetDone();
            Console.WriteLine(jacket.GetHashCode());
            Console.WriteLine(jacket.Equals(shirt));
        }
        else if (num == 2)
        {
            shirt.Color = "white";
            shirt.Brand = "zara";
            shirt.Size = "S";
            Console.WriteLine("shirt is picked");
            Console.WriteLine(shirt.ToString());
            shirt.GetDone();
            Console.WriteLine(shirt.GetHashCode());
        }
        else if (num == 3)
        {
            shoes.Size = "39";
            shoes.Color = "black";
            Console.WriteLine("shoes are picked");
            Console.WriteLine(shoes.ToString());
            shoes.GetDone();
            Console.WriteLine(shoes.GetHashCode());
        }
        else if (num == 4)
        {
            pants.Brand = "nike";
            pants.Color = "yellow";
            Console.WriteLine("pants are picked");
            Console.WriteLine(pants.ToString());
            pants.GetDone();
            Console.WriteLine(pants.GetHashCode());
        }
    }
}