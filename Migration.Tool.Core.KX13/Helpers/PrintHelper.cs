namespace Migration.Tool.Core.KX13.Helpers;

public static class PrintHelper
{
    public static string PrintDictionary(Dictionary<string, object?> dictionary) =>
        string.Join(", ", dictionary.Select(x => $"{x.Key}:{x.Value ?? "<null>"}"));
}
