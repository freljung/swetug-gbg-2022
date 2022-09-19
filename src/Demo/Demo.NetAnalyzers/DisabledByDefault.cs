using System;

namespace CA1008
{
    // CA1008: Enums should have zero value
    // https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1008

    public enum TraceLevel
    {
        //Off = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Verbose = 4
    }

    [Flags]
    public enum TraceOptions
    {
        None = 0,
        CallStack = 0x01,
        LogicalStack = 0x02,
        DateTime = 0x04,
        Timestamp = 0x08,
    }

    [Flags]
    public enum BadTraceOptions
    {
        CallStack = 0,
        LogicalStack = 0x01,
        DateTime = 0x02,
        Timestamp = 0x04,
    }

    /// <summary>
    /// <para>
    /// <b>Problem:</b> Default-value of uninitialized enum types is 0, not the first declared name.
    /// </para>
    /// 
    /// <para>
    /// <b>Solution:</b> Either extend with an new enum name, for example None and set it to 0, or set 
    /// the most commonly used name or most suitable default name to 0.
    /// </para>
    /// 
    /// <para>
    /// <b>Configuration:</b> By default the rule is only applied to externally visible enum types. It is configurable
    /// in .editorconfig via dotnet_code_quality.CA1012.api_surface = private, internal
    /// </para>
    /// </summary>
    class UseBadTraceOptions
    {
        static void MainTrace()
        {
            // Set the flags.
            BadTraceOptions badOptions =
               BadTraceOptions.LogicalStack | BadTraceOptions.Timestamp;

            // Check whether CallStack is set.
            if ((badOptions & BadTraceOptions.CallStack) ==
                BadTraceOptions.CallStack)
            {
                // This 'if' statement is always true.
            }
        }
    }
}
