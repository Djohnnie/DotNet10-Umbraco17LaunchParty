using System.Globalization;


var versions = new List<LanguageVersion>
{
    new LanguageVersion { CSharpVersion = "8.0" },
    new LanguageVersion { CSharpVersion = "9.0" },
    new LanguageVersion { CSharpVersion = "10.0" },
    new LanguageVersion { CSharpVersion = "11.0" },
    new LanguageVersion { CSharpVersion = "12.0" },
    new LanguageVersion { CSharpVersion = "13.0" },
    new LanguageVersion { CSharpVersion = "14.0" }
};

foreach (var version in versions.OrderBy(x => x.CSharpVersion))
{
    Console.WriteLine(version.CSharpVersion);
}

Console.WriteLine("-");

StringComparer numericStringComparer = StringComparer.Create(CultureInfo.CurrentCulture, CompareOptions.NumericOrdering);
foreach (var version in versions.OrderBy(x => x.CSharpVersion, numericStringComparer))
{
    Console.WriteLine(version.CSharpVersion);
}




class LanguageVersion
{
    public string CSharpVersion { get; set; }
}