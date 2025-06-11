// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello, World! {DateTime.Now:MMMM dd, yyyy}");

static IEnumerable<string> ReadFrom(string file)
{
    string? line;
    using (var reader = File.OpenText(file))
    {
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
    }
}

var lines = ReadFrom("sampleQuotes.txt");
foreach (var line in lines)
{
    Console.WriteLine(line);
}