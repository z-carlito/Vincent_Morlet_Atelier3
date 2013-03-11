using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atelierTroisLib
{
    public class Singleton
    {
        private static Singleton instance;

        private PointSystem pointSystem;

        internal Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public PointSystem PointSystem
        {
            get { return pointSystem; }
            set { pointSystem = value; }
        }
    }
 
}
