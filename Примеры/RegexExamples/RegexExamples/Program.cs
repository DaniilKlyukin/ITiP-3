using System.Text.RegularExpressions;

string str = " Почта: 213@mail.ru abc@@mail.ru qwe@mail,ru ooo@mail.com ";
Regex regex = new Regex(@"\w+@mail\.ru");
var result = regex.Replace(str, "ok");
Console.WriteLine(result);

//foreach (Match match in result)
 //   Console.WriteLine(match);