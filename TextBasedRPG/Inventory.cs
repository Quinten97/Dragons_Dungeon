using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Inventory
    {
        public static void DrawInventory()
        {
            Console.Clear();

            Screens.roomString = "";
            int index = 1;
            Console.WriteLine("  ____________________________________________________________________________________________________________________  ");

            while (index < 28)
            {
                Console.SetCursorPosition(1, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(118, index);
                Console.WriteLine("|");
                Console.SetCursorPosition(40, index);
                Console.WriteLine("|");
                index++;
            }
            Console.SetCursorPosition(17, 3);
            Console.WriteLine("Stats:");

            Console.SetCursorPosition(1, 24);
            Console.WriteLine("|                                      |_____________________________________________________________________________");

            Console.SetCursorPosition(42, 26);
            Console.WriteLine("(A)ctivate item");
            Console.SetCursorPosition(54, 26);
            Console.WriteLine("(E)quip");
            Console.SetCursorPosition(62, 26);
            Console.WriteLine("(U)nequip");
            Console.SetCursorPosition(110, 26);
            Console.WriteLine("(C)lose");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("|______________________________________|_____________________________________________________________________________");


            ConsoleKeyInfo keyInfo;
            bool loopBreak = true;

            do
            {

                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.C:
                        {
                            Screens.roomString = Screens.savedRoomString;
                            loopBreak = false;
                            break;
                        }
                    case ConsoleKey.A:
                        {
                            break;
                        }
                    case ConsoleKey.E:
                        {
                            break;
                        }
                    case ConsoleKey.U:
                        {
                            break;
                        }
                }
            }
            while (loopBreak == true);
        }
    }
}
