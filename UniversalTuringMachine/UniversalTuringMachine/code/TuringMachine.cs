using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversalTuringMachine
{
    public class UniversalTuringMachine{
        public List<State> Q { get; set; }
        public List<char> Sigma { get; set; }
        public List<char> L { get; set; }
        public List<Calc> SigmaSmall { get; set; }
        public State Q0 { get; set; }
        public const char _blank = '_';
        public List<State> F { get; set; }
        public Tape EndlessTape { get; set; }

        public UniversalTuringMachine(List<State> q, List<char> sigi, List<char> l, List<Calc> sigiSmalls, State q0, List<State> f, Tape tp)
        {
            Q = q;
            Sigma = sigi;
            L = l;
            SigmaSmall = sigiSmalls;
            Q0 = q0;
            F = f;
            EndlessTape = tp;
        }

        private void Perform()
        {

            Configuration conf = new Configuration(Q0, EndlessTape.Left, EndlessTape.Right);
            Calc step;
            bool run = true;
            int currpos = 0;
            while(run){
                try
                {
                    char pass;
                    if (conf.V.ElementAtOrDefault(0) != char.MinValue)
                    {
                        pass = conf.V[0];
                    }
                    else
                    {
                        pass = _blank;
                    }
                    step = MapCalc(conf.Q, pass);
                    EndlessTape.Right[currpos] = step.Write;
                    currpos += step.Direction;
                    MoveHead(step.Direction);
                    conf = new Configuration(step.Next, EndlessTape.Left, EndlessTape.Right);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        private void MoveHead(int step)
        {
            int x = 0;
            foreach (char symbol in EndlessTape.Left)
            {
                if(step > 0)
                {
                    if (EndlessTape.Right.ElementAtOrDefault(0) != char.MinValue)
                    {
                        EndlessTape.Left.Add(EndlessTape.Right[0]);
                        EndlessTape.Right.RemoveAt(0);
                    }
                    else
                    {
                        // Pseudo Endless
                        EndlessTape.Left.Add(_blank);
                        EndlessTape.Right.Add(_blank);
                    }
                    
                }
                else if(step < 0)
                {
                    if (EndlessTape.Left.ElementAtOrDefault(EndlessTape.Left.Count -1) != char.MinValue)
                    {
                        EndlessTape.Right.Insert(0,EndlessTape.Left[EndlessTape.Left.Count - 1]);
                        EndlessTape.Right.RemoveAt(EndlessTape.Left.Count - 1);
                    }
                    else
                    {
                        // Pseudo Endless
                        EndlessTape.Left.Add(_blank);
                        EndlessTape.Right.Add(_blank);
                    }
                }
                x++;
            }
        }

        private Calc MapCalc(State curr, char rd)
        {
            if(SigmaSmall.Any(c => c.Current == curr && c.Read == rd))
            {
                return SigmaSmall.FirstOrDefault(c => c.Current == curr && c.Read == rd);
            }

            throw new CalcNotDefinedException("Stopped");
        }
    }
}