using System;
using System.Collections.Generic;
using System.Text;

namespace ConcatenacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Teste " + "para " + " concatenar " + " + ";

            /*IEnumerable<string> lista = new List<string>() { "TEste ", " de ", " Concat" };
            string s2 = string.Concat(lista);*/

            //string s3 = string.Join(" ", "TEste", " de ", " join ", " quantas ", "strings " , "eu quiser");

            //string s4 = string.Format("{0} {1} {2}", "Teste", " string ", " format ");

            string p1 = "Teste";
            string p2 = " para ";
            string p3 = " concatenacao";

            string s5 = $"{p1} {p2} {p3}";

            /* StringBuilder s6 = new StringBuilder();
             s6.Append("Teste ");
             s6.AppendLine(" ");
             s6.AppendLine(" para ");
             s6.AppendLine(" StringBuilder ");
             string s7 = s6.ToString();*/

            Console.WriteLine(s5);
            Console.ReadLine();
        }


    }
}
