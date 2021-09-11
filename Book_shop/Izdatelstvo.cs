using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop
{
    abstract class Izdatelstvo
    {
        protected static double hud_lit = 0;
        protected static double his_lit = 0;
        protected static double comp = 0;
        protected static double sc_fic = 0;
        protected static double eco = 0;

        public static double Hud_lit
        {
            get { return hud_lit; }
            set { hud_lit = value; }
        }

        public static double His_lit
        {
            get { return his_lit; }
            set { his_lit = value; }
        }

        public static double Comp
        {
            get { return comp; }
            set { comp = value; }
        }

        public static double Sc_fic
        {
            get { return sc_fic; }
            set { sc_fic = value; }
        }

        public static double Eco
        {
            get { return eco; }
            set { eco = value; }
        }

        public abstract void Calculated();
        public abstract void Display();
    }
}
