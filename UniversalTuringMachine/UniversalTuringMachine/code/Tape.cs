using System.Collections.Generic;

namespace UniversalTuringMachine
{
    public class Tape
    {
        public List<char> Left { get; set; }
        public List<char> Right { get; set; }

        public string LeftFromHead()
        {
            return string.Join(",", Left);
        }

        public string RightFromHead()
        {
            return string.Join(",", Right);
        }
    }
}