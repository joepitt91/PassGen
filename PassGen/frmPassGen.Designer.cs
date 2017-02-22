namespace JoePitt.PassGen
{
    partial class frmPassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassGen));
            this.grpCryptoSettings = new System.Windows.Forms.GroupBox();
            this.chkCryptoSpace = new System.Windows.Forms.CheckBox();
            this.btnCryptoGenerate = new System.Windows.Forms.Button();
            this.chkCryptoIncludeAll = new System.Windows.Forms.CheckBox();
            this.numCryptoLength = new System.Windows.Forms.NumericUpDown();
            this.lblCryptoLength = new System.Windows.Forms.Label();
            this.chkCryptoSpecial = new System.Windows.Forms.CheckBox();
            this.chkCryptoNumber = new System.Windows.Forms.CheckBox();
            this.chkCryptoUpper = new System.Windows.Forms.CheckBox();
            this.chkCryptoLower = new System.Windows.Forms.CheckBox();
            this.lblCryptoInclude = new System.Windows.Forms.Label();
            this.txtCrypto01 = new System.Windows.Forms.TextBox();
            this.txtCrypto02 = new System.Windows.Forms.TextBox();
            this.txtCrypto03 = new System.Windows.Forms.TextBox();
            this.txtCrypto04 = new System.Windows.Forms.TextBox();
            this.txtCrypto05 = new System.Windows.Forms.TextBox();
            this.txtCrypto06 = new System.Windows.Forms.TextBox();
            this.txtCrypto07 = new System.Windows.Forms.TextBox();
            this.txtCrypto08 = new System.Windows.Forms.TextBox();
            this.txtCrypto09 = new System.Windows.Forms.TextBox();
            this.txtCrypto10 = new System.Windows.Forms.TextBox();
            this.bkgCryptoGen = new System.ComponentModel.BackgroundWorker();
            this.tbgGenerators = new System.Windows.Forms.TabControl();
            this.tabCrypto = new System.Windows.Forms.TabPage();
            this.tabWords = new System.Windows.Forms.TabPage();
            this.txtWords10 = new System.Windows.Forms.TextBox();
            this.txtWords01 = new System.Windows.Forms.TextBox();
            this.txtWords09 = new System.Windows.Forms.TextBox();
            this.txtWords02 = new System.Windows.Forms.TextBox();
            this.txtWords08 = new System.Windows.Forms.TextBox();
            this.txtWords03 = new System.Windows.Forms.TextBox();
            this.txtWords07 = new System.Windows.Forms.TextBox();
            this.txtWords04 = new System.Windows.Forms.TextBox();
            this.txtWords06 = new System.Windows.Forms.TextBox();
            this.txtWords05 = new System.Windows.Forms.TextBox();
            this.grpWordsSettings = new System.Windows.Forms.GroupBox();
            this.btnWordsClear = new System.Windows.Forms.Button();
            this.btnWordsVerb = new System.Windows.Forms.Button();
            this.btnWordsNoun = new System.Windows.Forms.Button();
            this.btnWordsAdverb = new System.Windows.Forms.Button();
            this.btnWordsAdjective = new System.Windows.Forms.Button();
            this.txtWordsFormat = new System.Windows.Forms.TextBox();
            this.btnWordsGenerate = new System.Windows.Forms.Button();
            this.tabCVC = new System.Windows.Forms.TabPage();
            this.grpCVCSettings = new System.Windows.Forms.GroupBox();
            this.btnCVCGenerate = new System.Windows.Forms.Button();
            this.numCVCCount = new System.Windows.Forms.NumericUpDown();
            this.lblCVCCount = new System.Windows.Forms.Label();
            this.txtCVC10 = new System.Windows.Forms.TextBox();
            this.txtCVC01 = new System.Windows.Forms.TextBox();
            this.txtCVC09 = new System.Windows.Forms.TextBox();
            this.txtCVC02 = new System.Windows.Forms.TextBox();
            this.txtCVC08 = new System.Windows.Forms.TextBox();
            this.txtCVC03 = new System.Windows.Forms.TextBox();
            this.txtCVC07 = new System.Windows.Forms.TextBox();
            this.txtCVC04 = new System.Windows.Forms.TextBox();
            this.txtCVC06 = new System.Windows.Forms.TextBox();
            this.txtCVC05 = new System.Windows.Forms.TextBox();
            this.bkgWordsGen = new System.ComponentModel.BackgroundWorker();
            this.bkgCVCGen = new System.ComponentModel.BackgroundWorker();
            this.grpCryptoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCryptoLength)).BeginInit();
            this.tbgGenerators.SuspendLayout();
            this.tabCrypto.SuspendLayout();
            this.tabWords.SuspendLayout();
            this.grpWordsSettings.SuspendLayout();
            this.tabCVC.SuspendLayout();
            this.grpCVCSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCVCCount)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCryptoSettings
            // 
            this.grpCryptoSettings.Controls.Add(this.chkCryptoSpace);
            this.grpCryptoSettings.Controls.Add(this.btnCryptoGenerate);
            this.grpCryptoSettings.Controls.Add(this.chkCryptoIncludeAll);
            this.grpCryptoSettings.Controls.Add(this.numCryptoLength);
            this.grpCryptoSettings.Controls.Add(this.lblCryptoLength);
            this.grpCryptoSettings.Controls.Add(this.chkCryptoSpecial);
            this.grpCryptoSettings.Controls.Add(this.chkCryptoNumber);
            this.grpCryptoSettings.Controls.Add(this.chkCryptoUpper);
            this.grpCryptoSettings.Controls.Add(this.chkCryptoLower);
            this.grpCryptoSettings.Controls.Add(this.lblCryptoInclude);
            this.grpCryptoSettings.Location = new System.Drawing.Point(9, 9);
            this.grpCryptoSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCryptoSettings.Name = "grpCryptoSettings";
            this.grpCryptoSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCryptoSettings.Size = new System.Drawing.Size(639, 197);
            this.grpCryptoSettings.TabIndex = 0;
            this.grpCryptoSettings.TabStop = false;
            this.grpCryptoSettings.Text = "Settings";
            // 
            // chkCryptoSpace
            // 
            this.chkCryptoSpace.AccessibleName = "Space";
            this.chkCryptoSpace.AutoSize = true;
            this.chkCryptoSpace.Location = new System.Drawing.Point(544, 29);
            this.chkCryptoSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCryptoSpace.Name = "chkCryptoSpace";
            this.chkCryptoSpace.Size = new System.Drawing.Size(81, 24);
            this.chkCryptoSpace.TabIndex = 5;
            this.chkCryptoSpace.Text = "Space";
            this.chkCryptoSpace.UseVisualStyleBackColor = true;
            // 
            // btnCryptoGenerate
            // 
            this.btnCryptoGenerate.AccessibleName = "Generate";
            this.btnCryptoGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCryptoGenerate.Location = new System.Drawing.Point(9, 152);
            this.btnCryptoGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCryptoGenerate.Name = "btnCryptoGenerate";
            this.btnCryptoGenerate.Size = new System.Drawing.Size(621, 35);
            this.btnCryptoGenerate.TabIndex = 9;
            this.btnCryptoGenerate.Text = "&Generate";
            this.btnCryptoGenerate.UseVisualStyleBackColor = true;
            this.btnCryptoGenerate.Click += new System.EventHandler(this.btnCryptoGenerate_Click);
            // 
            // chkCryptoIncludeAll
            // 
            this.chkCryptoIncludeAll.AccessibleName = "Must Include All Types Ticked Above";
            this.chkCryptoIncludeAll.AutoSize = true;
            this.chkCryptoIncludeAll.Checked = true;
            this.chkCryptoIncludeAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptoIncludeAll.Location = new System.Drawing.Point(150, 65);
            this.chkCryptoIncludeAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCryptoIncludeAll.Name = "chkCryptoIncludeAll";
            this.chkCryptoIncludeAll.Size = new System.Drawing.Size(292, 24);
            this.chkCryptoIncludeAll.TabIndex = 6;
            this.chkCryptoIncludeAll.Text = "Must Include All Types Ticked Above";
            this.chkCryptoIncludeAll.UseVisualStyleBackColor = true;
            // 
            // numCryptoLength
            // 
            this.numCryptoLength.AccessibleName = "Length";
            this.numCryptoLength.Location = new System.Drawing.Point(150, 100);
            this.numCryptoLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCryptoLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numCryptoLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numCryptoLength.Name = "numCryptoLength";
            this.numCryptoLength.Size = new System.Drawing.Size(180, 26);
            this.numCryptoLength.TabIndex = 8;
            this.numCryptoLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblCryptoLength
            // 
            this.lblCryptoLength.AutoSize = true;
            this.lblCryptoLength.Location = new System.Drawing.Point(9, 103);
            this.lblCryptoLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCryptoLength.Name = "lblCryptoLength";
            this.lblCryptoLength.Size = new System.Drawing.Size(59, 20);
            this.lblCryptoLength.TabIndex = 7;
            this.lblCryptoLength.Text = "Length";
            // 
            // chkCryptoSpecial
            // 
            this.chkCryptoSpecial.AccessibleName = "Special Characters";
            this.chkCryptoSpecial.AutoSize = true;
            this.chkCryptoSpecial.Checked = true;
            this.chkCryptoSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptoSpecial.Location = new System.Drawing.Point(363, 29);
            this.chkCryptoSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCryptoSpecial.Name = "chkCryptoSpecial";
            this.chkCryptoSpecial.Size = new System.Drawing.Size(169, 24);
            this.chkCryptoSpecial.TabIndex = 4;
            this.chkCryptoSpecial.Text = "Special Characters";
            this.chkCryptoSpecial.UseVisualStyleBackColor = true;
            // 
            // chkCryptoNumber
            // 
            this.chkCryptoNumber.AccessibleName = "Numbers";
            this.chkCryptoNumber.AutoSize = true;
            this.chkCryptoNumber.Checked = true;
            this.chkCryptoNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptoNumber.Location = new System.Drawing.Point(292, 29);
            this.chkCryptoNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCryptoNumber.Name = "chkCryptoNumber";
            this.chkCryptoNumber.Size = new System.Drawing.Size(58, 24);
            this.chkCryptoNumber.TabIndex = 3;
            this.chkCryptoNumber.Text = "0-9";
            this.chkCryptoNumber.UseVisualStyleBackColor = true;
            // 
            // chkCryptoUpper
            // 
            this.chkCryptoUpper.AccessibleName = "Upper Case";
            this.chkCryptoUpper.AutoSize = true;
            this.chkCryptoUpper.Checked = true;
            this.chkCryptoUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptoUpper.Location = new System.Drawing.Point(219, 29);
            this.chkCryptoUpper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCryptoUpper.Name = "chkCryptoUpper";
            this.chkCryptoUpper.Size = new System.Drawing.Size(61, 24);
            this.chkCryptoUpper.TabIndex = 2;
            this.chkCryptoUpper.Text = "A-Z";
            this.chkCryptoUpper.UseVisualStyleBackColor = true;
            // 
            // chkCryptoLower
            // 
            this.chkCryptoLower.AccessibleName = "Lower Case";
            this.chkCryptoLower.AutoSize = true;
            this.chkCryptoLower.Checked = true;
            this.chkCryptoLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptoLower.Location = new System.Drawing.Point(150, 29);
            this.chkCryptoLower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCryptoLower.Name = "chkCryptoLower";
            this.chkCryptoLower.Size = new System.Drawing.Size(57, 24);
            this.chkCryptoLower.TabIndex = 1;
            this.chkCryptoLower.Text = "a-z";
            this.chkCryptoLower.UseVisualStyleBackColor = true;
            // 
            // lblCryptoInclude
            // 
            this.lblCryptoInclude.AutoSize = true;
            this.lblCryptoInclude.Location = new System.Drawing.Point(9, 31);
            this.lblCryptoInclude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCryptoInclude.Name = "lblCryptoInclude";
            this.lblCryptoInclude.Size = new System.Drawing.Size(69, 20);
            this.lblCryptoInclude.TabIndex = 0;
            this.lblCryptoInclude.Text = "Include: ";
            // 
            // txtCrypto01
            // 
            this.txtCrypto01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto01.Location = new System.Drawing.Point(10, 215);
            this.txtCrypto01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto01.Name = "txtCrypto01";
            this.txtCrypto01.ReadOnly = true;
            this.txtCrypto01.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto01.TabIndex = 1;
            this.txtCrypto01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto02
            // 
            this.txtCrypto02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto02.Location = new System.Drawing.Point(9, 255);
            this.txtCrypto02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto02.Name = "txtCrypto02";
            this.txtCrypto02.ReadOnly = true;
            this.txtCrypto02.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto02.TabIndex = 2;
            this.txtCrypto02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto03
            // 
            this.txtCrypto03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto03.Location = new System.Drawing.Point(9, 295);
            this.txtCrypto03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto03.Name = "txtCrypto03";
            this.txtCrypto03.ReadOnly = true;
            this.txtCrypto03.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto03.TabIndex = 3;
            this.txtCrypto03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto04
            // 
            this.txtCrypto04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto04.Location = new System.Drawing.Point(9, 335);
            this.txtCrypto04.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto04.Name = "txtCrypto04";
            this.txtCrypto04.ReadOnly = true;
            this.txtCrypto04.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto04.TabIndex = 4;
            this.txtCrypto04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto05
            // 
            this.txtCrypto05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto05.Location = new System.Drawing.Point(9, 375);
            this.txtCrypto05.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto05.Name = "txtCrypto05";
            this.txtCrypto05.ReadOnly = true;
            this.txtCrypto05.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto05.TabIndex = 5;
            this.txtCrypto05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto06
            // 
            this.txtCrypto06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto06.Location = new System.Drawing.Point(9, 415);
            this.txtCrypto06.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto06.Name = "txtCrypto06";
            this.txtCrypto06.ReadOnly = true;
            this.txtCrypto06.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto06.TabIndex = 6;
            this.txtCrypto06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto07
            // 
            this.txtCrypto07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto07.Location = new System.Drawing.Point(9, 455);
            this.txtCrypto07.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto07.Name = "txtCrypto07";
            this.txtCrypto07.ReadOnly = true;
            this.txtCrypto07.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto07.TabIndex = 7;
            this.txtCrypto07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto08
            // 
            this.txtCrypto08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto08.Location = new System.Drawing.Point(9, 495);
            this.txtCrypto08.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto08.Name = "txtCrypto08";
            this.txtCrypto08.ReadOnly = true;
            this.txtCrypto08.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto08.TabIndex = 8;
            this.txtCrypto08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto09
            // 
            this.txtCrypto09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto09.Location = new System.Drawing.Point(9, 535);
            this.txtCrypto09.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto09.Name = "txtCrypto09";
            this.txtCrypto09.ReadOnly = true;
            this.txtCrypto09.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto09.TabIndex = 9;
            this.txtCrypto09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto10
            // 
            this.txtCrypto10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto10.Location = new System.Drawing.Point(9, 575);
            this.txtCrypto10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCrypto10.Name = "txtCrypto10";
            this.txtCrypto10.ReadOnly = true;
            this.txtCrypto10.Size = new System.Drawing.Size(637, 27);
            this.txtCrypto10.TabIndex = 10;
            this.txtCrypto10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbgGenerators
            // 
            this.tbgGenerators.Controls.Add(this.tabCrypto);
            this.tbgGenerators.Controls.Add(this.tabWords);
            this.tbgGenerators.Controls.Add(this.tabCVC);
            this.tbgGenerators.Location = new System.Drawing.Point(18, 18);
            this.tbgGenerators.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbgGenerators.Name = "tbgGenerators";
            this.tbgGenerators.SelectedIndex = 0;
            this.tbgGenerators.Size = new System.Drawing.Size(672, 652);
            this.tbgGenerators.TabIndex = 0;
            // 
            // tabCrypto
            // 
            this.tabCrypto.Controls.Add(this.grpCryptoSettings);
            this.tabCrypto.Controls.Add(this.txtCrypto10);
            this.tabCrypto.Controls.Add(this.txtCrypto01);
            this.tabCrypto.Controls.Add(this.txtCrypto09);
            this.tabCrypto.Controls.Add(this.txtCrypto02);
            this.tabCrypto.Controls.Add(this.txtCrypto08);
            this.tabCrypto.Controls.Add(this.txtCrypto03);
            this.tabCrypto.Controls.Add(this.txtCrypto07);
            this.tabCrypto.Controls.Add(this.txtCrypto04);
            this.tabCrypto.Controls.Add(this.txtCrypto06);
            this.tabCrypto.Controls.Add(this.txtCrypto05);
            this.tabCrypto.Location = new System.Drawing.Point(4, 29);
            this.tabCrypto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCrypto.Name = "tabCrypto";
            this.tabCrypto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCrypto.Size = new System.Drawing.Size(664, 619);
            this.tabCrypto.TabIndex = 0;
            this.tabCrypto.Text = "Random";
            this.tabCrypto.UseVisualStyleBackColor = true;
            // 
            // tabWords
            // 
            this.tabWords.Controls.Add(this.txtWords10);
            this.tabWords.Controls.Add(this.txtWords01);
            this.tabWords.Controls.Add(this.txtWords09);
            this.tabWords.Controls.Add(this.txtWords02);
            this.tabWords.Controls.Add(this.txtWords08);
            this.tabWords.Controls.Add(this.txtWords03);
            this.tabWords.Controls.Add(this.txtWords07);
            this.tabWords.Controls.Add(this.txtWords04);
            this.tabWords.Controls.Add(this.txtWords06);
            this.tabWords.Controls.Add(this.txtWords05);
            this.tabWords.Controls.Add(this.grpWordsSettings);
            this.tabWords.Location = new System.Drawing.Point(4, 29);
            this.tabWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWords.Name = "tabWords";
            this.tabWords.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWords.Size = new System.Drawing.Size(664, 619);
            this.tabWords.TabIndex = 1;
            this.tabWords.Text = "Words";
            this.tabWords.UseVisualStyleBackColor = true;
            // 
            // txtWords10
            // 
            this.txtWords10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords10.Location = new System.Drawing.Point(9, 575);
            this.txtWords10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords10.Name = "txtWords10";
            this.txtWords10.ReadOnly = true;
            this.txtWords10.Size = new System.Drawing.Size(637, 27);
            this.txtWords10.TabIndex = 10;
            this.txtWords10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords01
            // 
            this.txtWords01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords01.Location = new System.Drawing.Point(10, 215);
            this.txtWords01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords01.Name = "txtWords01";
            this.txtWords01.ReadOnly = true;
            this.txtWords01.Size = new System.Drawing.Size(637, 27);
            this.txtWords01.TabIndex = 1;
            this.txtWords01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords09
            // 
            this.txtWords09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords09.Location = new System.Drawing.Point(9, 535);
            this.txtWords09.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords09.Name = "txtWords09";
            this.txtWords09.ReadOnly = true;
            this.txtWords09.Size = new System.Drawing.Size(637, 27);
            this.txtWords09.TabIndex = 9;
            this.txtWords09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords02
            // 
            this.txtWords02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords02.Location = new System.Drawing.Point(9, 255);
            this.txtWords02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords02.Name = "txtWords02";
            this.txtWords02.ReadOnly = true;
            this.txtWords02.Size = new System.Drawing.Size(637, 27);
            this.txtWords02.TabIndex = 2;
            this.txtWords02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords08
            // 
            this.txtWords08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords08.Location = new System.Drawing.Point(9, 495);
            this.txtWords08.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords08.Name = "txtWords08";
            this.txtWords08.ReadOnly = true;
            this.txtWords08.Size = new System.Drawing.Size(637, 27);
            this.txtWords08.TabIndex = 8;
            this.txtWords08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords03
            // 
            this.txtWords03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords03.Location = new System.Drawing.Point(9, 295);
            this.txtWords03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords03.Name = "txtWords03";
            this.txtWords03.ReadOnly = true;
            this.txtWords03.Size = new System.Drawing.Size(637, 27);
            this.txtWords03.TabIndex = 3;
            this.txtWords03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords07
            // 
            this.txtWords07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords07.Location = new System.Drawing.Point(9, 455);
            this.txtWords07.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords07.Name = "txtWords07";
            this.txtWords07.ReadOnly = true;
            this.txtWords07.Size = new System.Drawing.Size(637, 27);
            this.txtWords07.TabIndex = 7;
            this.txtWords07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords04
            // 
            this.txtWords04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords04.Location = new System.Drawing.Point(9, 335);
            this.txtWords04.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords04.Name = "txtWords04";
            this.txtWords04.ReadOnly = true;
            this.txtWords04.Size = new System.Drawing.Size(637, 27);
            this.txtWords04.TabIndex = 4;
            this.txtWords04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords06
            // 
            this.txtWords06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords06.Location = new System.Drawing.Point(9, 415);
            this.txtWords06.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords06.Name = "txtWords06";
            this.txtWords06.ReadOnly = true;
            this.txtWords06.Size = new System.Drawing.Size(637, 27);
            this.txtWords06.TabIndex = 6;
            this.txtWords06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords05
            // 
            this.txtWords05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords05.Location = new System.Drawing.Point(9, 375);
            this.txtWords05.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWords05.Name = "txtWords05";
            this.txtWords05.ReadOnly = true;
            this.txtWords05.Size = new System.Drawing.Size(637, 27);
            this.txtWords05.TabIndex = 5;
            this.txtWords05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpWordsSettings
            // 
            this.grpWordsSettings.Controls.Add(this.btnWordsClear);
            this.grpWordsSettings.Controls.Add(this.btnWordsVerb);
            this.grpWordsSettings.Controls.Add(this.btnWordsNoun);
            this.grpWordsSettings.Controls.Add(this.btnWordsAdverb);
            this.grpWordsSettings.Controls.Add(this.btnWordsAdjective);
            this.grpWordsSettings.Controls.Add(this.txtWordsFormat);
            this.grpWordsSettings.Controls.Add(this.btnWordsGenerate);
            this.grpWordsSettings.Location = new System.Drawing.Point(9, 9);
            this.grpWordsSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpWordsSettings.Name = "grpWordsSettings";
            this.grpWordsSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpWordsSettings.Size = new System.Drawing.Size(639, 197);
            this.grpWordsSettings.TabIndex = 0;
            this.grpWordsSettings.TabStop = false;
            this.grpWordsSettings.Text = "Settings";
            // 
            // btnWordsClear
            // 
            this.btnWordsClear.Location = new System.Drawing.Point(513, 29);
            this.btnWordsClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWordsClear.Name = "btnWordsClear";
            this.btnWordsClear.Size = new System.Drawing.Size(112, 35);
            this.btnWordsClear.TabIndex = 4;
            this.btnWordsClear.Text = "Clear";
            this.btnWordsClear.UseVisualStyleBackColor = true;
            this.btnWordsClear.Click += new System.EventHandler(this.btnWordsClear_Click);
            // 
            // btnWordsVerb
            // 
            this.btnWordsVerb.Location = new System.Drawing.Point(387, 29);
            this.btnWordsVerb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWordsVerb.Name = "btnWordsVerb";
            this.btnWordsVerb.Size = new System.Drawing.Size(112, 35);
            this.btnWordsVerb.TabIndex = 3;
            this.btnWordsVerb.Text = "Verb";
            this.btnWordsVerb.UseVisualStyleBackColor = true;
            this.btnWordsVerb.Click += new System.EventHandler(this.btnVerb_Click);
            // 
            // btnWordsNoun
            // 
            this.btnWordsNoun.Location = new System.Drawing.Point(261, 29);
            this.btnWordsNoun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWordsNoun.Name = "btnWordsNoun";
            this.btnWordsNoun.Size = new System.Drawing.Size(112, 35);
            this.btnWordsNoun.TabIndex = 2;
            this.btnWordsNoun.Text = "Noun";
            this.btnWordsNoun.UseVisualStyleBackColor = true;
            this.btnWordsNoun.Click += new System.EventHandler(this.btnNoun_Click);
            // 
            // btnWordsAdverb
            // 
            this.btnWordsAdverb.Location = new System.Drawing.Point(135, 29);
            this.btnWordsAdverb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWordsAdverb.Name = "btnWordsAdverb";
            this.btnWordsAdverb.Size = new System.Drawing.Size(112, 35);
            this.btnWordsAdverb.TabIndex = 1;
            this.btnWordsAdverb.Text = "Adverb";
            this.btnWordsAdverb.UseVisualStyleBackColor = true;
            this.btnWordsAdverb.Click += new System.EventHandler(this.btnAdverb_Click);
            // 
            // btnWordsAdjective
            // 
            this.btnWordsAdjective.Location = new System.Drawing.Point(9, 29);
            this.btnWordsAdjective.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWordsAdjective.Name = "btnWordsAdjective";
            this.btnWordsAdjective.Size = new System.Drawing.Size(112, 35);
            this.btnWordsAdjective.TabIndex = 0;
            this.btnWordsAdjective.Text = "Adjective";
            this.btnWordsAdjective.UseVisualStyleBackColor = true;
            this.btnWordsAdjective.Click += new System.EventHandler(this.btnAdjective_Click);
            // 
            // txtWordsFormat
            // 
            this.txtWordsFormat.Location = new System.Drawing.Point(9, 74);
            this.txtWordsFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWordsFormat.Name = "txtWordsFormat";
            this.txtWordsFormat.ReadOnly = true;
            this.txtWordsFormat.Size = new System.Drawing.Size(619, 26);
            this.txtWordsFormat.TabIndex = 5;
            // 
            // btnWordsGenerate
            // 
            this.btnWordsGenerate.AccessibleName = "Generate";
            this.btnWordsGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWordsGenerate.Location = new System.Drawing.Point(9, 152);
            this.btnWordsGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWordsGenerate.Name = "btnWordsGenerate";
            this.btnWordsGenerate.Size = new System.Drawing.Size(621, 35);
            this.btnWordsGenerate.TabIndex = 6;
            this.btnWordsGenerate.Text = "&Generate";
            this.btnWordsGenerate.UseVisualStyleBackColor = true;
            this.btnWordsGenerate.Click += new System.EventHandler(this.btnGenerateWords_Click);
            // 
            // tabCVC
            // 
            this.tabCVC.Controls.Add(this.grpCVCSettings);
            this.tabCVC.Controls.Add(this.txtCVC10);
            this.tabCVC.Controls.Add(this.txtCVC01);
            this.tabCVC.Controls.Add(this.txtCVC09);
            this.tabCVC.Controls.Add(this.txtCVC02);
            this.tabCVC.Controls.Add(this.txtCVC08);
            this.tabCVC.Controls.Add(this.txtCVC03);
            this.tabCVC.Controls.Add(this.txtCVC07);
            this.tabCVC.Controls.Add(this.txtCVC04);
            this.tabCVC.Controls.Add(this.txtCVC06);
            this.tabCVC.Controls.Add(this.txtCVC05);
            this.tabCVC.Location = new System.Drawing.Point(4, 29);
            this.tabCVC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCVC.Name = "tabCVC";
            this.tabCVC.Size = new System.Drawing.Size(664, 619);
            this.tabCVC.TabIndex = 2;
            this.tabCVC.Text = "CVC";
            this.tabCVC.UseVisualStyleBackColor = true;
            // 
            // grpCVCSettings
            // 
            this.grpCVCSettings.Controls.Add(this.btnCVCGenerate);
            this.grpCVCSettings.Controls.Add(this.numCVCCount);
            this.grpCVCSettings.Controls.Add(this.lblCVCCount);
            this.grpCVCSettings.Location = new System.Drawing.Point(4, 5);
            this.grpCVCSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCVCSettings.Name = "grpCVCSettings";
            this.grpCVCSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCVCSettings.Size = new System.Drawing.Size(648, 202);
            this.grpCVCSettings.TabIndex = 0;
            this.grpCVCSettings.TabStop = false;
            this.grpCVCSettings.Text = "Settings";
            // 
            // btnCVCGenerate
            // 
            this.btnCVCGenerate.AccessibleName = "Generate";
            this.btnCVCGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCVCGenerate.Location = new System.Drawing.Point(9, 157);
            this.btnCVCGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCVCGenerate.Name = "btnCVCGenerate";
            this.btnCVCGenerate.Size = new System.Drawing.Size(630, 35);
            this.btnCVCGenerate.TabIndex = 2;
            this.btnCVCGenerate.Text = "&Generate";
            this.btnCVCGenerate.UseVisualStyleBackColor = true;
            this.btnCVCGenerate.Click += new System.EventHandler(this.btnCVCGenerate_Click);
            // 
            // numCVCCount
            // 
            this.numCVCCount.AccessibleName = "Length";
            this.numCVCCount.Location = new System.Drawing.Point(150, 29);
            this.numCVCCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCVCCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCVCCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCVCCount.Name = "numCVCCount";
            this.numCVCCount.Size = new System.Drawing.Size(180, 26);
            this.numCVCCount.TabIndex = 1;
            this.numCVCCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblCVCCount
            // 
            this.lblCVCCount.AutoSize = true;
            this.lblCVCCount.Location = new System.Drawing.Point(9, 32);
            this.lblCVCCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVCCount.Name = "lblCVCCount";
            this.lblCVCCount.Size = new System.Drawing.Size(52, 20);
            this.lblCVCCount.TabIndex = 0;
            this.lblCVCCount.Text = "Count";
            // 
            // txtCVC10
            // 
            this.txtCVC10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC10.Location = new System.Drawing.Point(9, 575);
            this.txtCVC10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC10.Name = "txtCVC10";
            this.txtCVC10.ReadOnly = true;
            this.txtCVC10.Size = new System.Drawing.Size(637, 27);
            this.txtCVC10.TabIndex = 10;
            this.txtCVC10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC01
            // 
            this.txtCVC01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC01.Location = new System.Drawing.Point(10, 215);
            this.txtCVC01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC01.Name = "txtCVC01";
            this.txtCVC01.ReadOnly = true;
            this.txtCVC01.Size = new System.Drawing.Size(637, 27);
            this.txtCVC01.TabIndex = 1;
            this.txtCVC01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC09
            // 
            this.txtCVC09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC09.Location = new System.Drawing.Point(9, 535);
            this.txtCVC09.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC09.Name = "txtCVC09";
            this.txtCVC09.ReadOnly = true;
            this.txtCVC09.Size = new System.Drawing.Size(637, 27);
            this.txtCVC09.TabIndex = 9;
            this.txtCVC09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC02
            // 
            this.txtCVC02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC02.Location = new System.Drawing.Point(9, 255);
            this.txtCVC02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC02.Name = "txtCVC02";
            this.txtCVC02.ReadOnly = true;
            this.txtCVC02.Size = new System.Drawing.Size(637, 27);
            this.txtCVC02.TabIndex = 2;
            this.txtCVC02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC08
            // 
            this.txtCVC08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC08.Location = new System.Drawing.Point(9, 495);
            this.txtCVC08.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC08.Name = "txtCVC08";
            this.txtCVC08.ReadOnly = true;
            this.txtCVC08.Size = new System.Drawing.Size(637, 27);
            this.txtCVC08.TabIndex = 8;
            this.txtCVC08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC03
            // 
            this.txtCVC03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC03.Location = new System.Drawing.Point(9, 295);
            this.txtCVC03.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC03.Name = "txtCVC03";
            this.txtCVC03.ReadOnly = true;
            this.txtCVC03.Size = new System.Drawing.Size(637, 27);
            this.txtCVC03.TabIndex = 3;
            this.txtCVC03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC07
            // 
            this.txtCVC07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC07.Location = new System.Drawing.Point(9, 455);
            this.txtCVC07.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC07.Name = "txtCVC07";
            this.txtCVC07.ReadOnly = true;
            this.txtCVC07.Size = new System.Drawing.Size(637, 27);
            this.txtCVC07.TabIndex = 7;
            this.txtCVC07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC04
            // 
            this.txtCVC04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC04.Location = new System.Drawing.Point(9, 335);
            this.txtCVC04.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC04.Name = "txtCVC04";
            this.txtCVC04.ReadOnly = true;
            this.txtCVC04.Size = new System.Drawing.Size(637, 27);
            this.txtCVC04.TabIndex = 4;
            this.txtCVC04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC06
            // 
            this.txtCVC06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC06.Location = new System.Drawing.Point(9, 415);
            this.txtCVC06.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC06.Name = "txtCVC06";
            this.txtCVC06.ReadOnly = true;
            this.txtCVC06.Size = new System.Drawing.Size(637, 27);
            this.txtCVC06.TabIndex = 6;
            this.txtCVC06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC05
            // 
            this.txtCVC05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC05.Location = new System.Drawing.Point(9, 375);
            this.txtCVC05.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCVC05.Name = "txtCVC05";
            this.txtCVC05.ReadOnly = true;
            this.txtCVC05.Size = new System.Drawing.Size(637, 27);
            this.txtCVC05.TabIndex = 5;
            this.txtCVC05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPassGen
            // 
            this.AcceptButton = this.btnCryptoGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCryptoGenerate;
            this.ClientSize = new System.Drawing.Size(708, 689);
            this.Controls.Add(this.tbgGenerators);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGen";
            this.Load += new System.EventHandler(this.frmPassGen_Load);
            this.grpCryptoSettings.ResumeLayout(false);
            this.grpCryptoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCryptoLength)).EndInit();
            this.tbgGenerators.ResumeLayout(false);
            this.tabCrypto.ResumeLayout(false);
            this.tabCrypto.PerformLayout();
            this.tabWords.ResumeLayout(false);
            this.tabWords.PerformLayout();
            this.grpWordsSettings.ResumeLayout(false);
            this.grpWordsSettings.PerformLayout();
            this.tabCVC.ResumeLayout(false);
            this.tabCVC.PerformLayout();
            this.grpCVCSettings.ResumeLayout(false);
            this.grpCVCSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCVCCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbgGenerators;
        private System.Windows.Forms.TabPage tabCrypto;
        private System.Windows.Forms.TabPage tabWords;
        private System.Windows.Forms.TabPage tabCVC;

        private System.Windows.Forms.GroupBox grpCryptoSettings;
        private System.Windows.Forms.Label lblCryptoLength;
        private System.Windows.Forms.NumericUpDown numCryptoLength;
        private System.Windows.Forms.Label lblCryptoInclude;
        private System.Windows.Forms.CheckBox chkCryptoSpecial;
        private System.Windows.Forms.CheckBox chkCryptoNumber;
        private System.Windows.Forms.CheckBox chkCryptoUpper;
        private System.Windows.Forms.CheckBox chkCryptoLower;
        private System.Windows.Forms.CheckBox chkCryptoSpace;
        private System.Windows.Forms.CheckBox chkCryptoIncludeAll;
        private System.Windows.Forms.Button btnCryptoGenerate;
        private System.Windows.Forms.TextBox txtCrypto01;
        private System.Windows.Forms.TextBox txtCrypto02;
        private System.Windows.Forms.TextBox txtCrypto03;
        private System.Windows.Forms.TextBox txtCrypto04;
        private System.Windows.Forms.TextBox txtCrypto05;
        private System.Windows.Forms.TextBox txtCrypto06;
        private System.Windows.Forms.TextBox txtCrypto07;
        private System.Windows.Forms.TextBox txtCrypto08;
        private System.Windows.Forms.TextBox txtCrypto09;
        private System.Windows.Forms.TextBox txtCrypto10;
        private System.ComponentModel.BackgroundWorker bkgCryptoGen;

        private System.Windows.Forms.GroupBox grpWordsSettings;
        private System.Windows.Forms.Button btnWordsVerb;
        private System.Windows.Forms.Button btnWordsNoun;
        private System.Windows.Forms.Button btnWordsAdverb;
        private System.Windows.Forms.Button btnWordsAdjective;
        private System.Windows.Forms.TextBox txtWordsFormat;
        private System.Windows.Forms.Button btnWordsGenerate;
        private System.Windows.Forms.Button btnWordsClear;
        private System.Windows.Forms.TextBox txtWords01;
        private System.Windows.Forms.TextBox txtWords02;
        private System.Windows.Forms.TextBox txtWords03;
        private System.Windows.Forms.TextBox txtWords04;
        private System.Windows.Forms.TextBox txtWords05;
        private System.Windows.Forms.TextBox txtWords06;
        private System.Windows.Forms.TextBox txtWords07;
        private System.Windows.Forms.TextBox txtWords08;
        private System.Windows.Forms.TextBox txtWords09;
        private System.Windows.Forms.TextBox txtWords10;
        private System.ComponentModel.BackgroundWorker bkgWordsGen;


        private System.Windows.Forms.GroupBox grpCVCSettings;
        private System.Windows.Forms.Label lblCVCCount;
        private System.Windows.Forms.NumericUpDown numCVCCount;
        private System.Windows.Forms.Button btnCVCGenerate;
        private System.Windows.Forms.TextBox txtCVC01;
        private System.Windows.Forms.TextBox txtCVC02;
        private System.Windows.Forms.TextBox txtCVC03;
        private System.Windows.Forms.TextBox txtCVC04;
        private System.Windows.Forms.TextBox txtCVC05;
        private System.Windows.Forms.TextBox txtCVC06;
        private System.Windows.Forms.TextBox txtCVC07;
        private System.Windows.Forms.TextBox txtCVC08;
        private System.Windows.Forms.TextBox txtCVC09;
        private System.Windows.Forms.TextBox txtCVC10;
        private System.ComponentModel.BackgroundWorker bkgCVCGen;
    }
}

