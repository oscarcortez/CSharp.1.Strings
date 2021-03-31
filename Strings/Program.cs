using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "bill";
            String x = "hola";

            y = "Maira";

            // string is an alias of String
            Console.WriteLine($"Hello World! {y} {x}");


            Console.WriteLine($"Hello World! {y.Length} {x.Length}");

            string greeting = "            hola                ";
            Console.WriteLine(greeting.TrimStart());
            Console.WriteLine(greeting.TrimEnd());
            Console.WriteLine(greeting.Trim());

            string csvFile = "oscar,cortez,villca";
            string[] csvResults = csvFile.Split(",");

            foreach (var csvResult in csvResults)
            {
                Console.WriteLine(csvResult);
            }


            Console.WriteLine($"{ csvFile.Replace(",", ";")}");
            Console.WriteLine(csvFile);

            var result = csvFile.Contains("oscar") ? "si" : "no";
            Console.WriteLine(result);

            var s = "aaa";
            s = s.Replace("a", "b").Replace("b", "c").Replace("c", "d");
            Console.WriteLine(s);

            var csv2 = csvFile.Clone();

            csv2 = "modificado";

            Console.WriteLine(csvFile);
            Console.WriteLine(csv2);

            Console.WriteLine("clones clones");

            string[] strArray = { "uno", "dos", "tres", "cuatro" };
            string[] strArray2 = strArray;

            strArray2[2] = "hola";
            Console.WriteLine(strArray[2]);

            string[] strArray3 = (string[])strArray.Clone(); // explicit casts
            strArray3[2] = "hola2";

            Console.WriteLine(strArray[2]);

            const string noChange = "no deberia cambiar";

            Console.WriteLine(noChange);
            // noChange = "cambiate"; doesnt work because of const 
            Console.WriteLine(noChange);

            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            Console.WriteLine($"new Path con arroba: {newPath}");

            char[] letters = { 'a', 'b', 'c' };
            string alphabet = new string(letters);

            Console.WriteLine($"alphabet from char array: {alphabet}");

            string alphabet2 = new string(letters, 1, 2);

            Console.WriteLine($"alphabet from char array with startIndex and length: {alphabet2}");

            Console.WriteLine("hola como    " +
                "estas   bien \\si");

            Console.WriteLine(@"hola como 
estas \si");

            var esternocleidomastoideo = "esternocleidomastoideo";
            foreach (var est in esternocleidomastoideo)
            {
                Console.WriteLine(est);
            }

            string var123 = "fasdfads";
            if (string.IsNullOrEmpty(var123))
            {
                Console.WriteLine("yes is empty");
            }
            else
            {
                Console.WriteLine("no is not empty");
            }

            var sb = new StringBuilder(var123);

            var var123withSB = sb.Append("hola como estas");
            Console.WriteLine($"con string builder: {var123withSB}");
            string root = @"C:\users";
            string root2 = @"C:\Users";

            bool resulta = root.Equals(root2);
            Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(resulta ? "equal." : "not equal.")}");

            resulta = root.Equals(root2, StringComparison.Ordinal);
            Console.WriteLine($"Ordinal comparison: <{root}> and <{root2}> are {(resulta ? "equal." : "not equal.")}");

            Console.WriteLine($"Using == says that <{root}> and <{root2}> are {(root == root2 ? "equal" : "not equal")}");
        }

    }
}
