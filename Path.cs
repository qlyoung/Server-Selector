using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Echo_Arena_Private_Match_Creator
{
    class Path
    {
        public string fileName = @"echovrpath.txt"; 
        public void Store(string input)
        {
            File.WriteAllText(fileName, input);
        }

        public string Fetch()
        {
            //@"C:\Documents\echovrpath.txt";
            string text = File.ReadAllText(fileName);
            
            return text;
        }

        public void Setup()
        {
            Console.WriteLine("Please input the path of the echovr.exe folder.\n it should look like this: D:\\Games\\Oculus\\Software\\ready-at-dawn-echo-arena\\bin\\win10\n");
            string pathInput = Console.ReadLine();
            Store(pathInput);
        }
    }
}
