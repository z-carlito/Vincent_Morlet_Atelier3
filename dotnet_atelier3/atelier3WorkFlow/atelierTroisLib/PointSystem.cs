using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atelierTroisLib
{
    public abstract class PointSystem
    {
        private ITotal initialPoints;

        public ITotal InitialPoints
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ITotal GetPointsFromMatch(Match m, bool isHome)
        {
            throw new System.NotImplementedException();
        }

        public interface ITotal : IComparable
        {
            void Increment(ITotal width);
            String ToString();

        }
    }

  
}
