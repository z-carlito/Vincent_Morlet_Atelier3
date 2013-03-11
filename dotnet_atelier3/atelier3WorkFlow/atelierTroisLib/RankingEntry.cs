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
            if (obj == null) return 1;

            var objRankingEntry = obj as RankingEntry;
            if (objRankingEntry != null)
                return this.points.CompareTo(objRankingEntry.points);
            else
                throw new ArgumentException("Object is not a RankingEntry");
        }
    }
}
