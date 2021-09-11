namespace Book_Shop
{
    partial class formCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCreate));
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtHud_Lit = new System.Windows.Forms.TextBox();
            this.lblHis_Lit = new System.Windows.Forms.Label();
            this.txtHis_Lit = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.lblSc_Fic = new System.Windows.Forms.Label();
            this.txtSc_Fic = new System.Windows.Forms.TextBox();
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.radStrela = new System.Windows.Forms.RadioButton();
            this.radMetida = new System.Windows.Forms.RadioButton();
            this.radChakona = new System.Windows.Forms.RadioButton();
            this.lblSelectedCompany = new System.Windows.Forms.Label();
            this.lblHud_Lit = new System.Windows.Forms.Label();
            this.txtEco = new System.Windows.Forms.TextBox();
            this.lblEco = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblMouth = new System.Windows.Forms.Label();
            this.cmbMouth = new System.Windows.Forms.ComboBox();
            this.grpPeriod = new System.Windows.Forms.GroupBox();
            this.bntCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpCompany.SuspendLayout();
            this.grpPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompany.Location = new System.Drawing.Point(144, 23);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(61, 13);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Компания:";
            // 
            // txtHud_Lit
            // 
            this.txtHud_Lit.Location = new System.Drawing.Point(305, 50);
            this.txtHud_Lit.Name = "txtHud_Lit";
            this.txtHud_Lit.Size = new System.Drawing.Size(100, 20);
            this.txtHud_Lit.TabIndex = 1;
            this.txtHud_Lit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHud_Lit_KeyPress);
            // 
            // lblHis_Lit
            // 
            this.lblHis_Lit.AutoSize = true;
            this.lblHis_Lit.BackColor = System.Drawing.Color.Transparent;
            this.lblHis_Lit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHis_Lit.Location = new System.Drawing.Point(144, 83);
            this.lblHis_Lit.Name = "lblHis_Lit";
            this.lblHis_Lit.Size = new System.Drawing.Size(142, 13);
            this.lblHis_Lit.TabIndex = 2;
            this.lblHis_Lit.Text = "Историческая литература:";
            // 
            // txtHis_Lit
            // 
            this.txtHis_Lit.Location = new System.Drawing.Point(305, 80);
            this.txtHis_Lit.Name = "txtHis_Lit";
            this.txtHis_Lit.Size = new System.Drawing.Size(100, 20);
            this.txtHis_Lit.TabIndex = 3;
            this.txtHis_Lit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHis_Lit_KeyPress);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.BackColor = System.Drawing.Color.Transparent;
            this.lblComp.ForeColor = System.Drawing.Color.Transparent;
            this.lblComp.Location = new System.Drawing.Point(144, 113);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(149, 13);
            this.lblComp.TabIndex = 4;
            this.lblComp.Text = "Литература о компьютерах:";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(305, 110);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(100, 20);
            this.txtComp.TabIndex = 5;
            this.txtComp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComp_KeyPress);
            // 
            // lblSc_Fic
            // 
            this.lblSc_Fic.AutoSize = true;
            this.lblSc_Fic.BackColor = System.Drawing.Color.Transparent;
            this.lblSc_Fic.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSc_Fic.Location = new System.Drawing.Point(144, 143);
            this.lblSc_Fic.Name = "lblSc_Fic";
            this.lblSc_Fic.Size = new System.Drawing.Size(115, 13);
            this.lblSc_Fic.TabIndex = 6;
            this.lblSc_Fic.Text = "Научная фантастика:";
            // 
            // txtSc_Fic
            // 
            this.txtSc_Fic.Location = new System.Drawing.Point(305, 140);
            this.txtSc_Fic.Name = "txtSc_Fic";
            this.txtSc_Fic.Size = new System.Drawing.Size(100, 20);
            this.txtSc_Fic.TabIndex = 7;
            this.txtSc_Fic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSc_Fic_KeyPress);
            // 
            // grpCompany
            // 
            this.grpCompany.BackColor = System.Drawing.Color.Transparent;
            this.grpCompany.Controls.Add(this.radStrela);
            this.grpCompany.Controls.Add(this.radMetida);
            this.grpCompany.Controls.Add(this.radChakona);
            this.grpCompany.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpCompany.Location = new System.Drawing.Point(12, 12);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(114, 174);
            this.grpCompany.TabIndex = 8;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Компания";
            // 
            // radStrela
            // 
            this.radStrela.AutoSize = true;
            this.radStrela.Location = new System.Drawing.Point(6, 131);
            this.radStrela.Name = "radStrela";
            this.radStrela.Size = new System.Drawing.Size(61, 17);
            this.radStrela.TabIndex = 2;
            this.radStrela.Text = "Стрела";
            this.radStrela.UseVisualStyleBackColor = true;
            this.radStrela.CheckedChanged += new System.EventHandler(this.radStrela_CheckedChanged);
            // 
            // radMetida
            // 
            this.radMetida.AutoSize = true;
            this.radMetida.Location = new System.Drawing.Point(6, 78);
            this.radMetida.Name = "radMetida";
            this.radMetida.Size = new System.Drawing.Size(63, 17);
            this.radMetida.TabIndex = 1;
            this.radMetida.Text = "Метида";
            this.radMetida.UseVisualStyleBackColor = true;
            this.radMetida.CheckedChanged += new System.EventHandler(this.radMetida_CheckedChanged);
            // 
            // radChakona
            // 
            this.radChakona.AutoSize = true;
            this.radChakona.Checked = true;
            this.radChakona.Location = new System.Drawing.Point(6, 25);
            this.radChakona.Name = "radChakona";
            this.radChakona.Size = new System.Drawing.Size(63, 17);
            this.radChakona.TabIndex = 0;
            this.radChakona.TabStop = true;
            this.radChakona.Text = "Чакона";
            this.radChakona.UseVisualStyleBackColor = true;
            this.radChakona.CheckedChanged += new System.EventHandler(this.radChakona_CheckedChanged);
            // 
            // lblSelectedCompany
            // 
            this.lblSelectedCompany.AutoSize = true;
            this.lblSelectedCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedCompany.ForeColor = System.Drawing.Color.Transparent;
            this.lblSelectedCompany.Location = new System.Drawing.Point(302, 23);
            this.lblSelectedCompany.Name = "lblSelectedCompany";
            this.lblSelectedCompany.Size = new System.Drawing.Size(45, 13);
            this.lblSelectedCompany.TabIndex = 9;
            this.lblSelectedCompany.Text = "Чакона";
            // 
            // lblHud_Lit
            // 
            this.lblHud_Lit.AutoSize = true;
            this.lblHud_Lit.BackColor = System.Drawing.Color.Transparent;
            this.lblHud_Lit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHud_Lit.Location = new System.Drawing.Point(144, 53);
            this.lblHud_Lit.Name = "lblHud_Lit";
            this.lblHud_Lit.Size = new System.Drawing.Size(155, 13);
            this.lblHud_Lit.TabIndex = 10;
            this.lblHud_Lit.Text = "Художественная литература:";
            // 
            // txtEco
            // 
            this.txtEco.Location = new System.Drawing.Point(305, 170);
            this.txtEco.Name = "txtEco";
            this.txtEco.Size = new System.Drawing.Size(100, 20);
            this.txtEco.TabIndex = 12;
            this.txtEco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEco_KeyPress);
            // 
            // lblEco
            // 
            this.lblEco.AutoSize = true;
            this.lblEco.BackColor = System.Drawing.Color.Transparent;
            this.lblEco.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEco.Location = new System.Drawing.Point(144, 173);
            this.lblEco.Name = "lblEco";
            this.lblEco.Size = new System.Drawing.Size(67, 13);
            this.lblEco.TabIndex = 11;
            this.lblEco.Text = "Экономика:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 23);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 13);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Год:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(47, 20);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 15;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // lblMouth
            // 
            this.lblMouth.AutoSize = true;
            this.lblMouth.Location = new System.Drawing.Point(6, 49);
            this.lblMouth.Name = "lblMouth";
            this.lblMouth.Size = new System.Drawing.Size(43, 13);
            this.lblMouth.TabIndex = 16;
            this.lblMouth.Text = "Месяц:";
            // 
            // cmbMouth
            // 
            this.cmbMouth.FormattingEnabled = true;
            this.cmbMouth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cmbMouth.Location = new System.Drawing.Point(47, 49);
            this.cmbMouth.Name = "cmbMouth";
            this.cmbMouth.Size = new System.Drawing.Size(100, 21);
            this.cmbMouth.TabIndex = 17;
            this.cmbMouth.Text = "Январь";
            // 
            // grpPeriod
            // 
            this.grpPeriod.BackColor = System.Drawing.Color.Transparent;
            this.grpPeriod.Controls.Add(this.cmbMouth);
            this.grpPeriod.Controls.Add(this.lblYear);
            this.grpPeriod.Controls.Add(this.lblMouth);
            this.grpPeriod.Controls.Add(this.txtYear);
            this.grpPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.grpPeriod.Location = new System.Drawing.Point(12, 218);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Size = new System.Drawing.Size(167, 79);
            this.grpPeriod.TabIndex = 18;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Период";
            // 
            // bntCreate
            // 
            this.bntCreate.Location = new System.Drawing.Point(214, 231);
            this.bntCreate.Name = "bntCreate";
            this.bntCreate.Size = new System.Drawing.Size(191, 23);
            this.bntCreate.TabIndex = 19;
            this.bntCreate.Text = "Создать";
            this.bntCreate.UseVisualStyleBackColor = true;
            this.bntCreate.Click += new System.EventHandler(this.bntCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(214, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // formCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(433, 320);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntCreate);
            this.Controls.Add(this.grpPeriod);
            this.Controls.Add(this.txtEco);
            this.Controls.Add(this.lblEco);
            this.Controls.Add(this.lblHud_Lit);
            this.Controls.Add(this.lblSelectedCompany);
            this.Controls.Add(this.grpCompany);
            this.Controls.Add(this.txtSc_Fic);
            this.Controls.Add(this.lblSc_Fic);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.txtHis_Lit);
            this.Controls.Add(this.lblHis_Lit);
            this.Controls.Add(this.txtHud_Lit);
            this.Controls.Add(this.lblCompany);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "formCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новый отчёт";
            this.Load += new System.EventHandler(this.formCreate_Load);
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.grpPeriod.ResumeLayout(false);
            this.grpPeriod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtHud_Lit;
        private System.Windows.Forms.Label lblHis_Lit;
        private System.Windows.Forms.TextBox txtHis_Lit;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label lblSc_Fic;
        private System.Windows.Forms.TextBox txtSc_Fic;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.RadioButton radStrela;
        private System.Windows.Forms.RadioButton radMetida;
        private System.Windows.Forms.RadioButton radChakona;
        private System.Windows.Forms.Label lblSelectedCompany;
        private System.Windows.Forms.Label lblHud_Lit;
        private System.Windows.Forms.TextBox txtEco;
        private System.Windows.Forms.Label lblEco;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblMouth;
        private System.Windows.Forms.ComboBox cmbMouth;
        private System.Windows.Forms.GroupBox grpPeriod;
        private System.Windows.Forms.Button bntCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
    }
}