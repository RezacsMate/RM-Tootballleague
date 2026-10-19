using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._19BB
{
    public class Team
    {
        private string _name;
        private int _points;
        private int _goalsFor;
        private int _goalsAgainst;
        public string Name { get { return _name;} set { _name = value; } }
        public int Points { get { return _points; } set { _points = value; } }
        public int GoalsFor { get { return _goalsFor; } set { _goalsFor = value; } }
        public int GoalsAgainst { get { return _goalsAgainst; } set { _goalsAgainst = value; } }
        public Team(string name )
        {
            Name = name;
            Points = 0;
            GoalsFor = 0;
            GoalsAgainst = 0;
        }
        public void AddResult(int kapott, int lott)
        {
            GoalsFor = lott;
            GoalsAgainst = kapott;
            if(GoalsAgainst < GoalsFor)
            {
                _points += 3;
            }
            else if (GoalsAgainst > GoalsFor)
            {
                _points += 0;
            }
            else
            {
                _points += 0;
            }

        }
        public int GoalDifference()
        {
            if(GoalsFor > GoalsAgainst)
            {
                return GoalsFor - GoalsAgainst;
            }
            else if(GoalsFor < GoalsAgainst)
            {
                return GoalsAgainst - GoalsFor;
            }
            else
            {
                return 0;
            }
        }
    }
}
