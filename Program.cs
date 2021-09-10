using System;
using System.Threading;
using System.Diagnostics;

namespace Echo_Arena_Private_Match_Creator
{
    class Program
    {
        static void Main()
        {
            Regions reg = new Regions();
            CMD cmd = new CMD();
            LocateExe locate = new LocateExe();
            Path path = new Path();
            string exe = path.Fetch();//"D:\\Games\\Oculus\\Software\\ready-at-dawn-echo-arena\\bin\\win10"; //D:\Games\Oculus\Software\ready-at-dawn-echo-arena\bin\win10
            string regions = "1. US West\n2. US Central\n3. US North Central\n4. US East\n5. Europe\n6. Japan\n7. Australia\n8. Singapore";
        Start:
            int selection = 0;

            //START ACTUAL CODE:
            if (exe == "invalid") 
            { 
                path.Setup();
                goto Start;
            } 
            else
            {
                Console.WriteLine("Is this your first time setting up?\nCurrent echovr.exe path:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(exe);
                Console.ResetColor();
                Console.WriteLine("y/n");
                string setup = Console.ReadLine();
                switch (setup.ToLower())
                {
                    case "y":
                        path.Setup();
                        break;
                    case "n":
                        break;
                    default:
                        InvalidInput();
                        break;
                }
                Console.Clear();
                Console.WriteLine($"Choose a region\n{regions}");
                string selStr = Console.ReadLine();
                try
                {
                    selection = Int32.Parse(selStr);
                }
                catch (Exception)
                {
                    InvalidInput();
                    goto Start;
                }
                if (selection > 8 || selection < 1)
                {
                    InvalidInput();
                    goto Start;
                }

                cmd.ConsoleInput(exe, reg.Region(selection)); //echovr.exe -region {region}
                Environment.Exit(0);
            }
        }
        static void InvalidInput()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input, please try again.");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
