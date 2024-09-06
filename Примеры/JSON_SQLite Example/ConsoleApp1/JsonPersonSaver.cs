using Newtonsoft.Json.Linq;

public class JsonPersonSaver : IPersonSaver
{
    public void SavePerson(string dataBasePath, Person person)
    {
        var json = File.ReadAllText(dataBasePath);
        var jArr = JArray.Parse(json);

        var jsonPerson = new JObject();
        jsonPerson["Name"] = person.Name;
        jsonPerson["Age"] = person.Age;
        jsonPerson["Money"] = person.Money;

        jArr.Add(jsonPerson);
        File.WriteAllText(dataBasePath, jArr.ToString());
    }
}