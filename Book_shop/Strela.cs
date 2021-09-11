using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    class Strela : Izdatelstvo
    {
        //public Strela() { name = "Стрела"; counter++; }
        
        override public void Calculated()
        {
            /*
            Console.Write("Обьём по продажам раздела 'компьюетеры': ");
            Comp = int.Parse(Console.ReadLine());
            Console.Write("Обьём по продажам раздела 'естественная наука': ");
            Sc_fic = int.Parse(Console.ReadLine());
            Console.Write("Обьём по продажам раздела 'экономика': ");
            Eco = int.Parse(Console.ReadLine());

            itogoIzdat[counter] = FinalSumm;
            firm[counter] = "Стрела";
            */
        }

        override public void Display()
        {
            /*
            MessageBox.Show("**Магазин " + name + "**\n\n" +
                    "\nОбъём раздела 'компьютеры': " + comp +
                    "\nОбъём раздела 'естественная наука': " + sc_fic +
                    "\nОбъём раздела 'экономика': " + eco +
                    "\nОбщий объём: " + FinalSumm+
                    "\n\n" + country,
                    "\n\nИтог",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                   */
        }
    }
}
