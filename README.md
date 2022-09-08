# Swetugg Göteborg 2022

This repository contains some code examples for the presentation [ANALYZE THIS: RAISE YOUR CODE QUALITY AND FOLLOW CODE STANDARDS WITH THE ROSLYN ANALYZERS](https://www.swetugg.se/gbg-2022/speakers/fredrik-ljung#analyze-this-raise-your-code-quality-and-follow-code-standards-with-the-roslyn-analyzers) at the [Swetugg Götebort 2022](https://www.swetugg.se/gbg-2022) conference (bold statement, since at time of writing it hasn't happened yet...).


## Activating the Roslyn anlyzers for .NET

the .NET analyzers are activated by default in .NET 5 and later.  To activate them for earlier versions add
```xml
<EnableNETAnalyzers>true</EnableNETAnalyzers>
```
to your projects csproj-file.


## Configuring the analyzers in csproj

By default there are only a few analyzers actively producing warnings. There are several that you can access in Visual Studio with through the ctrl + . hints. For example a [CA1822](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1822) doesn't show up as a warning but can be acted on via the hint.

![Hint when rule isn't producing a warning](images/ca1822-hint-when-no-warning.png)

What analyzers should produce warnings can be configured at a generic level by adding the ```<AnalysisLevel>``` tag to the csproj-file. The format for this is ```<level>-<mode>```. Level describes with version of .NET the analysis is at and is either ```latest```, ```preview``` or the .NET version, for instance ```5```. Mode is generic settings for which rules should produce warnings and is in increasing aggresive level ```None```, ```Default```, ```Minimum```, ```Recommended``` and ```All```. For example, to include all rules included in .NET 6 use
```xml
<AnalysisLevel>6-All</AnalysisLevel>
```

Once the above is added to the csproj-file the will instead produce an error [CA1822](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1822)

![CA1822 producing error when Analysis level is high enough](images/ca1822-when-warning-enabled.png)


### .NET 5

If building for .NET 5 the compounded notion above cannot be used, and the mode has to be declared in it's own element ```<AnalysisMode>```. If building with .NET 5 the above would instead be
```xml
<AnalysisLevel>5</AnalysisLevel>
<AnalysisMode>All</AnalysisMode>
```

