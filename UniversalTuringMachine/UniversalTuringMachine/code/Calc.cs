namespace UniversalTuringMachine
{
    public class Calc{
        public State Current { get; set; }
        public State Next { get; set; }
        public int Direction { get; set; } // -1 left, 1 right, 0 stay
        public char Read { get; set; }
        public char Write { get; set; }
    }
}