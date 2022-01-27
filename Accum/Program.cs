using System;

namespace console
{
    class Program
    {
        public static void Accum(string n)
        {
            string accum = string.Empty;
            char[] arr;
            arr = n.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                string str = new string(arr[i], i + 1);
                string ch = string.Empty;
                ch = str;
                string name = ch;
                string sosatchlen = name[0].ToString().ToUpper() + ch.Substring(1).ToLower();
                str = sosatchlen;
                accum += "-" + str;
            }
            Console.WriteLine(accum.Substring(1));
        }
        static void Main(string[] args)
        {
            Accum("abcd");
        }
    }

}
