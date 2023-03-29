namespace Lab4;
public class Shirt : Clothing
{
    public string Size { get; set; }
    public override string ToString()
    { 
        return $"{base.ToString()} {Size}";
    }
    public override void GetDone()
    {
        Console.WriteLine("Button up the shirt");
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Size);
    }
}