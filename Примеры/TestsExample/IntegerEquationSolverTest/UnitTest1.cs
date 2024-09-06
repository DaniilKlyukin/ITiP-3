namespace IntegerEquationSolverTest
{
    public class Tests
    {
        IntegerEquationSolver solver;

        [SetUp]
        public void Setup()
        {
            solver = new IntegerEquationSolver();
        }

        [Test]
        public void OneZeroRoot()
        {
            var roots = solver.GetRootsOnInterval(-10, 10, (x) => x * x);

            Assert.AreEqual(1, roots.Count);
            Assert.AreEqual(0, roots.First());
        }


        [TestCase(-2, 2, 0)]
        [TestCase(-4, 0, 1)]
        [TestCase(0, 4, 1)]
        [TestCase(-4, 4, 2)]
        public void RootsCount(int from, int to, int expectedRootsCount)
        {
            var roots = solver.GetRootsOnInterval(from, to, (x) => x * x - 9);

            Assert.AreEqual(expectedRootsCount, roots.Count);
        }

        [TestCase(-4, 0, new int[] { -3 }, TestName = "Root -3")]
        [TestCase(0, 4, new int[] { 3 }, TestName = "Root 3")]
        [TestCase(-4, 4, new int[] { -3, 3 }, TestName = "Roots -3 3")]
        public void RootsValues(int from, int to, int[] expectedRoots)
        {
            var roots = solver.GetRootsOnInterval(from, to, (x) => x * x - 9);

            CollectionAssert.AreEquivalent(expectedRoots, roots.ToArray());
        }

        [TestCase(-4, -3, new int[] { -3 }, TestName = "Boundary Root -3")]
        [TestCase(3, 4, new int[] { 3 }, TestName = "Boundary Root 3")]
        public void BoundaryRootsValues(int from, int to, int[] expectedRoots)
        {
            var roots = solver.GetRootsOnInterval(from, to, (x) => x * x - 9);

            CollectionAssert.AreEquivalent(expectedRoots, roots.ToArray());
        }
    }
}