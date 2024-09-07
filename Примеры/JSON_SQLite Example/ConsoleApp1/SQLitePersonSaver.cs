// Класс для сохранения человека в БД SQLite
public class SQLitePersonSaver : IPersonSaver
{
    public void SavePerson(string dataBasePath, Person person)
    {
        using ApplicationDBContext db = new(dataBasePath);

        db.Persons.Add(person);

        db.SaveChanges();
    }
}