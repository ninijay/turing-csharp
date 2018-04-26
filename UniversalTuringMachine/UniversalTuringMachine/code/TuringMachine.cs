using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversalTuringMachine
{
    public class UniversalTuringMachine{

        public delegate void StateComputedEventHadler(string text);
        public event StateComputedEventHadler StateComputed;

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

        public void Perform()
        {

            Configuration conf = new Configuration(Q0, EndlessTape.Left, EndlessTape.Right);
            Calc step;
            bool run = true;
            int currpos = 0;
            while(run){
                try
                {
                    if (StateComputed != null)
                    {
                        StateComputed(EndlessTape.LeftFromHead() + conf.Q.ToString() + EndlessTape.RightFromHead());
                    }

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
                    run = false;
                }
            }


            //Console.WriteLine("Machine halted");
            //Console.WriteLine("Tape: " + EndlessTape.ToString());
        }

        private void MoveHead(int step)
        {
            if (step > 0)
            {
                char rightToLeft = EndlessTape.Right.FirstOrDefault();
                if (rightToLeft == char.MinValue)
                {
                    EndlessTape.Left.Add(_blank);
                }
                else
                {
                    EndlessTape.Left.Add(rightToLeft);
                    EndlessTape.Right.RemoveAt(0);
                }
            }

            if (step < 0)
            {
                char leftToRight = EndlessTape.Left.LastOrDefault();
                if (leftToRight == char.MinValue)
                {
                    EndlessTape.Right.Insert(0, _blank);
                }
                else
                {
                    EndlessTape.Right.Insert(0, leftToRight);
                    EndlessTape.Left.RemoveAt(EndlessTape.Left.Count - 1);
                }
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