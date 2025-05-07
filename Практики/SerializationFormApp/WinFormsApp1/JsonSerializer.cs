using System.Text;

namespace WinFormsApp1;

public static class JsonSerializer
{
    public static string Serialize(object obj)
    {
        var type = obj.GetType();
        var properties = type.GetProperties();
        var jsonBuilder = new StringBuilder();

        jsonBuilder.AppendLine("{");

        var i = 0;
        foreach (var property in properties)
        {
            var value = property.GetValue(obj);
            jsonBuilder.Append($"\"{property.Name}\": \"{value}\"");

            if (i < properties.Length - 1)
                jsonBuilder.AppendLine(",");

            i++;
        }

        // Удаляем последнюю запятую
        if (jsonBuilder.Length > 1)
            jsonBuilder.Length--;

        jsonBuilder.AppendLine();
        jsonBuilder.AppendLine("}");
        return jsonBuilder.ToString();
    }
}