namespace Demo.NetAnalyzers;

/// <summary>
/// <b>Configuration:</b> dotnet_code_quality_unused_parameters can be set to all or non_public in .editorconfig
/// </summary>
public class TestClass
{
    // IDE0060: Remove unused parameter
    // https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0060
    public int GetNum1(int unusedParam) { return 1; }
    internal int GetNum2(int unusedParam) { return 1; }
    private int GetNum3(int unusedParam) { return 1; }

    // dotnet_code_quality_unused_parameters = non_public
    internal int GetNum4(int unusedParam) { return 1; }
    private int GetNum5(int unusedParam) { return 1; }
}
