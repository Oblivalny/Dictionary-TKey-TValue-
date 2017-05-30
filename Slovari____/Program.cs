using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovar
{
    class Program
    {
        private static string[] BubbleSort(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - 2; j++)

                    if (string.Compare(array[i], array[i + 1]) > 0)
                    {
                        string t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
            return array;
        }




        private static string[] Perestanovka(string[] word, int i)
        {
            string t = word[i + 1];
            word[i + 1] = word[i];
            word[i] = t;
            return word;
        }

        private static string[] xxx(string[] word, int k, int lon, int count, string a, string b)
        {
            for (int j = 0; j < lon; j++)
            {
                count = 0;
                char v = a[j];
                char m = b[j];
                if (v > m)
                {
                    word = Perestanovka(word, k);
                    count++;
                    break;
                }
                if (v < m)
                {
                    count++;
                    break;
                }

            }
            if (count == 0)
            {
                word = Perestanovka(word, k);
            }
            else
            {
                count = 0;
            }
            return word;
        }

        private static string[] Comperer(string[] word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {

                for (int k = 0; k < word.Length - 1; k++)
                {

                    string a = word[k];
                    string b = word[k + 1];

                    if (word[k].Length < word[k + 1].Length)
                    {
                        int count = 0;
                        word = xxx(word, k, word[k].Length, count, a, b);

                    }

                    if (word[k].Length > word[k + 1].Length)
                    {
                        int count = 0;
                        word = xxx(word, k, word[k + 1].Length, count, a, b);

                    }



                    if (word[k].Length == word[k + 1].Length)
                    {

                        for (int j = 0; j < word[k].Length; j++)
                        {

                            char v = a[j];
                            char m = b[j];
                            if (v > m)
                            {
                                word = Perestanovka(word, k);
                                break;
                            }

                        }
                    }
                }
            }

            return word;
        }

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\днс\Desktop\text.txt");
            text = text.ToLower();

            List<string> unic = new List<string>();


            string[] word = (text.Split(new char[] { '-', '(', ')', '\'', '\r', ' ', '\t', '.', ',', '\n', '"', '!', '?', ',' }, StringSplitOptions.None));

            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                count = 0;

                for (int j = 0; j < unic.LongCount(); j++)
                {
                    if (word[i].Equals(unic[j]))
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    if (word[i] != "")
                    {
                        unic.Add(word[i]);
                    }

                }

            }


            Dictionary<string, int> slovari = new Dictionary<string, int>();

            Array.Sort(word);
            unic.Sort();




            for (int i = 0; i < unic.LongCount(); i++)
            {
                slovari.Add(Convert.ToString(unic[i]), 0);
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != "")
                {
                    slovari[Convert.ToString(word[i])]++;
                }
            }

            foreach (var e in slovari)
                Console.WriteLine(e);

            foreach (var item in word)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
/*
Big Russian Boss, Zest - Воскрес

Вчера был тяжёлый день, я снюхал весь кокос. (Опа!) 
Отпиздил должника в погоне, прыгнул через мост! (Нихуя себе!)
И вспомнили былое с Пимпом, словил грустного слегка. 
У всех бывают неудачи! (И че блять?!) Кроме меня. (Ага!) 
Мама, прости за то, что я хотел уйти из жизни. (Прости) 
Земля, прости за то, что Егор Крид родился (Прости, пожалуйста!) 
Прошу, не надо разводиться - прости, Бред Питт! (Братан) 
С Анжелкой у нас был дружеский перепих! (Вот так, да!) 
Не верьте слухам, все хейтеры пиздят про нас! 
Я не ходил по морю, у меня на жопе нету глаз. (Ну только один!)
Босс, тоже человек, но он - не простой смертный, 
Ведь на 95 процентов состоит из денег. (Больших!) 
Кушаю в Париже, там намного безопасней, 
Ты похавал бутер Тимати (И чё?) - отравился нахуй! (Пидор!). 
Люблю с красивой дамой на хуе встречать закат. (трах, трах...)
Тебе кончили на зад (Когда?) пять минут назад! (Лох) 
Я вижу всё не совершенство мира, но мне похер! 
Вижу красоту во всех, кроме Oxxxymiron'а! (Уёбок!) 
Этот мир уже никогда не станет прежним, 
Его спасёт любовь (И чё?) и Hustle Hard Flava! 

Эй! Чей лик сверкает в небесах? (Мой)
Кто снится твоей бабе в одних трусах? 
Такой горячий, но он не горит в огне! 
Большой Русский Босс, - спасибо, что Воскрес! (Пожалуйста!) 

Эй! Чей лик сверкает в небесах? (Мой)
Кто снится твоей бабе в одних трусах? Ага! 
Такой горячий, но он не горит в огне! (И в воде не тонет!) 
Большой Русский Босс, - спасибо, что Воскрес! (Пожалуйста, суки!) 

Спасибо, что Воскрес! Босс! Босс! Босс! Босс! 
Спасибо, что Воскрес! Босс! Босс! Босс! Босс! 
И спасибо, что Воскрес! Босс! Босс! Босс! Босс! 
Спасибо, что Воскрес! Босс! Босс! Босс! Босс! 

(Чё там?) Завтра начинаю жизнь с чистого листа. (Это как?) 
Светлые мысли, белоснежный Кадилак. (Эскалэйд, блять!) 
Первым делом, еду к Моту, он попал в капкан. (Бедняжка) 
Следом, будем удлинять Витю АК! (Пидараса!)
Отныне свет несу я всем, даже безнадёжным! 
Верну пароль Тати, её обокрал Gazgolder! 
Дам адвоката Птахе, ведь он - борец за правду! 
Пошли все нахуй, кто там против наркоманов! 
Сука! 
У меня есть всё, чтобы хотел бы русский МС! (Эт чё?) 
ST с Galat'ом свожу лично к логопеду! 
Великодушный Босс не просит ничего в замен! (Мне похуй!) 
Джиган звонил, просил себе нормальный текст! 
Без Б! Ведь я Воскрес, - помогу всем! (Кроме тебя!) 
Во мне, как ни крути - нуждается весь русский рэп! 
Фонд социальной помощи убогим от меня. (О, да!) 
Воскресение Босса "красный" день календаря! 

Эй! Чей лик сверкает в небесах? (Мой)
Кто снится твоей бабе в одних трусах? 
Такой горячий, но он не горит в огне! 
Большой Русский Босс, - спасибо, что Воскрес! (Пожалуйста!) 

Эй! Чей лик сверкает в небесах? (Мой)
Кто снится твоей бабе в одних трусах? Ага! 
Такой горячий, но он не горит в огне! (И в воде не тонет!) 
Большой Русский Босс, - спасибо, что Воскрес! (Пожалуйста, суки!)
 */
