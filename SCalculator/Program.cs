using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;

namespace SCalculator
{
    internal class Program
    {
        static Dictionary<string, string> arguments = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.WriteLine("\tWitaj w kalkulatorze");
            Console.WriteLine("\tJesli potrzebujesz pomocy wpisz: help");
            Console.WriteLine("\tJesli chcesz wyjsc z programu wpisz: quit");

            while (true)
            {
                Console.Write("\n\t");
                var variable = Console.ReadLine().ToLower();
                string[] variables = variable.Split(' ');
                //Argument arg = new Argument("arg");

                if (variables[0].Equals("arg"))
                {
                    var setName = variables[1];
                    var setValue = double.Parse(variables[2]);
                    //arg.setArgumentName(setName);
                    //arg.setArgumentValue(setValue);
                    //Console.WriteLine("\t" + arg.getArgumentName() + " = " + arg.getArgumentValue());
                    AddArgument(setName, setValue);
                }
                else if (variables[0].Equals("showall"))
                {
                    ShowAllArguments();
                }
                else if (variables[0].Equals("help"))
                {
                    Help();
                }
                else if (variables[0].Equals("clear"))
                {
                    Clear();
                }
                else if (variables[0].Equals("quit"))
                {
                    Quit();
                }
                else if (variables[0].Equals("calc"))
                {
                    Expression e = new Expression(variables[1]);
                    Console.WriteLine("\t" + e.getExpressionString() + " = " + e.calculate());
                }
            }
        }

        private static void AddArgument(string setName, double setValue)
        {
            arguments.Add(setName.ToString(), setValue.ToString());
        }

        private static void ShowAllArguments()
        {
            foreach (var argument in arguments)
            {
                Console.Write("\n\t{0} = {1}", argument.Key, argument.Value);
            }
        }

        private static void Help()
        {
            Expression e = new Expression();
            mXparser.consolePrintln(e.getHelp());
        }

        private static void Clear()
        {
            Console.Clear();
        }

        private static void Quit()
        {
            Environment.Exit(0);
        }
    }
}
