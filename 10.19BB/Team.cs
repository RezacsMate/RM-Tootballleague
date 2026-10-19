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
            _name = name;
            _points = 0;
            _goalsFor = 0;
            _goalsAgainst = 0;
        }
    }
}
