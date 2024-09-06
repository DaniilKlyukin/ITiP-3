namespace DecoratorExample
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + " с томатами", pizza)
        {

        }

        public override double GetCost() => pizza.GetCost() + 3;
    }
}
