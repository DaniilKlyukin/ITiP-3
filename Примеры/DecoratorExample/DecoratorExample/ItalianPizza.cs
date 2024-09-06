namespace DecoratorExample
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        {

        }

        public override double GetCost() => 10;
    }
}
