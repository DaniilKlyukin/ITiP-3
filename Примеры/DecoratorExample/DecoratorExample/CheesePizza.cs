namespace DecoratorExample
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + " с сыром", pizza)
        {

        }

        public override double GetCost() => pizza.GetCost() + 5;
    }
}
