using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace atelierTroisLib
{
    public class Match
    {
        private Club away;
        private int awayGoals;
        private Club home;
        private int homeGoals;
        private bool awayForfeit;
        private bool draw;
        private bool homeForfeit;
    
        public Match()
        {
            
        }

        public int HomeGoals
        {
            get { return homeGoals; }
        }

        public int AwayGoals
        {
            get { return awayGoals; }
        }

        public Club Away
        {
            get { return away; }
        }

        public Club Home
        {
            get { return home; }
        }

        public bool AwayForfeit
        {
            get { return awayForfeit; }
        }

        public bool Draw
        {
            get { return draw; }
        }

        public bool HomeForfeit
        {
            get { return homeForfeit; }
        }

        public int GetGoals(bool boolHome)
        {
            return boolHome ? this.homeGoals : this.awayGoals;
        }
    }
}
