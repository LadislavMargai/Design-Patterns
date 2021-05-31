using NUnit.Framework;

using DesignPatterns.Adapter;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class AdapterTests
    {
        private RoundHole hole;


        [SetUp]
        public void SetUp()
        {
            hole = new RoundHole(5);
        }

        [Test]
        public void SmallRoundPegFitsRoundHole()
        {
            var roundPeg = new RoundPeg(5);
            Assert.IsTrue(hole.Fits(roundPeg));
        }


        [Test]
        public void SmallSquarePegFitsRoundHoleWithAdapter()
        {
            var smallSquarePeg = new SquarePeg(5);
            var largeSquarePeg = new SquarePeg(10);
            // hole.Fits(smallSquarePeg) // This won't compile (incompatible types)

            var smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
            var largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);

            Assert.IsTrue(hole.Fits(smallSquarePegAdapter));
            Assert.IsFalse(hole.Fits(largeSquarePegAdapter));
        }
    }
}