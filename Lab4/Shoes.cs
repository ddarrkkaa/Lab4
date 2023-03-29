namespace Lab4;
public class Shoes : Clothing
{
    public string Size { get; set; }
    
    public override void GetDone()
    {
        Console.WriteLine("Tie the shoes");
    }
    public override string ToString()
    {
        return $"{base.ToString()} {Size}";
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), Size);
    }
}