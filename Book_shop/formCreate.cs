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
    public partial class formCreate : Form
    {
        protected static string path;
        protected static DialogResult result=DialogResult.No;
        protected static string str;
        protected static List<string> strList = new List<string> { };
        protected static List<int> yearList= new List<int> { };
        protected static List<string> mouthList= new List<string> { };
        protected static string[] strMass;  
        protected static int year;
        protected static string mouth;
        protected static int company;
        protected static int prover = 0;
        protected static int cycle = 0;
        protected static int proverNewData = 1;/*Проверочная переменная, созданная для проверки того,
        нужно ли записывать новые данные в файл, либо такие данные уже существуют и их нужно переписать*/

        public formCreate()
        {
            InitializeComponent();
        }

        private void radChakona_CheckedChanged(object sender, EventArgs e)
        {
            ClearTxt();
            lblSelectedCompany.Text = "Чакона";
            lblHud_Lit.Visible = true;
            lblHud_Lit.Location = new Point(144, 53);
            txtHud_Lit.Visible = true;
            txtHud_Lit.Location = new Point(305, 50);
            lblHis_Lit.Visible = true;
            lblHis_Lit.Location = new Point(144, 83);
            txtHis_Lit.Visible = true;
            txtHis_Lit.Location = new Point(305, 80);
            lblComp.Visible = true;
            lblComp.Location = new Point(144, 113);
            txtComp.Visible = true;
            txtComp.Location = new Point(305, 110);
            lblSc_Fic.Visible = true;
            lblSc_Fic.Location = new Point(144, 143);
            txtSc_Fic.Visible = true;
            txtSc_Fic.Location = new Point(305, 140);
            lblEco.Visible = true;
            lblEco.Location = new Point(144, 173);
            txtEco.Visible = true;
            txtEco.Location = new Point(305, 170);
        }

        private void radMetida_CheckedChanged(object sender, EventArgs e)
        {
            ClearTxt();
            lblSelectedCompany.Text = "Метида";
            lblHud_Lit.Visible = true;
            lblHud_Lit.Location = new Point(144, 53);
            txtHud_Lit.Visible = true;
            txtHud_Lit.Location = new Point(305, 50);
            lblHis_Lit.Visible = true;
            lblHis_Lit.Location = new Point(144, 83);
            txtHis_Lit.Visible = true;
            txtHis_Lit.Location = new Point(305, 80);
            lblComp.Visible = false;
            txtComp.Visible = false;
            lblSc_Fic.Visible = false;
            txtSc_Fic.Visible = false;
            lblEco.Visible = true;
            lblEco.Location = new Point(144, 113);
            txtEco.Visible = true;
            txtEco.Location = new Point(305, 110);
        }

        private void radStrela_CheckedChanged(object sender, EventArgs e)
        {
            ClearTxt();
            lblSelectedCompany.Text = "Стрела";
            lblHud_Lit.Visible = false;
            txtHud_Lit.Visible = false;
            lblHis_Lit.Visible = false;
            txtHis_Lit.Visible = false;
            lblComp.Visible = true;
            lblComp.Location = new Point(144, 53);
            txtComp.Visible = true;
            txtComp.Location = new Point(305, 50);
            lblSc_Fic.Visible = true;
            lblSc_Fic.Location = new Point(144, 83);
            txtSc_Fic.Visible = true;
            txtSc_Fic.Location = new Point(305, 80);
            lblEco.Visible = true;
            lblEco.Location = new Point(144, 113);
            txtEco.Visible = true;
            txtEco.Location = new Point(305, 110);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formGUI.FormGUI.Show();
            this.Close();
        }

        private void txtHud_Lit_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnlyNum(e);
        }

        private void txtHis_Lit_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnlyNum(e);
        }

        private void txtComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnlyNum(e);
        }

        private void txtSc_Fic_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnlyNum(e);
        }

        private void txtEco_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnlyNum(e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTxt();
            radChakona.Checked = true;
            txtYear.Text = DateTime.Now.Year.ToString();
            cmbMouth.Text = "Январь";
        }

        private void ClearTxt()
        {
            txtHud_Lit.Text = "";
            txtHis_Lit.Text = "";
            txtComp.Text = "";
            txtSc_Fic.Text = "";
            txtEco.Text = "";
        }
        private void TextOnlyNum(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextOnlyNum(e);
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text != "")
            {
                if (int.Parse(txtYear.Text) < 2000 | int.Parse(txtYear.Text) > DateTime.Now.Year)
                {
                    MessageBox.Show(
                       "Неверное значение года",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                    txtYear.Text = DateTime.Now.Year.ToString();
                }
            }
        }

        private void bntCreate_Click(object sender, EventArgs e)
        {
            formGUI.file.Close();
            path = Path.GetPathRoot(Environment.SystemDirectory);
            path.Replace("\\", "");
            path += "Firm/Firm.txt";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);
            strList.Clear();
            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
                Console.WriteLine(str);
                strList.Add(str);
            }
            reader = new StreamReader(file);
            strMass = strList.ToArray();
            for (int i = 0; i < strMass.Length; i++)
            {
                if (strMass[i].Replace(" ", "") == txtYear.Text)
                {
                    if (strMass[i + 1].Replace(" ", "") == cmbMouth.Text)
                    {
                        if (strMass[i + 2].Replace(" ", "") == lblSelectedCompany.Text)
                        {
                            result = MessageBox.Show(
                                        "Такой отчёт уже существует, хотите его переписать?",
                                        "Ошибка",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information
                                        );

                            if (result == DialogResult.Yes)
                            {
                                strMass[i] = "0";
                                strMass[i + 1] = "0";
                                if (strMass[i + 2].Replace(" ", "") == "Чакона")
                                {
                                    strMass[i + 2] = "0";
                                    strMass[i + 3] = "0";
                                    strMass[i + 4] = "0";
                                    strMass[i + 5] = "0";
                                    strMass[i + 6] = "0";
                                    strMass[i + 7] = "0";
                                }
                                if (strMass[i + 2].Replace(" ", "") == "Метида")
                                {
                                    strMass[i + 2] = "0";
                                    strMass[i + 3] = "0";
                                    strMass[i + 4] = "0";
                                    strMass[i + 5] = "0";
                                }
                                if (strMass[i + 2].Replace(" ", "") == "Стрела")
                                {
                                    strMass[i + 2] = "0";
                                    strMass[i + 3] = "0";
                                    strMass[i + 4] = "0";
                                    strMass[i + 5] = "0";
                                }
                            }
                            if (result == DialogResult.No)
                            { proverNewData = 0; }
                        }
                    }
                }
            }
            file.Close();
            file = new FileStream(path, FileMode.Truncate, FileAccess.ReadWrite);
            file.Close();
            StreamWriter writer = new StreamWriter(path);
            for(int i =0;i<strMass.Length;i++)
            {
                if (strMass[i] != "0")
                {
                    writer.WriteLine(strMass[i]);
                }
            }
            if (proverNewData==1)
            {
                WriteNewData(writer);
            }
            writer.Close();
            formGUI.FormGUI.Show();
            this.Close();
        }

        private void WriteNewData(StreamWriter writer)
        {
            writer.WriteLine(txtYear.Text);
            writer.WriteLine(" " + cmbMouth.Text);
            writer.WriteLine("  " + lblSelectedCompany.Text);
            if (lblSelectedCompany.Text == "Чакона")
            {
                if (txtHud_Lit.Text == "") { txtHud_Lit.Text = "0"; }
                writer.WriteLine("   " + txtHud_Lit.Text);
                if (txtHis_Lit.Text == "") { txtHis_Lit.Text = "0"; }
                writer.WriteLine("   " + txtHis_Lit.Text);
                if (txtComp.Text == "") { txtComp.Text = "0"; }
                writer.WriteLine("   " + txtComp.Text);
                if (txtSc_Fic.Text == "") { txtSc_Fic.Text = "0"; }
                writer.WriteLine("   " + txtSc_Fic.Text);
                if (txtEco.Text == "") { txtEco.Text = "0"; }
                writer.WriteLine("   " + txtEco.Text);
            }
            if (lblSelectedCompany.Text == "Метида")
            {
                if (txtHud_Lit.Text == "") { txtHud_Lit.Text = "0"; }
                writer.WriteLine("   " + txtHud_Lit.Text);
                if (txtHis_Lit.Text == "") { txtHis_Lit.Text = "0"; }
                writer.WriteLine("   " + txtHis_Lit.Text);
                if (txtEco.Text == "") { txtEco.Text = "0"; }
                writer.WriteLine("   " + txtEco.Text);
            }
            if (lblSelectedCompany.Text == "Стрела")
            {
                if (txtComp.Text == "") { txtComp.Text = "0"; }
                writer.WriteLine("   " + txtComp.Text);
                if (txtSc_Fic.Text == "") { txtSc_Fic.Text = "0"; }
                writer.WriteLine("   " + txtSc_Fic.Text);
                if (txtEco.Text == "") { txtEco.Text = "0"; }
                writer.WriteLine("   " + txtEco.Text);
            }
        }

        private void formCreate_Load(object sender, EventArgs e)
        {
            txtYear.Text = DateTime.Now.Year.ToString();
        }
    }
}
