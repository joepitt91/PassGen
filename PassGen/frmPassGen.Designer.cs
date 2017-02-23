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
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lnkDonate = new System.Windows.Forms.LinkLabel();
            this.btnResetCVC = new System.Windows.Forms.Button();
            this.btnResetWords = new System.Windows.Forms.Button();
            this.btnResetCrypto = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.lnkSourceCode = new System.Windows.Forms.LinkLabel();
            this.lnkUserGuideOffline = new System.Windows.Forms.LinkLabel();
            this.lnkUserGuideOnline = new System.Windows.Forms.LinkLabel();
            this.lnkProjectPage = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAboutGeneral = new System.Windows.Forms.TextBox();
            this.picAboutLogo = new System.Windows.Forms.PictureBox();
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
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutLogo)).BeginInit();
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
            this.grpCryptoSettings.Location = new System.Drawing.Point(6, 6);
            this.grpCryptoSettings.Name = "grpCryptoSettings";
            this.grpCryptoSettings.Size = new System.Drawing.Size(426, 128);
            this.grpCryptoSettings.TabIndex = 0;
            this.grpCryptoSettings.TabStop = false;
            this.grpCryptoSettings.Text = "Settings";
            // 
            // chkCryptoSpace
            // 
            this.chkCryptoSpace.AccessibleName = "Space";
            this.chkCryptoSpace.AutoSize = true;
            this.chkCryptoSpace.Location = new System.Drawing.Point(363, 19);
            this.chkCryptoSpace.Name = "chkCryptoSpace";
            this.chkCryptoSpace.Size = new System.Drawing.Size(57, 17);
            this.chkCryptoSpace.TabIndex = 5;
            this.chkCryptoSpace.Text = "Space";
            this.chkCryptoSpace.UseVisualStyleBackColor = true;
            // 
            // btnCryptoGenerate
            // 
            this.btnCryptoGenerate.AccessibleName = "Generate";
            this.btnCryptoGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCryptoGenerate.Location = new System.Drawing.Point(6, 99);
            this.btnCryptoGenerate.Name = "btnCryptoGenerate";
            this.btnCryptoGenerate.Size = new System.Drawing.Size(414, 23);
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
            this.chkCryptoIncludeAll.Location = new System.Drawing.Point(100, 42);
            this.chkCryptoIncludeAll.Name = "chkCryptoIncludeAll";
            this.chkCryptoIncludeAll.Size = new System.Drawing.Size(203, 17);
            this.chkCryptoIncludeAll.TabIndex = 6;
            this.chkCryptoIncludeAll.Text = "Must Include All Types Ticked Above";
            this.chkCryptoIncludeAll.UseVisualStyleBackColor = true;
            // 
            // numCryptoLength
            // 
            this.numCryptoLength.AccessibleName = "Length";
            this.numCryptoLength.Location = new System.Drawing.Point(100, 65);
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
            this.numCryptoLength.Size = new System.Drawing.Size(120, 20);
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
            this.lblCryptoLength.Location = new System.Drawing.Point(6, 67);
            this.lblCryptoLength.Name = "lblCryptoLength";
            this.lblCryptoLength.Size = new System.Drawing.Size(40, 13);
            this.lblCryptoLength.TabIndex = 7;
            this.lblCryptoLength.Text = "Length";
            // 
            // chkCryptoSpecial
            // 
            this.chkCryptoSpecial.AccessibleName = "Special Characters";
            this.chkCryptoSpecial.AutoSize = true;
            this.chkCryptoSpecial.Checked = true;
            this.chkCryptoSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCryptoSpecial.Location = new System.Drawing.Point(242, 19);
            this.chkCryptoSpecial.Name = "chkCryptoSpecial";
            this.chkCryptoSpecial.Size = new System.Drawing.Size(115, 17);
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
            this.chkCryptoNumber.Location = new System.Drawing.Point(195, 19);
            this.chkCryptoNumber.Name = "chkCryptoNumber";
            this.chkCryptoNumber.Size = new System.Drawing.Size(41, 17);
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
            this.chkCryptoUpper.Location = new System.Drawing.Point(146, 19);
            this.chkCryptoUpper.Name = "chkCryptoUpper";
            this.chkCryptoUpper.Size = new System.Drawing.Size(43, 17);
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
            this.chkCryptoLower.Location = new System.Drawing.Point(100, 19);
            this.chkCryptoLower.Name = "chkCryptoLower";
            this.chkCryptoLower.Size = new System.Drawing.Size(40, 17);
            this.chkCryptoLower.TabIndex = 1;
            this.chkCryptoLower.Text = "a-z";
            this.chkCryptoLower.UseVisualStyleBackColor = true;
            // 
            // lblCryptoInclude
            // 
            this.lblCryptoInclude.AutoSize = true;
            this.lblCryptoInclude.Location = new System.Drawing.Point(6, 20);
            this.lblCryptoInclude.Name = "lblCryptoInclude";
            this.lblCryptoInclude.Size = new System.Drawing.Size(48, 13);
            this.lblCryptoInclude.TabIndex = 0;
            this.lblCryptoInclude.Text = "Include: ";
            // 
            // txtCrypto01
            // 
            this.txtCrypto01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto01.Location = new System.Drawing.Point(7, 140);
            this.txtCrypto01.Name = "txtCrypto01";
            this.txtCrypto01.ReadOnly = true;
            this.txtCrypto01.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto01.TabIndex = 1;
            this.txtCrypto01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto02
            // 
            this.txtCrypto02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto02.Location = new System.Drawing.Point(6, 166);
            this.txtCrypto02.Name = "txtCrypto02";
            this.txtCrypto02.ReadOnly = true;
            this.txtCrypto02.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto02.TabIndex = 2;
            this.txtCrypto02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto03
            // 
            this.txtCrypto03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto03.Location = new System.Drawing.Point(6, 192);
            this.txtCrypto03.Name = "txtCrypto03";
            this.txtCrypto03.ReadOnly = true;
            this.txtCrypto03.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto03.TabIndex = 3;
            this.txtCrypto03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto04
            // 
            this.txtCrypto04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto04.Location = new System.Drawing.Point(6, 218);
            this.txtCrypto04.Name = "txtCrypto04";
            this.txtCrypto04.ReadOnly = true;
            this.txtCrypto04.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto04.TabIndex = 4;
            this.txtCrypto04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto05
            // 
            this.txtCrypto05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto05.Location = new System.Drawing.Point(6, 244);
            this.txtCrypto05.Name = "txtCrypto05";
            this.txtCrypto05.ReadOnly = true;
            this.txtCrypto05.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto05.TabIndex = 5;
            this.txtCrypto05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto06
            // 
            this.txtCrypto06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto06.Location = new System.Drawing.Point(6, 270);
            this.txtCrypto06.Name = "txtCrypto06";
            this.txtCrypto06.ReadOnly = true;
            this.txtCrypto06.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto06.TabIndex = 6;
            this.txtCrypto06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto07
            // 
            this.txtCrypto07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto07.Location = new System.Drawing.Point(6, 296);
            this.txtCrypto07.Name = "txtCrypto07";
            this.txtCrypto07.ReadOnly = true;
            this.txtCrypto07.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto07.TabIndex = 7;
            this.txtCrypto07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto08
            // 
            this.txtCrypto08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto08.Location = new System.Drawing.Point(6, 322);
            this.txtCrypto08.Name = "txtCrypto08";
            this.txtCrypto08.ReadOnly = true;
            this.txtCrypto08.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto08.TabIndex = 8;
            this.txtCrypto08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto09
            // 
            this.txtCrypto09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto09.Location = new System.Drawing.Point(6, 348);
            this.txtCrypto09.Name = "txtCrypto09";
            this.txtCrypto09.ReadOnly = true;
            this.txtCrypto09.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto09.TabIndex = 9;
            this.txtCrypto09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrypto10
            // 
            this.txtCrypto10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypto10.Location = new System.Drawing.Point(6, 374);
            this.txtCrypto10.Name = "txtCrypto10";
            this.txtCrypto10.ReadOnly = true;
            this.txtCrypto10.Size = new System.Drawing.Size(426, 20);
            this.txtCrypto10.TabIndex = 10;
            this.txtCrypto10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbgGenerators
            // 
            this.tbgGenerators.Controls.Add(this.tabCrypto);
            this.tbgGenerators.Controls.Add(this.tabWords);
            this.tbgGenerators.Controls.Add(this.tabCVC);
            this.tbgGenerators.Controls.Add(this.tabAbout);
            this.tbgGenerators.Location = new System.Drawing.Point(12, 12);
            this.tbgGenerators.Name = "tbgGenerators";
            this.tbgGenerators.SelectedIndex = 0;
            this.tbgGenerators.Size = new System.Drawing.Size(448, 424);
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
            this.tabCrypto.Size = new System.Drawing.Size(440, 398);
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
            this.tabWords.Size = new System.Drawing.Size(440, 398);
            this.tabWords.TabIndex = 1;
            this.tabWords.Text = "Random Words";
            this.tabWords.UseVisualStyleBackColor = true;
            // 
            // txtWords10
            // 
            this.txtWords10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords10.Location = new System.Drawing.Point(6, 374);
            this.txtWords10.Name = "txtWords10";
            this.txtWords10.ReadOnly = true;
            this.txtWords10.Size = new System.Drawing.Size(426, 20);
            this.txtWords10.TabIndex = 10;
            this.txtWords10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords01
            // 
            this.txtWords01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords01.Location = new System.Drawing.Point(7, 140);
            this.txtWords01.Name = "txtWords01";
            this.txtWords01.ReadOnly = true;
            this.txtWords01.Size = new System.Drawing.Size(426, 20);
            this.txtWords01.TabIndex = 1;
            this.txtWords01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords09
            // 
            this.txtWords09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords09.Location = new System.Drawing.Point(6, 348);
            this.txtWords09.Name = "txtWords09";
            this.txtWords09.ReadOnly = true;
            this.txtWords09.Size = new System.Drawing.Size(426, 20);
            this.txtWords09.TabIndex = 9;
            this.txtWords09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords02
            // 
            this.txtWords02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords02.Location = new System.Drawing.Point(6, 166);
            this.txtWords02.Name = "txtWords02";
            this.txtWords02.ReadOnly = true;
            this.txtWords02.Size = new System.Drawing.Size(426, 20);
            this.txtWords02.TabIndex = 2;
            this.txtWords02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords08
            // 
            this.txtWords08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords08.Location = new System.Drawing.Point(6, 322);
            this.txtWords08.Name = "txtWords08";
            this.txtWords08.ReadOnly = true;
            this.txtWords08.Size = new System.Drawing.Size(426, 20);
            this.txtWords08.TabIndex = 8;
            this.txtWords08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords03
            // 
            this.txtWords03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords03.Location = new System.Drawing.Point(6, 192);
            this.txtWords03.Name = "txtWords03";
            this.txtWords03.ReadOnly = true;
            this.txtWords03.Size = new System.Drawing.Size(426, 20);
            this.txtWords03.TabIndex = 3;
            this.txtWords03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords07
            // 
            this.txtWords07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords07.Location = new System.Drawing.Point(6, 296);
            this.txtWords07.Name = "txtWords07";
            this.txtWords07.ReadOnly = true;
            this.txtWords07.Size = new System.Drawing.Size(426, 20);
            this.txtWords07.TabIndex = 7;
            this.txtWords07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords04
            // 
            this.txtWords04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords04.Location = new System.Drawing.Point(6, 218);
            this.txtWords04.Name = "txtWords04";
            this.txtWords04.ReadOnly = true;
            this.txtWords04.Size = new System.Drawing.Size(426, 20);
            this.txtWords04.TabIndex = 4;
            this.txtWords04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords06
            // 
            this.txtWords06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords06.Location = new System.Drawing.Point(6, 270);
            this.txtWords06.Name = "txtWords06";
            this.txtWords06.ReadOnly = true;
            this.txtWords06.Size = new System.Drawing.Size(426, 20);
            this.txtWords06.TabIndex = 6;
            this.txtWords06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWords05
            // 
            this.txtWords05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords05.Location = new System.Drawing.Point(6, 244);
            this.txtWords05.Name = "txtWords05";
            this.txtWords05.ReadOnly = true;
            this.txtWords05.Size = new System.Drawing.Size(426, 20);
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
            this.grpWordsSettings.Location = new System.Drawing.Point(6, 6);
            this.grpWordsSettings.Name = "grpWordsSettings";
            this.grpWordsSettings.Size = new System.Drawing.Size(426, 128);
            this.grpWordsSettings.TabIndex = 0;
            this.grpWordsSettings.TabStop = false;
            this.grpWordsSettings.Text = "Settings";
            // 
            // btnWordsClear
            // 
            this.btnWordsClear.Location = new System.Drawing.Point(342, 19);
            this.btnWordsClear.Name = "btnWordsClear";
            this.btnWordsClear.Size = new System.Drawing.Size(75, 23);
            this.btnWordsClear.TabIndex = 4;
            this.btnWordsClear.Text = "Clear";
            this.btnWordsClear.UseVisualStyleBackColor = true;
            this.btnWordsClear.Click += new System.EventHandler(this.btnWordsClear_Click);
            // 
            // btnWordsVerb
            // 
            this.btnWordsVerb.Location = new System.Drawing.Point(258, 19);
            this.btnWordsVerb.Name = "btnWordsVerb";
            this.btnWordsVerb.Size = new System.Drawing.Size(75, 23);
            this.btnWordsVerb.TabIndex = 3;
            this.btnWordsVerb.Text = "Verb";
            this.btnWordsVerb.UseVisualStyleBackColor = true;
            this.btnWordsVerb.Click += new System.EventHandler(this.btnVerb_Click);
            // 
            // btnWordsNoun
            // 
            this.btnWordsNoun.Location = new System.Drawing.Point(174, 19);
            this.btnWordsNoun.Name = "btnWordsNoun";
            this.btnWordsNoun.Size = new System.Drawing.Size(75, 23);
            this.btnWordsNoun.TabIndex = 2;
            this.btnWordsNoun.Text = "Noun";
            this.btnWordsNoun.UseVisualStyleBackColor = true;
            this.btnWordsNoun.Click += new System.EventHandler(this.btnNoun_Click);
            // 
            // btnWordsAdverb
            // 
            this.btnWordsAdverb.Location = new System.Drawing.Point(90, 19);
            this.btnWordsAdverb.Name = "btnWordsAdverb";
            this.btnWordsAdverb.Size = new System.Drawing.Size(75, 23);
            this.btnWordsAdverb.TabIndex = 1;
            this.btnWordsAdverb.Text = "Adverb";
            this.btnWordsAdverb.UseVisualStyleBackColor = true;
            this.btnWordsAdverb.Click += new System.EventHandler(this.btnAdverb_Click);
            // 
            // btnWordsAdjective
            // 
            this.btnWordsAdjective.Location = new System.Drawing.Point(6, 19);
            this.btnWordsAdjective.Name = "btnWordsAdjective";
            this.btnWordsAdjective.Size = new System.Drawing.Size(75, 23);
            this.btnWordsAdjective.TabIndex = 0;
            this.btnWordsAdjective.Text = "Adjective";
            this.btnWordsAdjective.UseVisualStyleBackColor = true;
            this.btnWordsAdjective.Click += new System.EventHandler(this.btnAdjective_Click);
            // 
            // txtWordsFormat
            // 
            this.txtWordsFormat.Location = new System.Drawing.Point(6, 48);
            this.txtWordsFormat.Name = "txtWordsFormat";
            this.txtWordsFormat.ReadOnly = true;
            this.txtWordsFormat.Size = new System.Drawing.Size(414, 20);
            this.txtWordsFormat.TabIndex = 5;
            // 
            // btnWordsGenerate
            // 
            this.btnWordsGenerate.AccessibleName = "Generate";
            this.btnWordsGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWordsGenerate.Location = new System.Drawing.Point(6, 99);
            this.btnWordsGenerate.Name = "btnWordsGenerate";
            this.btnWordsGenerate.Size = new System.Drawing.Size(414, 23);
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
            this.tabCVC.Location = new System.Drawing.Point(4, 22);
            this.tabCVC.Name = "tabCVC";
            this.tabCVC.Size = new System.Drawing.Size(440, 398);
            this.tabCVC.TabIndex = 2;
            this.tabCVC.Text = "CVC";
            this.tabCVC.UseVisualStyleBackColor = true;
            // 
            // grpCVCSettings
            // 
            this.grpCVCSettings.Controls.Add(this.btnCVCGenerate);
            this.grpCVCSettings.Controls.Add(this.numCVCCount);
            this.grpCVCSettings.Controls.Add(this.lblCVCCount);
            this.grpCVCSettings.Location = new System.Drawing.Point(3, 3);
            this.grpCVCSettings.Name = "grpCVCSettings";
            this.grpCVCSettings.Size = new System.Drawing.Size(432, 131);
            this.grpCVCSettings.TabIndex = 0;
            this.grpCVCSettings.TabStop = false;
            this.grpCVCSettings.Text = "Settings";
            // 
            // btnCVCGenerate
            // 
            this.btnCVCGenerate.AccessibleName = "Generate";
            this.btnCVCGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCVCGenerate.Location = new System.Drawing.Point(6, 102);
            this.btnCVCGenerate.Name = "btnCVCGenerate";
            this.btnCVCGenerate.Size = new System.Drawing.Size(420, 23);
            this.btnCVCGenerate.TabIndex = 2;
            this.btnCVCGenerate.Text = "&Generate";
            this.btnCVCGenerate.UseVisualStyleBackColor = true;
            this.btnCVCGenerate.Click += new System.EventHandler(this.btnCVCGenerate_Click);
            // 
            // numCVCCount
            // 
            this.numCVCCount.AccessibleName = "Length";
            this.numCVCCount.Location = new System.Drawing.Point(100, 19);
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
            this.numCVCCount.Size = new System.Drawing.Size(120, 20);
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
            this.lblCVCCount.Location = new System.Drawing.Point(6, 21);
            this.lblCVCCount.Name = "lblCVCCount";
            this.lblCVCCount.Size = new System.Drawing.Size(35, 13);
            this.lblCVCCount.TabIndex = 0;
            this.lblCVCCount.Text = "Count";
            // 
            // txtCVC10
            // 
            this.txtCVC10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC10.Location = new System.Drawing.Point(6, 374);
            this.txtCVC10.Name = "txtCVC10";
            this.txtCVC10.ReadOnly = true;
            this.txtCVC10.Size = new System.Drawing.Size(426, 20);
            this.txtCVC10.TabIndex = 10;
            this.txtCVC10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC01
            // 
            this.txtCVC01.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC01.Location = new System.Drawing.Point(7, 140);
            this.txtCVC01.Name = "txtCVC01";
            this.txtCVC01.ReadOnly = true;
            this.txtCVC01.Size = new System.Drawing.Size(426, 20);
            this.txtCVC01.TabIndex = 1;
            this.txtCVC01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC09
            // 
            this.txtCVC09.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC09.Location = new System.Drawing.Point(6, 348);
            this.txtCVC09.Name = "txtCVC09";
            this.txtCVC09.ReadOnly = true;
            this.txtCVC09.Size = new System.Drawing.Size(426, 20);
            this.txtCVC09.TabIndex = 9;
            this.txtCVC09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC02
            // 
            this.txtCVC02.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC02.Location = new System.Drawing.Point(6, 166);
            this.txtCVC02.Name = "txtCVC02";
            this.txtCVC02.ReadOnly = true;
            this.txtCVC02.Size = new System.Drawing.Size(426, 20);
            this.txtCVC02.TabIndex = 2;
            this.txtCVC02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC08
            // 
            this.txtCVC08.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC08.Location = new System.Drawing.Point(6, 322);
            this.txtCVC08.Name = "txtCVC08";
            this.txtCVC08.ReadOnly = true;
            this.txtCVC08.Size = new System.Drawing.Size(426, 20);
            this.txtCVC08.TabIndex = 8;
            this.txtCVC08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC03
            // 
            this.txtCVC03.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC03.Location = new System.Drawing.Point(6, 192);
            this.txtCVC03.Name = "txtCVC03";
            this.txtCVC03.ReadOnly = true;
            this.txtCVC03.Size = new System.Drawing.Size(426, 20);
            this.txtCVC03.TabIndex = 3;
            this.txtCVC03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC07
            // 
            this.txtCVC07.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC07.Location = new System.Drawing.Point(6, 296);
            this.txtCVC07.Name = "txtCVC07";
            this.txtCVC07.ReadOnly = true;
            this.txtCVC07.Size = new System.Drawing.Size(426, 20);
            this.txtCVC07.TabIndex = 7;
            this.txtCVC07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC04
            // 
            this.txtCVC04.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC04.Location = new System.Drawing.Point(6, 218);
            this.txtCVC04.Name = "txtCVC04";
            this.txtCVC04.ReadOnly = true;
            this.txtCVC04.Size = new System.Drawing.Size(426, 20);
            this.txtCVC04.TabIndex = 4;
            this.txtCVC04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC06
            // 
            this.txtCVC06.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC06.Location = new System.Drawing.Point(6, 270);
            this.txtCVC06.Name = "txtCVC06";
            this.txtCVC06.ReadOnly = true;
            this.txtCVC06.Size = new System.Drawing.Size(426, 20);
            this.txtCVC06.TabIndex = 6;
            this.txtCVC06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCVC05
            // 
            this.txtCVC05.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC05.Location = new System.Drawing.Point(6, 244);
            this.txtCVC05.Name = "txtCVC05";
            this.txtCVC05.ReadOnly = true;
            this.txtCVC05.Size = new System.Drawing.Size(426, 20);
            this.txtCVC05.TabIndex = 5;
            this.txtCVC05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lnkDonate);
            this.tabAbout.Controls.Add(this.btnResetCVC);
            this.tabAbout.Controls.Add(this.btnResetWords);
            this.tabAbout.Controls.Add(this.btnResetCrypto);
            this.tabAbout.Controls.Add(this.btnResetAll);
            this.tabAbout.Controls.Add(this.lnkSourceCode);
            this.tabAbout.Controls.Add(this.lnkUserGuideOffline);
            this.tabAbout.Controls.Add(this.lnkUserGuideOnline);
            this.tabAbout.Controls.Add(this.lnkProjectPage);
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.txtAboutGeneral);
            this.tabAbout.Controls.Add(this.picAboutLogo);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(440, 398);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lnkDonate
            // 
            this.lnkDonate.AccessibleName = "";
            this.lnkDonate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lnkDonate.AutoSize = true;
            this.lnkDonate.Location = new System.Drawing.Point(390, 175);
            this.lnkDonate.Name = "lnkDonate";
            this.lnkDonate.Size = new System.Drawing.Size(42, 13);
            this.lnkDonate.TabIndex = 5;
            this.lnkDonate.TabStop = true;
            this.lnkDonate.Text = "Donate";
            this.lnkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDonate_LinkClicked);
            // 
            // btnResetCVC
            // 
            this.btnResetCVC.Location = new System.Drawing.Point(223, 242);
            this.btnResetCVC.Name = "btnResetCVC";
            this.btnResetCVC.Size = new System.Drawing.Size(214, 23);
            this.btnResetCVC.TabIndex = 9;
            this.btnResetCVC.Text = "Reset CVC Generator";
            this.btnResetCVC.UseVisualStyleBackColor = true;
            this.btnResetCVC.Click += new System.EventHandler(this.btnResetCVC_Click);
            // 
            // btnResetWords
            // 
            this.btnResetWords.Location = new System.Drawing.Point(3, 242);
            this.btnResetWords.Name = "btnResetWords";
            this.btnResetWords.Size = new System.Drawing.Size(214, 23);
            this.btnResetWords.TabIndex = 8;
            this.btnResetWords.Text = "Reset Random Words Generator";
            this.btnResetWords.UseVisualStyleBackColor = true;
            this.btnResetWords.Click += new System.EventHandler(this.btnResetWords_Click);
            // 
            // btnResetCrypto
            // 
            this.btnResetCrypto.Location = new System.Drawing.Point(223, 213);
            this.btnResetCrypto.Name = "btnResetCrypto";
            this.btnResetCrypto.Size = new System.Drawing.Size(214, 23);
            this.btnResetCrypto.TabIndex = 7;
            this.btnResetCrypto.Text = "Reset Crypto Random Generator";
            this.btnResetCrypto.UseVisualStyleBackColor = true;
            this.btnResetCrypto.Click += new System.EventHandler(this.btnResetCrypto_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(3, 213);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(214, 23);
            this.btnResetAll.TabIndex = 6;
            this.btnResetAll.Text = "Reset All Generators";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // lnkSourceCode
            // 
            this.lnkSourceCode.AccessibleName = "";
            this.lnkSourceCode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lnkSourceCode.AutoSize = true;
            this.lnkSourceCode.Location = new System.Drawing.Point(308, 175);
            this.lnkSourceCode.Name = "lnkSourceCode";
            this.lnkSourceCode.Size = new System.Drawing.Size(69, 13);
            this.lnkSourceCode.TabIndex = 4;
            this.lnkSourceCode.TabStop = true;
            this.lnkSourceCode.Text = "Source Code";
            this.lnkSourceCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSourceCode_LinkClicked);
            // 
            // lnkUserGuideOffline
            // 
            this.lnkUserGuideOffline.AccessibleName = "";
            this.lnkUserGuideOffline.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lnkUserGuideOffline.AutoSize = true;
            this.lnkUserGuideOffline.Location = new System.Drawing.Point(196, 175);
            this.lnkUserGuideOffline.Name = "lnkUserGuideOffline";
            this.lnkUserGuideOffline.Size = new System.Drawing.Size(99, 13);
            this.lnkUserGuideOffline.TabIndex = 3;
            this.lnkUserGuideOffline.TabStop = true;
            this.lnkUserGuideOffline.Text = "User Guide (Offline)";
            this.lnkUserGuideOffline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUserGuideOffline_LinkClicked);
            // 
            // lnkUserGuideOnline
            // 
            this.lnkUserGuideOnline.AccessibleName = "";
            this.lnkUserGuideOnline.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lnkUserGuideOnline.AutoSize = true;
            this.lnkUserGuideOnline.Location = new System.Drawing.Point(84, 175);
            this.lnkUserGuideOnline.Name = "lnkUserGuideOnline";
            this.lnkUserGuideOnline.Size = new System.Drawing.Size(99, 13);
            this.lnkUserGuideOnline.TabIndex = 2;
            this.lnkUserGuideOnline.TabStop = true;
            this.lnkUserGuideOnline.Text = "User Guide (Online)";
            this.lnkUserGuideOnline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUserGuideOnline_LinkClicked);
            // 
            // lnkProjectPage
            // 
            this.lnkProjectPage.AccessibleName = "";
            this.lnkProjectPage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lnkProjectPage.AutoSize = true;
            this.lnkProjectPage.Location = new System.Drawing.Point(3, 175);
            this.lnkProjectPage.Name = "lnkProjectPage";
            this.lnkProjectPage.Size = new System.Drawing.Size(68, 13);
            this.lnkProjectPage.TabIndex = 1;
            this.lnkProjectPage.TabStop = true;
            this.lnkProjectPage.Text = "Project Page";
            this.lnkProjectPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProjectPage_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JoePitt.PassGen.Properties.Resources.cc_by_nc_sa;
            this.pictureBox1.Location = new System.Drawing.Point(337, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtAboutGeneral
            // 
            this.txtAboutGeneral.AccessibleName = "";
            this.txtAboutGeneral.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtAboutGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAboutGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAboutGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAboutGeneral.Location = new System.Drawing.Point(6, 3);
            this.txtAboutGeneral.Multiline = true;
            this.txtAboutGeneral.Name = "txtAboutGeneral";
            this.txtAboutGeneral.ReadOnly = true;
            this.txtAboutGeneral.Size = new System.Drawing.Size(325, 156);
            this.txtAboutGeneral.TabIndex = 0;
            this.txtAboutGeneral.Text = "PassGen by Joe Pitt\r\n\r\nv2.1 (2017-02-23)\r\n\r\nhttps://www.joepitt.co.uk/Project/Pas" +
    "sGen/\r\n\r\nLicensed under a Creative Commons Attribution-NonCommercial-ShareAlike " +
    "4.0 International Public License.";
            // 
            // picAboutLogo
            // 
            this.picAboutLogo.Image = global::JoePitt.PassGen.Properties.Resources.Logo;
            this.picAboutLogo.Location = new System.Drawing.Point(337, 3);
            this.picAboutLogo.Name = "picAboutLogo";
            this.picAboutLogo.Size = new System.Drawing.Size(100, 100);
            this.picAboutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAboutLogo.TabIndex = 0;
            this.picAboutLogo.TabStop = false;
            // 
            // frmPassGen
            // 
            this.AcceptButton = this.btnCryptoGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCryptoGenerate;
            this.ClientSize = new System.Drawing.Size(472, 448);
            this.Controls.Add(this.tbgGenerators);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutLogo)).EndInit();
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
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.PictureBox picAboutLogo;
        private System.Windows.Forms.Button btnResetCVC;
        private System.Windows.Forms.Button btnResetWords;
        private System.Windows.Forms.Button btnResetCrypto;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.LinkLabel lnkSourceCode;
        private System.Windows.Forms.LinkLabel lnkUserGuideOffline;
        private System.Windows.Forms.LinkLabel lnkUserGuideOnline;
        private System.Windows.Forms.LinkLabel lnkProjectPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAboutGeneral;
        private System.Windows.Forms.LinkLabel lnkDonate;
    }
}

