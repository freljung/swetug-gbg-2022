namespace Demo.NetAnalyzers;

public class IDE0017
{
    internal class ToBeDone
    {
        public bool Important { get; set; }
    }

    public void DoSomething()
    {
        // dotnet_style_object_initializer = true
        var todo = new ToBeDone { Important = false };

        // dotnet_style_object_initializer = false
        var importantTodo = new ToBeDone();
        importantTodo.Important = true;
    }
}
