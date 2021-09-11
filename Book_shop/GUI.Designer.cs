namespace Book_Shop
{
    partial class formGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGUI));
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.cmbMouth = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.chbEco = new System.Windows.Forms.CheckBox();
            this.chbSc_Fic = new System.Windows.Forms.CheckBox();
            this.chbComp = new System.Windows.Forms.CheckBox();
            this.chbHis_Lit = new System.Windows.Forms.CheckBox();
            this.chbHud_Lit = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Location = new System.Drawing.Point(9, 8);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(84, 20);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Компания";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(18, 355);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 20);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Тип";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.BackColor = System.Drawing.Color.White;
            this.lblPeriod.ForeColor = System.Drawing.Color.Black;
            this.lblPeriod.Location = new System.Drawing.Point(18, 294);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(68, 20);
            this.lblPeriod.TabIndex = 10;
            this.lblPeriod.Text = "Период";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Items.AddRange(new object[] {
            "Все",
            "Чакона",
            "Метида",
            "Стрела"});
            this.cmbCompany.Location = new System.Drawing.Point(12, 38);
            this.cmbCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(288, 28);
            this.cmbCompany.TabIndex = 12;
            this.cmbCompany.Text = "Все";
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            this.cmbCompany.TextChanged += new System.EventHandler(this.cmbCompany_TextChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Общее количество продаж",
            "Средний показатель продаж",
            "Процентный показатель продаж"});
            this.cmbType.Location = new System.Drawing.Point(12, 380);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(298, 28);
            this.cmbType.TabIndex = 13;
            this.cmbType.Text = "Общее количество продаж";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "Всё время"});
            this.cmbPeriod.Location = new System.Drawing.Point(18, 318);
            this.cmbPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(127, 28);
            this.cmbPeriod.TabIndex = 14;
            this.cmbPeriod.TextChanged += new System.EventHandler(this.cmbPeriod_TextChanged);
            // 
            // cmbMouth
            // 
            this.cmbMouth.FormattingEnabled = true;
            this.cmbMouth.Items.AddRange(new object[] {
            "Весь год"});
            this.cmbMouth.Location = new System.Drawing.Point(184, 318);
            this.cmbMouth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMouth.Name = "cmbMouth";
            this.cmbMouth.Size = new System.Drawing.Size(121, 28);
            this.cmbMouth.TabIndex = 16;
            this.cmbMouth.Text = "Весь год";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(381, 140);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(310, 60);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Расчёт\r\n";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(381, 229);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(310, 60);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(381, 38);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(310, 60);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Создать новый отчёт";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.Color.White;
            this.grpCategory.Controls.Add(this.chbEco);
            this.grpCategory.Controls.Add(this.chbSc_Fic);
            this.grpCategory.Controls.Add(this.chbComp);
            this.grpCategory.Controls.Add(this.chbHis_Lit);
            this.grpCategory.Controls.Add(this.chbHud_Lit);
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpCategory.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.grpCategory.Location = new System.Drawing.Point(12, 75);
            this.grpCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCategory.Size = new System.Drawing.Size(310, 215);
            this.grpCategory.TabIndex = 20;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Жанр";
            // 
            // chbEco
            // 
            this.chbEco.AutoSize = true;
            this.chbEco.Checked = true;
            this.chbEco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbEco.Location = new System.Drawing.Point(9, 171);
            this.chbEco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbEco.Name = "chbEco";
            this.chbEco.Size = new System.Drawing.Size(127, 28);
            this.chbEco.TabIndex = 4;
            this.chbEco.Text = "Экономика";
            this.chbEco.UseVisualStyleBackColor = true;
            this.chbEco.CheckedChanged += new System.EventHandler(this.chbEco_CheckedChanged);
            // 
            // chbSc_Fic
            // 
            this.chbSc_Fic.AutoSize = true;
            this.chbSc_Fic.Checked = true;
            this.chbSc_Fic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSc_Fic.Location = new System.Drawing.Point(9, 135);
            this.chbSc_Fic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbSc_Fic.Name = "chbSc_Fic";
            this.chbSc_Fic.Size = new System.Drawing.Size(212, 28);
            this.chbSc_Fic.TabIndex = 3;
            this.chbSc_Fic.Text = "Научная фантастика";
            this.chbSc_Fic.UseVisualStyleBackColor = true;
            this.chbSc_Fic.CheckedChanged += new System.EventHandler(this.chbSc_Fic_CheckedChanged);
            // 
            // chbComp
            // 
            this.chbComp.AutoSize = true;
            this.chbComp.Checked = true;
            this.chbComp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbComp.Location = new System.Drawing.Point(9, 100);
            this.chbComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbComp.Name = "chbComp";
            this.chbComp.Size = new System.Drawing.Size(276, 28);
            this.chbComp.TabIndex = 2;
            this.chbComp.Text = "Литература о компьютерах";
            this.chbComp.UseVisualStyleBackColor = true;
            this.chbComp.CheckedChanged += new System.EventHandler(this.chbComp_CheckedChanged);
            // 
            // chbHis_Lit
            // 
            this.chbHis_Lit.AutoSize = true;
            this.chbHis_Lit.Checked = true;
            this.chbHis_Lit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHis_Lit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbHis_Lit.Location = new System.Drawing.Point(9, 65);
            this.chbHis_Lit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbHis_Lit.Name = "chbHis_Lit";
            this.chbHis_Lit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbHis_Lit.Size = new System.Drawing.Size(263, 28);
            this.chbHis_Lit.TabIndex = 1;
            this.chbHis_Lit.Text = "Историческая литература";
            this.chbHis_Lit.UseVisualStyleBackColor = true;
            this.chbHis_Lit.CheckedChanged += new System.EventHandler(this.chbHis_Lit_CheckedChanged);
            // 
            // chbHud_Lit
            // 
            this.chbHud_Lit.AutoSize = true;
            this.chbHud_Lit.Checked = true;
            this.chbHud_Lit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHud_Lit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbHud_Lit.Location = new System.Drawing.Point(9, 29);
            this.chbHud_Lit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbHud_Lit.Name = "chbHud_Lit";
            this.chbHud_Lit.Size = new System.Drawing.Size(290, 28);
            this.chbHud_Lit.TabIndex = 0;
            this.chbHud_Lit.Text = "Художественная литература";
            this.chbHud_Lit.UseVisualStyleBackColor = true;
            this.chbHud_Lit.CheckedChanged += new System.EventHandler(this.chbHud_Lit_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(576, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 39);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 492);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbMouth);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCompany);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт продаж";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.VisibleChanged += new System.EventHandler(this.GUI_VisibleChanged);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.ComboBox cmbMouth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.CheckBox chbEco;
        private System.Windows.Forms.CheckBox chbSc_Fic;
        private System.Windows.Forms.CheckBox chbComp;
        private System.Windows.Forms.CheckBox chbHis_Lit;
        private System.Windows.Forms.CheckBox chbHud_Lit;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnExit;
    }
}