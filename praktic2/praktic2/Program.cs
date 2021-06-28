using System;

namespace practik2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введите строку");
            string log = Convert.ToString(Console.ReadLine());
            int a = 0;
            int b = 0;
            for (int i = 0; i < log.Length; i++)
            {
                if (log[i] == 'f')
                {
                    a++;
                    b = i + 1;
                    if (a == 2)
                    {
                        Console.WriteLine("Индекс второго вхождения f: " + b);
                        break;
                    }
                }
            }
            if (a == 1)
            {
                Console.WriteLine("Индекс второго вхождения f: -1");
            }
            else if (a == 0)
            {
                Console.WriteLine("Индекс второго вхождения f: -2");
            }
            //2
            Console.WriteLine("2) Введите строку");
            string log1 = Convert.ToString(Console.ReadLine());
            log1 = log1.ToLower();
            string log11 = "";
            string[] l = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь",
                "э", "ю", "я"," "};
            string[] l1 = { "a", "b", "v", "g", "d", "e", "yo", "j", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h", "c", "ch", "sh", "sh", "", "y",
                "", "e", "yu", "ya", " " };
            for (int i = 0; i < log1.Length; i++)
            {
                for (int j = 0; j < l.Length; j++)
                {
                    if (Convert.ToString(log1[i]) == l[j])
                    {
                        log11 = log11 + l1[j];
                    }
                }
            }
            Console.WriteLine("2) " + log11);
            //3
            Console.WriteLine("3) Введите строку");
            string log2 = Convert.ToString(Console.ReadLine());
            string log22 = "";
            int start = 0;
            int end = 0;
            for (int i = 0; i < log2.Length; i++)
            {
                if (log2[i] == 'h' || log2[i] == 'H')
                {
                    start = i;
                    break;
                }
            }
            for (int i = log2.Length - 1; i > 0; i--)
            {
                if (log2[i] == 'h' || log2[i] == 'H')
                {
                    end = i;
                    break;
                }
            }
            for (int i = 0; i < log2.Length; i++)
            {
                if (i == start || i == end)
                {
                    log22 = log22 + log2[i];
                }
                else if (log2[i] == 'H')
                {
                    log22 = log22 + "h";
                }
                else if (log2[i] == 'h')
                {
                    log22 = log22 + "H";
                }
                else
                {
                    log22 = log22 + log2[i];
                }
            }
            Console.WriteLine("3) " + log22);
        }
    }
}