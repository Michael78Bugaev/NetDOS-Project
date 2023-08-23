using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NetOS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("NetOs v.1.0.0");
            Console.WriteLine("Type 'help' to get list of commands.");

        }

        protected override void Run()
        {
            Console.Write(" &");
            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unknown command.");
                    Console.ForegroundColor= ConsoleColor.White;
                    break;
                case "cls":
                    Console.Clear();
                    break;
                case "netdos":
                    Console.WriteLine("");
                    break;
                case "help":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("===================================================|");
                    Console.WriteLine("|                 Commands page 1/4                |");
                    Console.WriteLine("|--------------------------------------------------|");
                    Console.WriteLine("| &shutdown - Power off system                     |");
                    Console.WriteLine("| &reboot - reboot system                          |");
                    Console.WriteLine("| &cls - clear screen                              |");
                    Console.WriteLine("| &netdos - NetDOS version                         |");
                    Console.WriteLine("||");
                    Console.WriteLine("===================================================");
                    Console.ForegroundColor= ConsoleColor.White;

                    Console.WriteLine(" ");
                    break;
                case "shutdown":
                    Cosmos.System.Power.Shutdown();
                    break;

                case "reboot":
                    Cosmos.System.Power.Reboot();
                    break;
            }
        }
    }
}
