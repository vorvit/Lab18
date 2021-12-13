using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ЗАДАНИЕ 18. КОЛЛЕКЦИИ
            Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
            Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
            Указание: задача решается однократным проходом по символам заданной строки слева направо;
            для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
            каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
            в конце прохода стек должен быть пуст.
            */
            Console.WriteLine("Пожалуйста, ведите строку, содержащую скобки трёх видов: круглые (), квадратные [] и фигурные {} и любые другие символы:");
            //string str = "}23sdf(sdf{sdf[fsdf)sdfsd}})sdfs()";
            string str = Console.ReadLine();
            Console.WriteLine(StrCheck(str)? "В введенной строке - скобки расставлены корректно" : "В введенной строке - скобки расставлены некорректно");
            Console.ReadKey();
        }
        static bool StrCheck(string str)
        {
            Stack<char> st = new Stack<char>();
            foreach (var s in str)
            {
                if (s == '[')
                    st.Push(']');
                if (s == '(')
                    st.Push(')');
                if (s == '{')
                    st.Push('}');
                if (st.Count != 0 && s == st.Peek())
                    st.Pop();
            }
            if (st.Count != 0)
                return false;
            return true;
        }
    }
}