
// Newtonsoft/JsonFileUtils.cs
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public static class JsonFileUtils
{
    private static readonly JsonSerializerSettings _options
        = new() { NullValueHandling = NullValueHandling.Ignore };
    
    public static void SimpleWrite(object obj, string fileName)
    {
        var jsonString = JsonConvert.SerializeObject(obj, _options);
        File.WriteAllText(fileName, jsonString);
    }

    public static void PrettyWrite(object obj, string fileName)
{
    var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented, _options);
    File.WriteAllText(fileName, jsonString);
}
}