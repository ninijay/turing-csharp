using System.Collections.Generic;

namespace UniversalTuringMachine
{
    public class Tape
    {
        public List<char> Left { get; set; }
        public List<char> Right { get; set; }

        public void WriteOnTabe(char symbol)
        {
            if (Right.Count == 0)
            {
                Right.Insert(0, symbol);
            }
            else
            {
                Right[0] = symbol;
            }
        }

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