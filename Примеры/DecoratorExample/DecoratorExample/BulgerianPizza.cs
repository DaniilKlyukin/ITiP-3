namespace DecoratorExample
{
    public class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Болгарская пицца")
        {

        }

        public override double GetCost() => 8;
    }
}
