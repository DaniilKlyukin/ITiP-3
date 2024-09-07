namespace UnitTestsExample
{
    public class IntegerEquationSolver
    {
        public List<int> GetRootsOnInterval(int from, int to, Func<double, double> function)
        {
            var roots = new List<int>();

            for (int x = from; x <= to; x++)
            {
                if (Math.Abs(function(x)) <= 1e-12)
                    roots.Add(x);
            }

            return roots;
        }
    }
}
