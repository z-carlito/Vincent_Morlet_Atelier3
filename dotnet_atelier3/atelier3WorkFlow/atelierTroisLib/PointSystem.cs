using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atelierTroisLib
{
    public abstract class PointSystem
    {
        private ITotal initialPoints;

        public virtual ITotal InitialPoints
        {
            get { return initialPoints; }
            set { initialPoints = value; }
        }


        public virtual ITotal GetPointsFromMatch(Match m, bool isHome)
        {

            ITotal result = null;
            result.Increment(isHome ? m.HomeGoals : m.AwayGoals);

            return result;
        }

        public interface ITotal : IComparable
        {
            void Increment(ITotal width);
            String ToString();


            void Increment(int p);
        }
    }

  
}
