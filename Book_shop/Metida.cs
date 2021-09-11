using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    class Metida : Izdatelstvo
    {
        //public Metida() { Name = "Метида"; counter++; } 
        
        override public void Calculated()
        {
            /*
            Console.Write("\nОбьём по продажам раздела 'художественной лиетратуры': ");
            Hud_lit = int.Parse(Console.ReadLine());
            Console.Write("Обьём по продажам раздела 'историческая литература': ");
            His_lit = int.Parse(Console.ReadLine());
            Console.Write("Обьём по продажам раздела 'экономика': ");
            Eco = int.Parse(Console.ReadLine());

            itogoIzdat[counter] = FinalSumm;
            firm[counter] = "Метида";
            */
        }

        override public void Display()
        {
            /*
            MessageBox.Show("**Магазин "+name+"**\n\n" +
                    "Объём раздела 'художественная литература': " + hud_lit +
                    "\nОбъём раздела 'историческая литература': " + his_lit +
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
