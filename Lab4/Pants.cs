namespace Lab4;
public class Pants : Clothing
{
    public string Size { get; set; }
    
    public override void GetDone()
    {
        Console.WriteLine("Put on the pants");
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