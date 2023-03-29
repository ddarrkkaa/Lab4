namespace Lab4;
public class Jacket: Clothing
{
    public bool HasHood { get; set; }
    public override string ToString()
    {
        string hasHoodString = HasHood ? "with hood" : "without hood"; 
        return $"{base.ToString()} {hasHoodString}";
    }
    public override void GetDone()
    {
        Console.WriteLine("Zip up the jacket");
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), HasHood);
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Jacket jacket = (Jacket)obj; 
        return HasHood == jacket.HasHood; 
    }
} 
