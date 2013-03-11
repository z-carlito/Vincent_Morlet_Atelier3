using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atelierTroisLib
{
    public class Club
    {
        private readonly string name;

        public Club(string name)
        {
            this.name = name;
        }

        public new string ToString()
        {
            return "name :" + this.name;
        }
    }
}
