using System;

namespace DesignPatterns.Adapter
{
    public class RoundHole
    {
        public int Radius { get; private set; }


        public RoundHole(int radius)
        {
            Radius = radius;
        }


        public bool Fits(RoundPeg roundPeg)
        {
            return Radius >= roundPeg.Radius;
        }
    }


    public class RoundPeg
    {
        public virtual int Radius { get; private set; }


        public RoundPeg(int radius)
        {
            Radius = radius;
        }
    }


    public class SquarePeg
    {
        public int Side { get; private set; }


        public SquarePeg(int side)
        {
            Side = side;
        }
    }


    /// <summary>
    /// An adapter class lets you fit square pegs into round holes.
    /// It extends the RoundPeg class to let the adapter objects act
    /// as round pegs.
    /// </summary>
    public class SquarePegAdapter : RoundPeg
    {
        /// <summary>
        /// In reality, the adapter contains an instance of the
        /// SquarePeg class.
        /// </summary>
        private SquarePeg squarePeg;


        /// <summary>
        /// The adapter pretends that it's a round peg with a
        /// radius that could fit the square peg that the adapter
        /// actually wraps.
        /// </summary>
        public override int Radius
        {
            get
            {
                return Convert.ToInt32(squarePeg.Side * Math.Sqrt(2) / 2);
            }
        }


        public SquarePegAdapter(SquarePeg squarePeg) : base(0)
        {
            this.squarePeg = squarePeg;
        }

    }
}
