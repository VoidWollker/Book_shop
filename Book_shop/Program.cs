/*
using System;
using System.Windows.Forms;
using System.IO;

namespace Book_Shop
{
    class BooksTrade : Izdatelstvo
    {
        static string cycle = "Y";
        static int book_shop = 0;
        static string response;

        const string zag1 = "1";
        const string zag2 = "2";
        const string zag3 = "3";

        static void Main(string[] args)
        {
            while (cycle == "Y")
            {
                book_shop = WhatKing();

                switch (book_shop)
                {
                    case 1: Chakona C = new Chakona(); C.Calculated(); C.Display(); break;
                    case 2: Metida M = new Metida(); M.Calculated(); M.Display(); break;
                    case 3: Strela S = new Strela(); S.Calculated(); S.Display(); break;
                }
                Console.WriteLine("Хотите ввести другие данные? ");
                cycle =Console.ReadLine();
                cycle = cycle.ToUpper();
            }
            Itogo();
            FileStream file = new FileStream("D:\\Продажи.txt",FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            for (int row = 0; row <= counter; row++) { writer.WriteLine("{0} - {1}",firm[row],itogoIzdat[row]); }
            writer.Close();
        }

        static int WhatKing()
        {
            Console.Write("Какой магазин вы выбраете\n(1-Чакона, 2-Метида, 3-Стрела): ");
            response = Console.ReadLine();
            switch (response)
            {
                case zag1: break;
                case zag2: break;
                case zag3: break;
                default:
                    MessageBox.Show("Вы должны вписать '1' или '2' или '3'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                    break;
            }
            return int.Parse(response);
        }

        override public void Calculated() { }
        override public void Display() { }
    }
}
*/