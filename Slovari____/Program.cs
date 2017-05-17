using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovari____
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\днс\Desktop\text.txt");

            string unic = "";
            text.ToLower();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < unic.Length; j++)
                {
                    if (text[i]==unic[j])
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    unic = unic + text[i];
                }

            }


            Dictionary<string, int> slovari = new Dictionary<string, int>();

            for (int i = 0; i < unic.Length; i++)
            {
                slovari.Add(Convert.ToString(unic[i]), 0);
            }

            for (int i = 0; i < text.Length; i++)
            {
                slovari[Convert.ToString(text[i])]++;
            }



            Console.ReadKey();

        }
    }
}
