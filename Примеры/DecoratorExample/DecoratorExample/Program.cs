using DecoratorExample;

Pizza pizza1 = new ItalianPizza();
pizza1 = new TomatoPizza(pizza1);
pizza1 = new CheesePizza(pizza1);

Console.WriteLine(pizza1.Name);
Console.WriteLine(pizza1.GetCost());