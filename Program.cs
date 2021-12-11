using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinCommander
{
    class Program
    {
        static void Main(string[] args)
        {

            string workDir = @"C:\ExampleDir";
            
            // Перечень всех файлов и папок, вложенных в workDir
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }


            Console.ReadLine();
        }

    }
}
//Просмотр файловой структуры;
//Вывод дерева файловой системы с условием "пейджинга" - только 2 уровня;
//Перемещение по папкам с помощью стрелок.