namespace UniversalTuringMachine
{
    public class State
    {
        public int Cnt { get; set; }
        public string Name { get; set; }
        public State(string name, int cnt)
        {
            Cnt = cnt;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}