using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniversalTuringMachine;

namespace TuringTest
{
    [TestClass]
    public class TestMachine
    {
        [TestMethod]
        public void TestBusyBeaver()
        {
            List<State> states = new List<State>();
            List<State> accept = new List<State>();
            State start;
            List<char> alpha = new List<char>();
            List<Calc> sigi = new List<Calc>();
            Tape tp = new Tape();
            UniversalTuringMachine.UniversalTuringMachine machine;


            // add states
            states.Add(new State("q0", 0));
            states.Add(new State("q1", 1));
            states.Add(new State("qf", 2));
            accept.Add(states[2]);
            start = states[0];
            alpha.Add('0');
            alpha.Add('1');

            sigi.Add(new Calc(states[0], states[1], 1, '0', '1'));
            sigi.Add(new Calc(states[0], states[1], -1, '1', '1'));
            sigi.Add(new Calc(states[1], states[0], -1, '0', '1'));
            sigi.Add(new Calc(states[1], states[2], 1, '1', '1'));

            tp.Left = new List<char>();
            tp.Right = new List<char>();
            for (int x = 0; x < 10; x++)
            {
                tp.Left.Add('0');
                tp.Right.Add('0');
            }

            machine = new UniversalTuringMachine.UniversalTuringMachine(states, new List<char>(), alpha, sigi, start, accept, tp);
            machine.StateComputed += Machine_StateComputed;
            machine.Perform();

        }

        private void Machine_StateComputed(string text)
        {
            Console.WriteLine(text + "\n");
        }

        [TestMethod]
        public void TestAdd()
        {
            List<State> states = new List<State>();
            List<State> accept = new List<State>();
            State start;
            List<char> alpha = new List<char>();
            List<Calc> sigi = new List<Calc>();
            Tape tp = new Tape();
            UniversalTuringMachine.UniversalTuringMachine machine;

            Console.WriteLine("Add 2 + 3");

            

            tp.Left = new List<char>();
            tp.Right = new List<char>();

            tp.Right.AddRange("110111".ToCharArray());

            states.Add(new State("q0", 0));
            states.Add(new State("q1", 1));
            states.Add(new State("q2", 2));
            states.Add(new State("q3", 3));
            accept.Add(states[3]);
            start = states[0];
            alpha.Add('0');
            alpha.Add('1');

            // add states
            sigi.Add(new Calc(states[0], states[0], 1, '1', '1'));
            sigi.Add(new Calc(states[0], states[1], 1, '0', '0'));
            sigi.Add(new Calc(states[1], states[2], -1, '1', '0'));
            sigi.Add(new Calc(states[2], states[2], 1, '1', '1'));
            sigi.Add(new Calc(states[2], states[1], 1, '0', '1'));
            sigi.Add(new Calc(states[1], states[1], 1, '0', '0'));
            sigi.Add(new Calc(states[1], states[3], 1, '_', '_'));
            
            machine = new UniversalTuringMachine.UniversalTuringMachine(states, new List<char>(), alpha, sigi, start, accept, tp);
            machine.StateComputed += Machine_StateComputed;
            machine.Perform();

        }
    }
}
