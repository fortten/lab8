using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8._3
{
    class Program
    {
        // Вручную подготовить текстовый файл с фрагментом текста. Написать программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
        static void Main(string[] args)
        {
            string path = "example.txt";
            using (StreamReader sr = new StreamReader(path))        // Если вывод текста не нужен, строка 16-20 можно удалить
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine();
            using (StreamReader sr = new StreamReader(path))
            {
                string[] arrayWord = sr.ReadToEnd().Split('\n', ' ');                
                Console.WriteLine("Количество символов в тексте = {0}", File.ReadAllText(path).Length);     // Нашел в справке, так можно без лишних массивов обойтись.
                Console.WriteLine("Количество слов в тексте = {0}", arrayWord.Length);                      // Если не пользоваться системными библиотеками, то для строк
                Console.WriteLine("Количество строк в тексте = {0}", File.ReadAllLines(path).Length);       // массив string со сплитом '\n', для символов массив char.
                Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
                Console.ReadKey();
            }
        }
    }
}