using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atelierTroisLib
{
    public class RankingEntry : IComparable
    {
        private Club club;
        private PointSystem.ITotal points;
    
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
