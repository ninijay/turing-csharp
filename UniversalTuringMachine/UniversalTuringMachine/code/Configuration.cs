using System.Collections.Generic;

namespace UniversalTuringMachine
{
    public class Configuration
    {
        public State Q { get; set; }
        public List<char> U { get; set; } // links des Kopfes
        public List<char> V { get; set; } // Wort ab aktueller Position

        public Configuration(State q, List<char> u, List<char> v)
        {
            Q = q;
            U = u;
            V = v;
        }

        public override string ToString()
        {
            return "State: " + Q.ToString() + " left: " + U.ToString() + " right: " + V.ToString();
        }
    }
}