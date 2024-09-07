public interface IPersonLoader
{
    public Person? LoadByName(string dataBasePath, string name);
}