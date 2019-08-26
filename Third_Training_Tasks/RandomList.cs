using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomListNameSpace
{
    public class RandomList
    {
        public List<string> randomList = new List<string>();
        char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * */
        public void Runer()
        {
            AddRandomWords(randomList);
            Console.WriteLine($" Elements count before distinct -> {GetCount(randomList)}");
            SortList(randomList);
            ReverseList(randomList);
            DeleteDuplicates(randomList);
            Console.WriteLine($" Elements count after distinct -> {GetCount(randomList)}");
            DisplayPage(20);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
        }
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * */

        //Створення рандомних слів і одавання їх в список
        public void AddRandomWords(List<string> tempList)
        {
            for (int i = 0; i < 100; i++)
            {
                addWord(randomWord(), tempList);
            }
        }


        //Алгоритм обрахунку і виводу слів на певний сторінці
        public void DisplayPage(int pageNumber)
        {
            Console.WriteLine($"Word on page -> {pageNumber}");
            const int wordOnPage = 5;
            int temp = pageNumber * wordOnPage - wordOnPage;
            List<string> temporary = new List<string>();
            for (int i = 0; i < wordOnPage; i++)
                temporary.Add(randomList[temp + i]);

            foreach (var i in temporary)
            {
                Console.WriteLine(i);
            }
        }

        //Метод для видалення дублікатів
        public void DeleteDuplicates(List<string> tempList)
        {
            randomList = tempList.Distinct().ToList();
        }

        //Сортування списку
        public void SortList(List<string> tempList)
        {
            tempList.Sort();
        }

        //Обернений список
        public void ReverseList(List<string> tempList)
        {
            tempList.Reverse();
        }

        //Кількість елементів в списку
        public int GetCount(List<string> tempList)
        {
            int count = tempList.Count;
            return count;
        }


        //Метод розширення для додавання слів в список
        public void addWord(string someWord, List<string> tempList)
        {
            tempList.Add(someWord);
        }

        //Метод для створення рандомних слів
        public string randomWord()
        {
            var stringChars = new char[4];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);
            return finalString;
        }

        //Вивід всіх елеметів списку
        public void Introduce()
        {
            Console.WriteLine("List of random words");
            int count = 0;
            foreach (var i in randomList)
            {
                Console.WriteLine(i);
                count++;
                if (count % 5 == 0)
                {
                    Console.WriteLine("-*-*-*-*-*-*-*-*-");
                    count = 0;
                }
            }
        }
    }
}
