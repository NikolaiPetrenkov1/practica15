using System;
using System.IO;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<char, int> stat = new Dictionary<char, int>();

            string path = @"C:\d\ff.txt";

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                byte[] bytes = new byte[stream.Length];

                stream.Read(bytes, 0, bytes.Length);

                string data = System.Text.Encoding.Unicode.GetString(bytes);
                foreach (char symbol in data)
                {
                    if (stat.ContainsKey(symbol))
                    {
                        stat[symbol]++;
                    }
                    else
                    {
                        stat[symbol] = 0;
                    }
                }

            }
            foreach (KeyValuePair<char, int> item in stat)
            {
                Console.WriteLine(item.Key + "\t\t" + item.Value);
            }
            Console.ReadLine();
        }
    }
}
