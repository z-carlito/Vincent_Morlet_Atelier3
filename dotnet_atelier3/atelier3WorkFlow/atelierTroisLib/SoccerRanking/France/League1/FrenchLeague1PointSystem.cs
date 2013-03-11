using System;

namespace atelierTroisLib.SoccerRanking.France.League1
{
    class FrenchLeague1PointSystem : PointSystem
    {
        private static readonly Singleton instance = new Singleton();
        private ITotal initialPoints ;


        public new ITotal InitialPoints
        {
            get { return initialPoints; }
        }

        public new ITotal GetPointsFromMatch(Match m, bool isHome)
        {
            return base.GetPointsFromMatch(m, isHome);
        }


        public class PointTotal : ITotal
        {

            private int goalaverage;
            private int points;
          
            void ITotal.Increment(ITotal width)
            {
                this.points += ((PointTotal)width).points;
            }

            string ITotal.ToString()
            {
                return  "name :" + this.name;
            }

            void ITotal.Increment(int p)
            {
                points += p;
            }

            int IComparable.CompareTo(object obj)
            {
                if (obj == null) return 1;

                var objPtTotal = obj as PointTotal;
                if (objPtTotal != null)
                    return this.points.CompareTo(objPtTotal.points);
                else
                    throw new ArgumentException("Object is not a PointTotal");
            }
                   
        }
    }
}
