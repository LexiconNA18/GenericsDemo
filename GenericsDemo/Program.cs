using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
using static GenericsDemo.Utils;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // MinTest();
            PairTest();

        }

        private static void PairTest()
        {
            // specific Pair, no type arguments, assumes int
            var pair = new Pair(1, 2);
            WriteLine(pair);

            // generic Pair<T>, one type argument, int
            var pairInt = new Pair<int>(1, 2);
            WriteLine(pairInt);

            // generic Pair<T>, one type argument, string
            var pairString = new Pair<string>("one", "two");
            WriteLine(pairString);

            // nested generic
            var tree = new Pair<Pair<int>>(
                first: new Pair<int>(1, 2),
                second: new Pair<int>(3, 4)
            );
            WriteLine(tree);

            // generic Pair<T1, T2>, two type arguments, int and string
            var pairIntString = new Pair<int, string>(1, "two");
            WriteLine(pairIntString);
        }

        private static void MinTest()
        {
            WriteLine(Min(4, 7));

            var value = Min(4, 2.4f);
            WriteLine($"{value} ({value.GetType().Name})"); // Slå upp values typ i runtime

            WriteLine(Min<string>(4.ToString(), "Microsoft"));

            WriteLine(Min(8.2f, 2.4f));
            WriteLine(Min("Microsoft", "Apple"));
        }
    }
}
