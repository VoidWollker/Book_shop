using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Book_Shop
{

    public partial class formGUI : Form
    {
        protected static string path;
        public static FileStream file;
        public static Form FormCreate = new formCreate();
        public static Form FormGUI = new formGUI();
        protected static List<string> collectionList = new List<string> { };
        protected static string[] collection;
        protected static List<string> yearList = new List<string> { };
        protected static List<int> temp2 = new List<int> { };
        protected static int[] mouth = new int[12];//Массив имеющихся месяцев в годовом отчёте
        protected static int counter = 0; //Переменная-счётчик
        protected static int prover = 0; //Проверочнаая переменная, созданная чтобы в ComboBox не записывались одинаковые значения 
        protected static int cycle = 0; //Проверочнаая переменная, созданная чтобы в ComboBox не записывались одинаковые значения
        protected static int temp = 0; //Переменная-контейнер, которая используется при сортировке
        protected static int counterHud_Lit = 0;
        protected static int counterHis_Lit = 0;
        protected static int counterComp = 0;
        protected static int counterSc_Fic = 0;
        protected static int counterEco = 0;
        protected static int counterCategory = 0;
        protected static string strHud_Lit = "";
        protected static string strHis_Lit = "";
        protected static string strComp = "";
        protected static string strSc_Fic = "";
        protected static string strEco = "";
        protected static double sumCategory = 0;
        protected static string str;
        protected static string strYear;

        public formGUI()
        {
            InitializeComponent();
        }

        public void GUI_Load(object sender, EventArgs e)
        {
            path = Path.GetPathRoot(Environment.SystemDirectory);
            path.Replace("\\","");
            path += "Firm/Firm.txt";
            file = new FileStream(path, FileMode.OpenOrCreate);
            cmbMouth.Visible = false;
            file.Close();
            StreamReader reader = new StreamReader(path);

            //Запись периодов из файла в массив (начало)
            while (!reader.EndOfStream)
            {
                cycle = 0;
                prover = 0;
                str = reader.ReadLine();
                foreach (char i in str)
                {
                    if (cycle == 0)
                    {
                        if (i != char.Parse(" "))
                        {
                            str = str.Replace(" ", "");
                            collectionList.Add(str);
                            cycle++;
                        }
                        else { cycle++; }
                    }
                }
            }
            string[] temp1 = collectionList.ToArray();
            string[] collection = collectionList.ToArray();
            for (int i = 0; i < temp1.Length; i++)
            {
                prover = 0;
                for (int j = 0; j < temp1.Length; j++)
                {
                    if (int.Parse(collection[i]) == int.Parse(temp1[j]))
                    {
                        if (prover != 0) { collection[i] = "0"; temp1[j] = "0"; }
                        else { prover++; }
                    }
                }
            }
            cmbPeriod.Items.Remove("Всё время");

            //Сортировка по убыванию
            for (int i = 0; i < temp1.Length; i++)
            {
                for (int j = i + 1; j < temp1.Length; j++)
                {
                    if (int.Parse(temp1[i]) < int.Parse(temp1[j]))
                    {
                        temp = int.Parse(temp1[i]);
                        temp1[i] = temp1[j];
                        temp1[j] = temp.ToString();
                    }
                }
            }

            //Запись объектов в ComboBox
            cmbPeriod.Items.Clear();
            cmbPeriod.Items.Add("Всё время");
            foreach (string i in temp1) { if (i != "0") { cmbPeriod.Items.Add(i); }; }
            cmbPeriod.Text = "Всё время";
            reader.Close();
        }

        public void GUI_VisibleChanged(object sender, EventArgs e)
        {
            cmbCompany.SelectedIndex = 0;
            cmbPeriod.Text = "Всё время";
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cmbPeriod_TextChanged(object sender, EventArgs e)
        {
            if (cmbPeriod.Text != "Всё время") { cmbMouth.Visible = true; }
            else { cmbMouth.Visible = false; }
            
                cmbMouth.Items.Clear();
                cmbMouth.Items.Add("Весь год");
                cmbMouth.Text = "Весь год";
                string[] temp1 = collectionList.ToArray();
                string[] collection = new string[temp1.Length];

                //Запись месяцев из файла в массив (начало)
                StreamReader reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    if (temp1.Length == 1) { counter = temp1.Length - 1; }
                    else { counter = temp1.Length - 2; }
                    str = reader.ReadLine();
                    temp = 0;
                    foreach (char i in str) { if (i == char.Parse(" ")) { temp += 1; } }
                    if (temp == 0) { strYear = str; }
                    prover = 0;
                    if (temp == 1 & strYear == cmbPeriod.Text)
                    {
                        if (reader.ReadLine().Replace(" ", "") == cmbCompany.Text | cmbCompany.SelectedIndex == 0)
                        {
                            for (int k = 0; k <= counter; k++)
                            {

                                if (str == temp1[k])
                                {

                                    prover += 1;
                                }
                            }
                            if (prover == 0)
                            {
                                collection[counter] = str;
                                counter++;
                                prover = 0;
                                str = str.Replace(" ", "");
                                cmbMouth.Items.Add(str);
                            }
                        }
                    }
                }
                for (int i = 0; i < collection.Length; i++) { collection[i] = "0"; }
                for (int i = 0; i < mouth.Length; i++) { mouth[i] = 0; }
                counter = 0;
                foreach (string i in cmbMouth.Items) { if (i != "Весь год") { collection[counter] = i; counter++; } }
                cmbMouth.Items.Clear();
                foreach (string i in collection)
                {
                    if (i == "Январь") { mouth[0] = 1; }
                    if (i == "Февраль") { mouth[1] = 1; }
                    if (i == "Март") { mouth[2] = 1; }
                    if (i == "Апрель") { mouth[3] = 1; }
                    if (i == "Май") { mouth[4] = 1; }
                    if (i == "Июнь") { mouth[5] = 1; }
                    if (i == "Июль") { mouth[6] = 1; }
                    if (i == "Август") { mouth[7] = 1; }
                    if (i == "Сентябрь") { mouth[8] = 1; }
                    if (i == "Октябрь") { mouth[9] = 1; }
                    if (i == "Ноябрь") { mouth[10] = 1; }
                    if (i == "Декабрь") { mouth[11] = 1; }
                }
                cmbMouth.Items.Add("Весь год");
                if (mouth[0] == 1) { cmbMouth.Items.Add("Январь"); }
                if (mouth[1] == 1) { cmbMouth.Items.Add("Февраль"); }
                if (mouth[2] == 1) { cmbMouth.Items.Add("Март"); }
                if (mouth[3] == 1) { cmbMouth.Items.Add("Апрель"); }
                if (mouth[4] == 1) { cmbMouth.Items.Add("Май"); }
                if (mouth[5] == 1) { cmbMouth.Items.Add("Июнь"); }
                if (mouth[6] == 1) { cmbMouth.Items.Add("Июль"); }
                if (mouth[7] == 1) { cmbMouth.Items.Add("Август"); }
                if (mouth[8] == 1) { cmbMouth.Items.Add("Сентябрь"); }
                if (mouth[9] == 1) { cmbMouth.Items.Add("Октябрь"); }
                if (mouth[10] == 1) { cmbMouth.Items.Add("Ноябрь"); }
                if (mouth[11] == 1) { cmbMouth.Items.Add("Декабрь"); }
                reader.Close();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cmbCompany_TextChanged(object sender, EventArgs e)
        {
            if (cmbCompany.Text == "Все" | cmbCompany.Text == "Чакона")
            {
                chbHud_Lit.Visible = true;
                chbHud_Lit.Checked = true;
                chbHis_Lit.Visible = true;
                chbHis_Lit.Checked = true;
                chbComp.Visible = true;
                chbComp.Checked = true;
                chbSc_Fic.Visible = true;
                chbSc_Fic.Checked = true;
                chbEco.Visible = true;
                chbEco.Checked = true;
                lblPeriod.Location = new System.Drawing.Point(18,294);
                lblType.Location = new System.Drawing.Point(18, 355);
                cmbType.Location = new System.Drawing.Point(12, 380);
                cmbPeriod.Location = new System.Drawing.Point(18, 318);
                cmbMouth.Location = new System.Drawing.Point(184, 318);
                btnCalculate.Location = new System.Drawing.Point(381, 140);
                btnReset.Location = new System.Drawing.Point(381, 229);
                btnCreate.Location = new System.Drawing.Point(381, 38);
                grpCategory.Location = new System.Drawing.Point(12, 75);
                grpCategory.Size = new System.Drawing.Size(310, 215);
                chbEco.Location = new System.Drawing.Point(9,171);
                chbSc_Fic.Location = new System.Drawing.Point(9,135);
                chbComp.Location = new System.Drawing.Point(9,100);
                chbHis_Lit.Location = new System.Drawing.Point(9,65);
                chbHud_Lit.Location = new System.Drawing.Point(9,29);
                ClientSize = new System.Drawing.Size(720,490);
            }
            if (cmbCompany.Text == "Метида")
            {
                chbHud_Lit.Visible = true;
                chbHud_Lit.Checked = true;
                chbHis_Lit.Visible = true;
                chbHis_Lit.Checked = true;
                chbComp.Visible = false;
                chbComp.Checked = false;
                chbSc_Fic.Visible = false;
                chbSc_Fic.Checked = false;
                chbEco.Visible = true;
                chbEco.Checked = true;
                lblPeriod.Location = new System.Drawing.Point(18, 294);
                lblType.Location = new System.Drawing.Point(18, 355);
                cmbType.Location = new System.Drawing.Point(12, 380);
                cmbPeriod.Location = new System.Drawing.Point(18, 318);
                cmbMouth.Location = new System.Drawing.Point(184, 318);
                btnCalculate.Location = new System.Drawing.Point(381, 140);
                btnReset.Location = new System.Drawing.Point(381, 229);
                btnCreate.Location = new System.Drawing.Point(381, 38);
                grpCategory.Location = new System.Drawing.Point(12, 75);
                grpCategory.Size = new System.Drawing.Size(310, 135);
                chbEco.Location = new System.Drawing.Point(9, 100);
                chbSc_Fic.Location = new System.Drawing.Point(9, 135);
                chbComp.Location = new System.Drawing.Point(9, 100);
                chbHis_Lit.Location = new System.Drawing.Point(9, 65);
                chbHud_Lit.Location = new System.Drawing.Point(9, 29);
                ClientSize = new System.Drawing.Size(720, 490);
            }
            if (cmbCompany.Text == "Стрела")
            {
                chbHud_Lit.Visible = false;
                chbHud_Lit.Checked = false;
                chbHis_Lit.Visible = false;
                chbHis_Lit.Checked = false;
                chbComp.Visible = true;
                chbComp.Checked = true;
                chbSc_Fic.Visible = true;
                chbSc_Fic.Checked = true;
                chbEco.Visible = true;
                chbEco.Checked = true;
                lblPeriod.Location = new System.Drawing.Point(18, 294);
                lblType.Location = new System.Drawing.Point(18, 355);
                cmbType.Location = new System.Drawing.Point(12, 380);
                cmbPeriod.Location = new System.Drawing.Point(18, 318);
                cmbMouth.Location = new System.Drawing.Point(184, 318);
                btnCalculate.Location = new System.Drawing.Point(381, 140);
                btnReset.Location = new System.Drawing.Point(381, 229);
                btnCreate.Location = new System.Drawing.Point(381, 38);
                grpCategory.Location = new System.Drawing.Point(12, 75);
                grpCategory.Size = new System.Drawing.Size(310, 135);
                chbEco.Location = new System.Drawing.Point(9, 100);
                chbSc_Fic.Location = new System.Drawing.Point(9, 65);
                chbComp.Location = new System.Drawing.Point(9, 29);
                chbHis_Lit.Location = new System.Drawing.Point(9, 65);
                chbHud_Lit.Location = new System.Drawing.Point(9, 29);
                ClientSize = new System.Drawing.Size(720, 490);
            }
            cmbPeriod.Text = "Всё время";
            StreamReader reader = new StreamReader(path);
            if (cmbCompany.Text != "Всe")
            {
                lblPeriod.Visible = true;
                cmbPeriod.Visible = true;
            }
            else
            {
                cmbPeriod.Text = "Всё время";
                cmbMouth.Text = "Весь год";
            }
            cmbPeriod.Items.Clear();
            yearList.Clear();
            cmbPeriod.Items.Add("Всё время");
            while (!reader.EndOfStream)
            {
                prover = 0;
                temp = 0;
                str = reader.ReadLine();
                foreach (char i in str) { if (i == char.Parse(" ")) { temp += 1; } }
                if (temp == 0) { strYear = str; }
                if (temp == 2)
                {
                    if (cmbCompany.SelectedIndex == 0)
                    {
                        foreach (string i in yearList)
                        {
                            if (strYear == i)
                            {
                                prover++;
                            }
                        }
                        if (prover == 0) { yearList.Add(strYear); }
                    }
                    if (str.Replace(" ", "") == cmbCompany.Text)
                    {
                        yearList.Add(strYear);
                    }
                }
            }
            yearList.Sort();
            yearList.Reverse();
            strYear = "";
            foreach (string i in yearList) { cmbPeriod.Items.Add(i); }
            yearList.Clear();
            foreach (string i in cmbPeriod.Items)
            {
                if (i != strYear) { yearList.Add(i); }
                strYear = i;
            }
            cmbPeriod.Items.Clear();
            yearList.Sort();
            yearList.Reverse();
            foreach (string i in yearList) { cmbPeriod.Items.Add(i); }
            reader.Close();
        }

        private void chbHud_Lit_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHis_Lit.Checked == false & chbComp.Checked == false & chbSc_Fic.Checked == false & chbEco.Checked == false) { chbHud_Lit.Checked = true; }
        }

        private void chbHis_Lit_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHud_Lit.Checked == false & chbComp.Checked == false & chbSc_Fic.Checked == false & chbEco.Checked == false) { chbHis_Lit.Checked = true; }
        }

        private void chbComp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHis_Lit.Checked == false & chbHud_Lit.Checked == false & chbSc_Fic.Checked == false & chbEco.Checked == false) { chbComp.Checked = true; }
        }

        private void chbSc_Fic_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHis_Lit.Checked == false & chbComp.Checked == false & chbHud_Lit.Checked == false & chbEco.Checked == false) { chbSc_Fic.Checked = true; }
        }

        private void chbEco_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHis_Lit.Checked == false & chbComp.Checked == false & chbSc_Fic.Checked == false & chbHis_Lit.Checked == false) { chbEco.Checked = true; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCompany.Text = "Все";
            cmbType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreate = new formCreate();
            FormCreate.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            sumCategory = 0; counterCategory = 0;
            strHud_Lit = ""; strHis_Lit = ""; strComp = ""; strSc_Fic = ""; strEco = "";
            counterHud_Lit = 0; counterHis_Lit = 0; counterComp = 0; counterSc_Fic = 0; counterEco = 0;
            Izdatelstvo.Hud_lit = 0; Izdatelstvo.His_lit = 0; Izdatelstvo.Comp = 0; Izdatelstvo.Sc_fic = 0; Izdatelstvo.Eco = 0;
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                temp = 0;
                str = reader.ReadLine();
                foreach (char i in str) { if (i == char.Parse(" ")) { temp += 1; } }
                if (temp == 0 & (str.Replace(" ", "") == cmbPeriod.Text | cmbPeriod.Text == "Всё время"))
                {
                    temp = 0;
                    str = reader.ReadLine();
                    foreach (char i in str) { if (i == char.Parse(" ")) { temp += 1; } }
                    if (temp == 1 & (str.Replace(" ", "") == cmbMouth.Text | cmbMouth.Text == "Весь год"))
                    {
                        temp = 0;
                        str = reader.ReadLine();
                        foreach (char i in str) { if (i == char.Parse(" ")) { temp += 1; } }
                        if (temp == 2 & (str.Replace(" ", "") == cmbCompany.Text | cmbCompany.Text == "Все"))
                        {
                            if (str.Replace(" ", "") == "Чакона")
                            {
                                str = reader.ReadLine();
                                Izdatelstvo.Hud_lit += int.Parse(str);
                                counterHud_Lit++;
                                str = reader.ReadLine();
                                Izdatelstvo.His_lit += int.Parse(str);
                                counterHis_Lit++;
                                str = reader.ReadLine();
                                Izdatelstvo.Comp += int.Parse(str);
                                counterComp++;
                                str = reader.ReadLine();
                                Izdatelstvo.Sc_fic += int.Parse(str);
                                counterSc_Fic++;
                                str = reader.ReadLine();
                                Izdatelstvo.Eco += int.Parse(str);
                                counterEco++;
                            }
                            if (str.Replace(" ", "") == "Метида")
                            {
                                str = reader.ReadLine();
                                Izdatelstvo.Hud_lit += int.Parse(str);
                                counterHud_Lit++;
                                str = reader.ReadLine();
                                Izdatelstvo.His_lit += int.Parse(str);
                                counterHis_Lit++;
                                str = reader.ReadLine();
                                Izdatelstvo.Eco += int.Parse(str);
                                counterEco++;
                            }
                            if (str.Replace(" ", "") == "Стрела")
                            {
                                str = reader.ReadLine();
                                Izdatelstvo.Comp += int.Parse(str);
                                counterComp++;
                                str = reader.ReadLine();
                                Izdatelstvo.Sc_fic += int.Parse(str);
                                counterSc_Fic++;
                                str = reader.ReadLine();
                                Izdatelstvo.Eco += int.Parse(str);
                                counterEco++;
                            }
                        }
                    }
                }
            }
            if (cmbType.Text == "Общее количество продаж")
            {
                if (chbHud_Lit.Checked == true) { sumCategory += Izdatelstvo.Hud_lit; strHud_Lit = "Художественная литература :" + Izdatelstvo.Hud_lit; }
                if (chbHis_Lit.Checked == true) { sumCategory += Izdatelstvo.His_lit; strHis_Lit = "\nИсторическая литература :" + Izdatelstvo.His_lit; }
                if (chbComp.Checked == true) { sumCategory += Izdatelstvo.Comp; strComp = "\nЛитература о компьютерах: " + Izdatelstvo.Comp; }
                if (chbSc_Fic.Checked == true) { sumCategory += Izdatelstvo.Sc_fic; strSc_Fic = "\nНаучная фантастика: " + Izdatelstvo.Sc_fic; }
                if (chbEco.Checked == true) { sumCategory += Izdatelstvo.Eco; strEco = "\nЭкономика: " + Izdatelstvo.Eco; }
                MessageBox.Show(strHud_Lit +
                    strHis_Lit +
                    strComp +
                    strSc_Fic +
                    strEco +
                    "\n\nИтого: " + sumCategory,
                    "Общее количество продаж",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if (cmbType.Text == "Средний показатель продаж")
            {
                if (chbHud_Lit.Checked == true) { sumCategory += Izdatelstvo.Hud_lit; strHud_Lit = "Художественная литература: " + (Izdatelstvo.Hud_lit / counterHud_Lit); counterCategory += counterHud_Lit; }
                if (chbHis_Lit.Checked == true) { sumCategory += Izdatelstvo.His_lit; strHis_Lit = "\nИсторическая литература: " + (Izdatelstvo.His_lit / counterHis_Lit); counterCategory += counterHis_Lit; }
                if (chbComp.Checked == true) { sumCategory += Izdatelstvo.Comp; strComp = "\nЛитература о компьютерах: " + (Izdatelstvo.Comp / counterComp); counterCategory += counterComp; }
                if (chbSc_Fic.Checked == true) { sumCategory += Izdatelstvo.Sc_fic; strSc_Fic = "\nНаучная фантастика: " + (Izdatelstvo.Sc_fic / counterSc_Fic); counterCategory += counterSc_Fic; }
                if (chbEco.Checked == true) { sumCategory += Izdatelstvo.Eco; strEco = "\nЭкономика: " + (Izdatelstvo.Eco / counterEco); counterCategory += counterEco; }
                MessageBox.Show(strHud_Lit +
                   strHis_Lit +
                   strComp +
                   strSc_Fic +
                   strEco +
                   "\n\nИтого: " + Math.Round((sumCategory / counterCategory), 2),
                   "Средний показатель продаж",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
            }
            if (cmbType.Text == "Процентный показатель продаж")
            {
                if (chbHud_Lit.Checked == true) { sumCategory += Izdatelstvo.Hud_lit; strHud_Lit = "Художественная литература: " + Math.Round(Izdatelstvo.Hud_lit / Sum(Izdatelstvo.Hud_lit, Izdatelstvo.His_lit, Izdatelstvo.Comp, Izdatelstvo.Sc_fic, Izdatelstvo.Eco), 4) * 100 + "%"; }
                if (chbHis_Lit.Checked == true) { sumCategory += Izdatelstvo.His_lit; strHis_Lit = "\nИсторическая литература: " + Math.Round(Izdatelstvo.His_lit / Sum(Izdatelstvo.Hud_lit, Izdatelstvo.His_lit, Izdatelstvo.Comp, Izdatelstvo.Sc_fic, Izdatelstvo.Eco), 4) * 100 + "%"; };
                if (chbComp.Checked == true) { sumCategory += Izdatelstvo.Comp; strComp = "\nЛитература о компьютерах: " + Math.Round(Izdatelstvo.Comp / Sum(Izdatelstvo.Hud_lit, Izdatelstvo.His_lit, Izdatelstvo.Comp, Izdatelstvo.Sc_fic, Izdatelstvo.Eco), 4) * 100 + "%"; };
                if (chbSc_Fic.Checked == true) { sumCategory += Izdatelstvo.Sc_fic; strSc_Fic = "\nНаучная фантастика: " + Math.Round(Izdatelstvo.Sc_fic / Sum(Izdatelstvo.Hud_lit, Izdatelstvo.His_lit, Izdatelstvo.Comp, Izdatelstvo.Sc_fic, Izdatelstvo.Eco), 4) * 100 + "%"; };
                if (chbEco.Checked == true) { sumCategory += Izdatelstvo.Eco; strEco = "\nЭкономика: " + Math.Round(Izdatelstvo.Eco / Sum(Izdatelstvo.Hud_lit, Izdatelstvo.His_lit, Izdatelstvo.Comp, Izdatelstvo.Sc_fic, Izdatelstvo.Eco), 4) * 100 + "%"; };
                MessageBox.Show(strHud_Lit +
                    strHis_Lit +
                    strComp +
                    strSc_Fic +
                    strEco,
                    "Процентный показатель продаж",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            reader.Close();
        }

        private double Sum(double Hud_Lit, double His_Lit, double Comp, double Sc_Fic, double Eco)
        {
            return Hud_Lit + His_Lit + Comp + Sc_Fic + Eco;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
