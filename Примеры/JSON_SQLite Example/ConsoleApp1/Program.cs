using ConsoleApp1;

var person = new Person(default, "Vladimir", 50, 2000);

// JSON

var jsonSaver = new JsonPersonSaver();

jsonSaver.SavePerson("data.json", person);

var jsonLoader = new JsonPersonLoader();

jsonLoader.LoadByName("data.json", "Ivan");

// SQL

var sqlSaver = new SQLitePersonSaver();

sqlSaver.SavePerson("data.db", person);

var sqlLoader = new SQLitePersonLoader();

sqlLoader.LoadByName("data.db", "Ivan");