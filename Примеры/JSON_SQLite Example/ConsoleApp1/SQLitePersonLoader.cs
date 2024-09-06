public class SQLitePersonLoader : IPersonLoader
{
    public Person? LoadByName(string dataBasePath, string name)
    {
        using ApplicationDBContext db = new(dataBasePath);

        return db.Persons.SingleOrDefault(p => p.Name == name);
    }
}