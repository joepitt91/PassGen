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
            this.chkSpace = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkIncludeAll = new System.Windows.Forms.CheckBox();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.lblInclude = new System.Windows.Forms.Label();
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
            this.btnVerb = new System.Windows.Forms.Button();
            this.btnNoun = new System.Windows.Forms.Button();
            this.btnAdverb = new System.Windows.Forms.Button();
            this.btnAdjective = new System.Windows.Forms.Button();
            this.txtWordsFormat = new System.Windows.Forms.TextBox();
            this.btnGenerateWords = new System.Windows.Forms.Button();
            this.bkgWordsGen = new System.ComponentModel.BackgroundWorker();
            this.grpCryptoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.tbgGenerators.SuspendLayout();
            this.tabCrypto.SuspendLayout();
            this.tabWords.SuspendLayout();
            this.grpWordsSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCryptoSettings
            // 
            this.grpCryptoSettings.Controls.Add(this.chkSpace);
            this.grpCryptoSettings.Controls.Add(this.btnGenerate);
            this.grpCryptoSettings.Controls.Add(this.chkIncludeAll);
            this.grpCryptoSettings.Controls.Add(this.numLength);
            this.grpCryptoSettings.Controls.Add(this.lblLength);
            this.grpCryptoSettings.Controls.Add(this.chkSpecial);
            this.grpCryptoSettings.Controls.Add(this.chkNumber);
            this.grpCryptoSettings.Controls.Add(this.chkUpper);
            this.grpCryptoSettings.Controls.Add(this.chkLower);
            this.grpCryptoSettings.Controls.Add(this.lblInclude);
            this.grpCryptoSettings.Location = new System.Drawing.Point(6, 6);
            this.grpCryptoSettings.Name = "grpCryptoSettings";
            this.grpCryptoSettings.Size = new System.Drawing.Size(420, 120);
            this.grpCryptoSettings.TabIndex = 0;
            this.grpCryptoSettings.TabStop = false;
            this.grpCryptoSettings.Text = "Settings";
            // 
            // chkSpace
            // 
            this.chkSpace.AccessibleName = "Space";
            this.chkSpace.AutoSize = true;
            this.chkSpace.Location = new System.Drawing.Point(323, 19);
            this.chkSpace.Name = "chkSpace";
            this.chkSpace.Size = new System.Drawing.Size(57, 17);
            this.chkSpace.TabIndex = 5;
            this.chkSpace.Text = "Space";
            this.chkSpace.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AccessibleName = "Generate";
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerate.Location = new System.Drawing.Point(6, 91);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(408, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkIncludeAll
            // 
            this.chkIncludeAll.AccessibleName = "Must Include All Types Ticked Above";
            this.chkIncludeAll.AutoSize = true;
            this.chkIncludeAll.Checked = true;
            this.chkIncludeAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeAll.Location = new System.Drawing.Point(60, 42);
            this.chkIncludeAll.Name = "chkIncludeAll";
            this.chkIncludeAll.Size = new System.Drawing.Size(203, 17);
            this.chkIncludeAll.TabIndex = 6;
            this.chkIncludeAll.Text = "Must Include All Types Ticked Above";
            this.chkIncludeAll.UseVisualStyleBackColor = true;
            // 
            // numLength
            // 
            this.numLength.AccessibleName = "Length";
            this.numLength.Location = new System.Drawing.Point(60, 65);
            this.numLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 20);
            this.numLength.TabIndex = 8;
            this.numLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(6, 67);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length";
            // 
            // chkSpecial
            // 
            this.chkSpecial.AccessibleName = "Special Characters";
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Checked = true;
            this.chkSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecial.Location = new System.Drawing.Point(202, 19);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(115, 17);
            this.chkSpecial.TabIndex = 4;
            this.chkSpecial.Text = "Special Characters";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AccessibleName = "Numbers";
            this.chkNumber.AutoSize = true;
            this.chkNumber.Checked = true;
            this.chkNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumber.Location = new System.Drawing.Point(155, 19);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(41, 17);
            this.chkNumber.TabIndex = 3;
            this.chkNumber.Text = "0-9";
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AccessibleName = "Upper Case";
            this.chkUpper.AutoSize = true;
            this.chkUpper.Checked = true;
            this.chkUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpper.Location = new System.Drawing.Point(106, 19);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(43, 17);
            this.chkUpper.TabIndex = 2;
            this.chkUpper.Text = "A-Z";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AccessibleName = "Lower Case";
            this.chkLower.AutoSize = true;
            this.chkLower.Checked = true;
            this.chkLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLower.Location = new System.Drawing.Point(60, 19);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(40, 17);
            this.chkLower.TabIndex = 1;
            this.chkLower.Text = "a-z";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.Location = new System.Drawing.Point(6, 20);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(48, 13);
            this.lblInclude.TabIndex = 0;
            this.lblInclude.Text = "Include: ";
            // 
            // txtCrypto01
            // 
            this.txtCrypto01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto01.Location = new System.Drawing.Point(5, 132);
            this.txtCrypto01.Name = "txtCrypto01";
            this.txtCrypto01.ReadOnly = true;
            this.txtCrypto01.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto01.TabIndex = 1;
            this.txtCrypto01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto02
            // 
            this.txtCrypto02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto02.Location = new System.Drawing.Point(4, 158);
            this.txtCrypto02.Name = "txtCrypto02";
            this.txtCrypto02.ReadOnly = true;
            this.txtCrypto02.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto02.TabIndex = 2;
            this.txtCrypto02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto03
            // 
            this.txtCrypto03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto03.Location = new System.Drawing.Point(4, 184);
            this.txtCrypto03.Name = "txtCrypto03";
            this.txtCrypto03.ReadOnly = true;
            this.txtCrypto03.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto03.TabIndex = 3;
            this.txtCrypto03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto04
            // 
            this.txtCrypto04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto04.Location = new System.Drawing.Point(4, 210);
            this.txtCrypto04.Name = "txtCrypto04";
            this.txtCrypto04.ReadOnly = true;
            this.txtCrypto04.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto04.TabIndex = 4;
            this.txtCrypto04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto05
            // 
            this.txtCrypto05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto05.Location = new System.Drawing.Point(4, 236);
            this.txtCrypto05.Name = "txtCrypto05";
            this.txtCrypto05.ReadOnly = true;
            this.txtCrypto05.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto05.TabIndex = 5;
            this.txtCrypto05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto06
            // 
            this.txtCrypto06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto06.Location = new System.Drawing.Point(4, 262);
            this.txtCrypto06.Name = "txtCrypto06";
            this.txtCrypto06.ReadOnly = true;
            this.txtCrypto06.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto06.TabIndex = 6;
            this.txtCrypto06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto07
            // 
            this.txtCrypto07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto07.Location = new System.Drawing.Point(4, 288);
            this.txtCrypto07.Name = "txtCrypto07";
            this.txtCrypto07.ReadOnly = true;
            this.txtCrypto07.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto07.TabIndex = 7;
            this.txtCrypto07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto08
            // 
            this.txtCrypto08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto08.Location = new System.Drawing.Point(4, 314);
            this.txtCrypto08.Name = "txtCrypto08";
            this.txtCrypto08.ReadOnly = true;
            this.txtCrypto08.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto08.TabIndex = 8;
            this.txtCrypto08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto09
            // 
            this.txtCrypto09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto09.Location = new System.Drawing.Point(4, 340);
            this.txtCrypto09.Name = "txtCrypto09";
            this.txtCrypto09.ReadOnly = true;
            this.txtCrypto09.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto09.TabIndex = 9;
            this.txtCrypto09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto10
            // 
            this.txtCrypto10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto10.Location = new System.Drawing.Point(4, 366);
            this.txtCrypto10.Name = "txtCrypto10";
            this.txtCrypto10.ReadOnly = true;
            this.txtCrypto10.Size = new System.Drawing.Size(420, 20);
            this.txtCrypto10.TabIndex = 10;
            this.txtCrypto10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbgGenerators
            // 
            this.tbgGenerators.Controls.Add(this.tabCrypto);
            this.tbgGenerators.Controls.Add(this.tabWords);
            this.tbgGenerators.Location = new System.Drawing.Point(13, 13);
            this.tbgGenerators.Name = "tbgGenerators";
            this.tbgGenerators.SelectedIndex = 0;
            this.tbgGenerators.Size = new System.Drawing.Size(446, 426);
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
            this.tabCrypto.Location = new System.Drawing.Point(4, 22);
            this.tabCrypto.Name = "tabCrypto";
            this.tabCrypto.Padding = new System.Windows.Forms.Padding(3);
            this.tabCrypto.Size = new System.Drawing.Size(438, 400);
            this.tabCrypto.TabIndex = 0;
            this.tabCrypto.Text = "Crypto Random";
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
            this.tabWords.Location = new System.Drawing.Point(4, 22);
            this.tabWords.Name = "tabWords";
            this.tabWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabWords.Size = new System.Drawing.Size(438, 400);
            this.tabWords.TabIndex = 1;
            this.tabWords.Text = "Random Words";
            this.tabWords.UseVisualStyleBackColor = true;
            // 
            // txtWords10
            // 
            this.txtWords10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords10.Location = new System.Drawing.Point(5, 366);
            this.txtWords10.Name = "txtWords10";
            this.txtWords10.ReadOnly = true;
            this.txtWords10.Size = new System.Drawing.Size(420, 20);
            this.txtWords10.TabIndex = 10;
            this.txtWords10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords01
            // 
            this.txtWords01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords01.Location = new System.Drawing.Point(6, 132);
            this.txtWords01.Name = "txtWords01";
            this.txtWords01.ReadOnly = true;
            this.txtWords01.Size = new System.Drawing.Size(420, 20);
            this.txtWords01.TabIndex = 1;
            this.txtWords01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords09
            // 
            this.txtWords09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords09.Location = new System.Drawing.Point(5, 340);
            this.txtWords09.Name = "txtWords09";
            this.txtWords09.ReadOnly = true;
            this.txtWords09.Size = new System.Drawing.Size(420, 20);
            this.txtWords09.TabIndex = 9;
            this.txtWords09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords02
            // 
            this.txtWords02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords02.Location = new System.Drawing.Point(5, 158);
            this.txtWords02.Name = "txtWords02";
            this.txtWords02.ReadOnly = true;
            this.txtWords02.Size = new System.Drawing.Size(420, 20);
            this.txtWords02.TabIndex = 2;
            this.txtWords02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords08
            // 
            this.txtWords08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords08.Location = new System.Drawing.Point(5, 314);
            this.txtWords08.Name = "txtWords08";
            this.txtWords08.ReadOnly = true;
            this.txtWords08.Size = new System.Drawing.Size(420, 20);
            this.txtWords08.TabIndex = 8;
            this.txtWords08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords03
            // 
            this.txtWords03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords03.Location = new System.Drawing.Point(5, 184);
            this.txtWords03.Name = "txtWords03";
            this.txtWords03.ReadOnly = true;
            this.txtWords03.Size = new System.Drawing.Size(420, 20);
            this.txtWords03.TabIndex = 3;
            this.txtWords03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords07
            // 
            this.txtWords07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords07.Location = new System.Drawing.Point(5, 288);
            this.txtWords07.Name = "txtWords07";
            this.txtWords07.ReadOnly = true;
            this.txtWords07.Size = new System.Drawing.Size(420, 20);
            this.txtWords07.TabIndex = 7;
            this.txtWords07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords04
            // 
            this.txtWords04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords04.Location = new System.Drawing.Point(5, 210);
            this.txtWords04.Name = "txtWords04";
            this.txtWords04.ReadOnly = true;
            this.txtWords04.Size = new System.Drawing.Size(420, 20);
            this.txtWords04.TabIndex = 4;
            this.txtWords04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords06
            // 
            this.txtWords06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords06.Location = new System.Drawing.Point(5, 262);
            this.txtWords06.Name = "txtWords06";
            this.txtWords06.ReadOnly = true;
            this.txtWords06.Size = new System.Drawing.Size(420, 20);
            this.txtWords06.TabIndex = 6;
            this.txtWords06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords05
            // 
            this.txtWords05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords05.Location = new System.Drawing.Point(5, 236);
            this.txtWords05.Name = "txtWords05";
            this.txtWords05.ReadOnly = true;
            this.txtWords05.Size = new System.Drawing.Size(420, 20);
            this.txtWords05.TabIndex = 5;
            this.txtWords05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpWordsSettings
            // 
            this.grpWordsSettings.Controls.Add(this.btnWordsClear);
            this.grpWordsSettings.Controls.Add(this.btnVerb);
            this.grpWordsSettings.Controls.Add(this.btnNoun);
            this.grpWordsSettings.Controls.Add(this.btnAdverb);
            this.grpWordsSettings.Controls.Add(this.btnAdjective);
            this.grpWordsSettings.Controls.Add(this.txtWordsFormat);
            this.grpWordsSettings.Controls.Add(this.btnGenerateWords);
            this.grpWordsSettings.Location = new System.Drawing.Point(6, 6);
            this.grpWordsSettings.Name = "grpWordsSettings";
            this.grpWordsSettings.Size = new System.Drawing.Size(420, 120);
            this.grpWordsSettings.TabIndex = 0;
            this.grpWordsSettings.TabStop = false;
            this.grpWordsSettings.Text = "Settings";
            // 
            // btnWordsClear
            // 
            this.btnWordsClear.Location = new System.Drawing.Point(330, 19);
            this.btnWordsClear.Name = "btnWordsClear";
            this.btnWordsClear.Size = new System.Drawing.Size(75, 23);
            this.btnWordsClear.TabIndex = 4;
            this.btnWordsClear.Text = "Clear";
            this.btnWordsClear.UseVisualStyleBackColor = true;
            this.btnWordsClear.Click += new System.EventHandler(this.btnWordsClear_Click);
            // 
            // btnVerb
            // 
            this.btnVerb.Location = new System.Drawing.Point(249, 19);
            this.btnVerb.Name = "btnVerb";
            this.btnVerb.Size = new System.Drawing.Size(75, 23);
            this.btnVerb.TabIndex = 3;
            this.btnVerb.Text = "Verb";
            this.btnVerb.UseVisualStyleBackColor = true;
            this.btnVerb.Click += new System.EventHandler(this.btnVerb_Click);
            // 
            // btnNoun
            // 
            this.btnNoun.Location = new System.Drawing.Point(168, 19);
            this.btnNoun.Name = "btnNoun";
            this.btnNoun.Size = new System.Drawing.Size(75, 23);
            this.btnNoun.TabIndex = 2;
            this.btnNoun.Text = "Noun";
            this.btnNoun.UseVisualStyleBackColor = true;
            this.btnNoun.Click += new System.EventHandler(this.btnNoun_Click);
            // 
            // btnAdverb
            // 
            this.btnAdverb.Location = new System.Drawing.Point(87, 19);
            this.btnAdverb.Name = "btnAdverb";
            this.btnAdverb.Size = new System.Drawing.Size(75, 23);
            this.btnAdverb.TabIndex = 1;
            this.btnAdverb.Text = "Adverb";
            this.btnAdverb.UseVisualStyleBackColor = true;
            this.btnAdverb.Click += new System.EventHandler(this.btnAdverb_Click);
            // 
            // btnAdjective
            // 
            this.btnAdjective.Location = new System.Drawing.Point(6, 19);
            this.btnAdjective.Name = "btnAdjective";
            this.btnAdjective.Size = new System.Drawing.Size(75, 23);
            this.btnAdjective.TabIndex = 0;
            this.btnAdjective.Text = "Adjective";
            this.btnAdjective.UseVisualStyleBackColor = true;
            this.btnAdjective.Click += new System.EventHandler(this.btnAdjective_Click);
            // 
            // txtWordsFormat
            // 
            this.txtWordsFormat.Location = new System.Drawing.Point(6, 65);
            this.txtWordsFormat.Name = "txtWordsFormat";
            this.txtWordsFormat.ReadOnly = true;
            this.txtWordsFormat.Size = new System.Drawing.Size(408, 20);
            this.txtWordsFormat.TabIndex = 5;
            this.txtWordsFormat.Text = "AdverbAdjectiveNoun";
            // 
            // btnGenerateWords
            // 
            this.btnGenerateWords.AccessibleName = "Generate";
            this.btnGenerateWords.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerateWords.Location = new System.Drawing.Point(6, 91);
            this.btnGenerateWords.Name = "btnGenerateWords";
            this.btnGenerateWords.Size = new System.Drawing.Size(408, 23);
            this.btnGenerateWords.TabIndex = 6;
            this.btnGenerateWords.Text = "&Generate";
            this.btnGenerateWords.UseVisualStyleBackColor = true;
            this.btnGenerateWords.Click += new System.EventHandler(this.btnGenerateWords_Click);
            // 
            // frmPassGen
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGenerate;
            this.ClientSize = new System.Drawing.Size(472, 448);
            this.Controls.Add(this.tbgGenerators);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGen";
            this.Load += new System.EventHandler(this.frmPassGen_Load);
            this.grpCryptoSettings.ResumeLayout(false);
            this.grpCryptoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.tbgGenerators.ResumeLayout(false);
            this.tabCrypto.ResumeLayout(false);
            this.tabCrypto.PerformLayout();
            this.tabWords.ResumeLayout(false);
            this.tabWords.PerformLayout();
            this.grpWordsSettings.ResumeLayout(false);
            this.grpWordsSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCryptoSettings;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkIncludeAll;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.Label lblInclude;
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
        private System.Windows.Forms.CheckBox chkSpace;
        private System.ComponentModel.BackgroundWorker bkgCryptoGen;
        private System.Windows.Forms.TabControl tbgGenerators;
        private System.Windows.Forms.TabPage tabCrypto;
        private System.Windows.Forms.TabPage tabWords;
        private System.Windows.Forms.GroupBox grpWordsSettings;
        private System.Windows.Forms.Button btnVerb;
        private System.Windows.Forms.Button btnNoun;
        private System.Windows.Forms.Button btnAdverb;
        private System.Windows.Forms.Button btnAdjective;
        private System.Windows.Forms.TextBox txtWordsFormat;
        private System.Windows.Forms.Button btnGenerateWords;
        private System.Windows.Forms.Button btnWordsClear;
        private System.Windows.Forms.TextBox txtWords10;
        private System.Windows.Forms.TextBox txtWords01;
        private System.Windows.Forms.TextBox txtWords09;
        private System.Windows.Forms.TextBox txtWords02;
        private System.Windows.Forms.TextBox txtWords08;
        private System.Windows.Forms.TextBox txtWords03;
        private System.Windows.Forms.TextBox txtWords07;
        private System.Windows.Forms.TextBox txtWords04;
        private System.Windows.Forms.TextBox txtWords06;
        private System.Windows.Forms.TextBox txtWords05;
        private System.ComponentModel.BackgroundWorker bkgWordsGen;
    }
}

