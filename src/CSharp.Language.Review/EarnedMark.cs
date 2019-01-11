using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Language.Review
{
    public class EarnedMark : WeightedMark
    {
        public int Possible { get; private set; }
        private double _earned;
        public double Earned
        {
            get { return _earned; }
            set
            {
                if (value < 0 || value > Possible)
                    throw new Exception("Invalid earned mark assigned");
                _earned = value;
            }
        }

        public double Percent
        { get { return (Earned / Possible) * 100; } }

        public double WeightedPercent
        { get { return Percent * Weight / 100; } }

        //calls another constructor before it runs the body of the method

        //connecting / hooking up constructors like this is called daisy chaining your constructor calls
        public EarnedMark(WeightedMark markableItem, int possible, double earned)
            : this(markableItem.Name, markableItem.Weight, possible, earned)
        {

        }


        public EarnedMark(string name, int weight, int possible, double earned)
            : base(name, weight)
        {
            if (possible <= 0) throw new Exception("Invalid possible marks");
            Possible = possible;
            Earned = earned;

        }
        public override string ToString()
        {
            return String.Format("{0} ({1})\t - {2}% ({3}/{4}) \t Weighted Mark {5}%", Name, Weight, Percent, Earned, Possible, WeightedPercent);
        }
    }
}
// base is what youre inhariting from
// this is where youre working in