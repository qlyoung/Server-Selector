using System;
using System.Collections.Generic;
using System.Text;

namespace Echo_Arena_Private_Match_Creator
{
    class LocateExe
    {
        
        public string Locate()
        {
            Regions reg = new Regions();
            CMD cmd = new CMD();


            string location = "null";
            Console.WriteLine(cmd.FindExeD());
            Console.ReadLine();
            return location;
        }
    }
}
