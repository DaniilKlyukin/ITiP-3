using Newtonsoft.Json.Linq;

public class JsonPersonLoader : IPersonLoader
{
    public Person? LoadByName(string dataBasePath, string name)
    {
        var data = File.ReadAllText(dataBasePath);
        var jsonArray = JArray.Parse(data);

        foreach (var item in jsonArray)
        {
            var tokenName = item.Value<string>("Name");

            if (tokenName == name)
            {
                var tokenAge = item.Value<int>("Age");
                var tokenMoney = item.Value<double>("Money");

                return new Person(default, tokenName, tokenAge, tokenMoney);
            }
        }

        return null;
    }
}
