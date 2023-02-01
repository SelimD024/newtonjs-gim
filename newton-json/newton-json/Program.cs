using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

string jsonUrl = "D:\\xampp\\htdocs\\C# development\\newtonJS\\newton-json\\newton-json\\data.json";
string json = File.ReadAllText(jsonUrl);


var settings = new JsonSerializerSettings
    {

                
      NullValueHandling = NullValueHandling.Ignore,
             
    };


Root gimroot = JsonConvert.DeserializeObject<Root>(json, settings);

             





public class Child
{
    public string? Name { get; set; }
    public int? ID { get; set; }
    public int? Crud { get; set; }
    public int? ProjectID { get; set; }
    public Local? Local { get; set; }
}

public class Joint
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Parent { get; set; }
    public int Child { get; set; }
    public List<List<double>>? Origin { get; set; }
    public List<int>? Limit { get; set; }
    public int Crud { get; set; }
    public List<int>? Calibration { get; set; }
    public List<int>? Dynamics { get; set; }
    public int? Mimic_ID { get; set; }
    public int? Mimic_Multiplier { get; set; }
    public int? Mimic_Offset { get; set; }
}

public class Local
{
    public List<double>? XYZ { get; set; }
    public List<double>? RPY { get; set; }
    public int M { get; set; }
}

public class Root
{
    public string? Version { get; set; }
    public string? Name { get; set; }
    public object? ProjectID { get; set; }
    public string? GIMbin { get; set; }
    public string? GIMUnitCur { get; set; }
    public List<string>? GIMUnits { get; set; }
    public object? GIMscale { get; set; }
    public string? GLB { get; set; }
    public List<Child>? Children { get; set; }
    public List<Joint>? Joints { get; set; }
    public List<string>? GLBs { get; set; }
    public object? ObjectID { get; set; }
}

