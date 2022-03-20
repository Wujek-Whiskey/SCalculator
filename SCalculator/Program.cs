using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;

namespace SCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWitaj w kalkulatorze");
            Console.WriteLine("\tJesli potrzebujesz pomocy wpisz: help");
            Console.WriteLine("\tJesli potrzebujesz wyczyscic konsole wpisz: clear");
            Console.WriteLine("\tJesli chcesz wyjsc z programu wpisz: quit");

            Calculator clt = new Calculator();

            while (true)
            {
                Console.Write("\n\t");
                var variable = Console.ReadLine().ToLower();
                string[] variables = variable.Split(' ');

                if (variables[0].Equals("arg"))
                {
                    var setName = variables[1];
                    var setValue = double.Parse(variables[2]);
                    clt.AddArgument(setName, setValue);
                }
                else if (variables[0].Equals("showall"))
                {
                    clt.ShowAllArguments();
                }
                else if (variables[0].Equals("help"))
                {
                    clt.Help();
                }
                else if (variables[0].Equals("clear"))
                {
                    clt.Clear();
                }
                else if (variables[0].Equals("quit"))
                {
                    clt.Quit();
                }
                else if (variables[0].Equals("calc"))
                {
                    Expression e = new Expression(variables[1]);
                    Console.WriteLine("\t" + e.getExpressionString() + " = " + e.calculate());
                }
            }
        }
    }

    public class Calculator
    {
        static Dictionary<string, string> arguments = new Dictionary<string, string>();

        public void AddArgument(string setName, double setValue)
        {
            arguments.Add(setName.ToString(), setValue.ToString());
        }

        public void ShowAllArguments()
        {
            foreach (var argument in arguments)
            {
                Console.Write("\n\t{0} = {1}", argument.Key, argument.Value);
            }
        }

        public void Help()
        {
            Expression e = new Expression();
            mXparser.consolePrintln(e.getHelp());
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
