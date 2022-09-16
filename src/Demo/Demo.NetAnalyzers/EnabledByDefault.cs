namespace Demo.NetAnalyzers;

public class EnabledByDefault
{
    public void DoNotUseReferenceEquals()
    {
        int int1 = 1;
        int int2 = 1;

        // Violation occurs, returns false.
        Console.WriteLine(Object.ReferenceEquals(int1, int2));  // false

        // Use appropriate equality operator or method instead
        Console.WriteLine(int1 == int2);                        // true
        Console.WriteLine(object.Equals(int1, int2));           // true
    }
}
