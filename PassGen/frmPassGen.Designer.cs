namespace PassGen
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
            this.grpSettings = new System.Windows.Forms.GroupBox();
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
            this.txtPass01 = new System.Windows.Forms.TextBox();
            this.txtPass02 = new System.Windows.Forms.TextBox();
            this.txtPass03 = new System.Windows.Forms.TextBox();
            this.txtPass04 = new System.Windows.Forms.TextBox();
            this.txtPass05 = new System.Windows.Forms.TextBox();
            this.txtPass06 = new System.Windows.Forms.TextBox();
            this.txtPass07 = new System.Windows.Forms.TextBox();
            this.txtPass08 = new System.Windows.Forms.TextBox();
            this.txtPass09 = new System.Windows.Forms.TextBox();
            this.txtPass10 = new System.Windows.Forms.TextBox();
            this.bkgGetPasswords = new System.ComponentModel.BackgroundWorker();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.chkSpace);
            this.grpSettings.Controls.Add(this.btnGenerate);
            this.grpSettings.Controls.Add(this.chkIncludeAll);
            this.grpSettings.Controls.Add(this.numLength);
            this.grpSettings.Controls.Add(this.lblLength);
            this.grpSettings.Controls.Add(this.chkSpecial);
            this.grpSettings.Controls.Add(this.chkNumber);
            this.grpSettings.Controls.Add(this.chkUpper);
            this.grpSettings.Controls.Add(this.chkLower);
            this.grpSettings.Controls.Add(this.lblInclude);
            this.grpSettings.Location = new System.Drawing.Point(13, 13);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(420, 120);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
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
            // txtPass01
            // 
            this.txtPass01.Location = new System.Drawing.Point(12, 139);
            this.txtPass01.Name = "txtPass01";
            this.txtPass01.ReadOnly = true;
            this.txtPass01.Size = new System.Drawing.Size(420, 20);
            this.txtPass01.TabIndex = 1;
            this.txtPass01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass02
            // 
            this.txtPass02.Location = new System.Drawing.Point(11, 165);
            this.txtPass02.Name = "txtPass02";
            this.txtPass02.ReadOnly = true;
            this.txtPass02.Size = new System.Drawing.Size(420, 20);
            this.txtPass02.TabIndex = 2;
            this.txtPass02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass03
            // 
            this.txtPass03.Location = new System.Drawing.Point(11, 191);
            this.txtPass03.Name = "txtPass03";
            this.txtPass03.ReadOnly = true;
            this.txtPass03.Size = new System.Drawing.Size(420, 20);
            this.txtPass03.TabIndex = 3;
            this.txtPass03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass04
            // 
            this.txtPass04.Location = new System.Drawing.Point(11, 217);
            this.txtPass04.Name = "txtPass04";
            this.txtPass04.ReadOnly = true;
            this.txtPass04.Size = new System.Drawing.Size(420, 20);
            this.txtPass04.TabIndex = 4;
            this.txtPass04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass05
            // 
            this.txtPass05.Location = new System.Drawing.Point(11, 243);
            this.txtPass05.Name = "txtPass05";
            this.txtPass05.ReadOnly = true;
            this.txtPass05.Size = new System.Drawing.Size(420, 20);
            this.txtPass05.TabIndex = 5;
            this.txtPass05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass06
            // 
            this.txtPass06.Location = new System.Drawing.Point(11, 269);
            this.txtPass06.Name = "txtPass06";
            this.txtPass06.ReadOnly = true;
            this.txtPass06.Size = new System.Drawing.Size(420, 20);
            this.txtPass06.TabIndex = 6;
            this.txtPass06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass07
            // 
            this.txtPass07.Location = new System.Drawing.Point(11, 295);
            this.txtPass07.Name = "txtPass07";
            this.txtPass07.ReadOnly = true;
            this.txtPass07.Size = new System.Drawing.Size(420, 20);
            this.txtPass07.TabIndex = 7;
            this.txtPass07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass08
            // 
            this.txtPass08.Location = new System.Drawing.Point(11, 321);
            this.txtPass08.Name = "txtPass08";
            this.txtPass08.ReadOnly = true;
            this.txtPass08.Size = new System.Drawing.Size(420, 20);
            this.txtPass08.TabIndex = 8;
            this.txtPass08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass09
            // 
            this.txtPass09.Location = new System.Drawing.Point(11, 347);
            this.txtPass09.Name = "txtPass09";
            this.txtPass09.ReadOnly = true;
            this.txtPass09.Size = new System.Drawing.Size(420, 20);
            this.txtPass09.TabIndex = 9;
            this.txtPass09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass10
            // 
            this.txtPass10.Location = new System.Drawing.Point(11, 373);
            this.txtPass10.Name = "txtPass10";
            this.txtPass10.ReadOnly = true;
            this.txtPass10.Size = new System.Drawing.Size(420, 20);
            this.txtPass10.TabIndex = 10;
            this.txtPass10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bkgGetPasswords
            // 
            this.bkgGetPasswords.WorkerSupportsCancellation = true;
            // 
            // frmPassGen
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGenerate;
            this.ClientSize = new System.Drawing.Size(444, 407);
            this.Controls.Add(this.txtPass10);
            this.Controls.Add(this.txtPass09);
            this.Controls.Add(this.txtPass08);
            this.Controls.Add(this.txtPass07);
            this.Controls.Add(this.txtPass06);
            this.Controls.Add(this.txtPass05);
            this.Controls.Add(this.txtPass04);
            this.Controls.Add(this.txtPass03);
            this.Controls.Add(this.txtPass02);
            this.Controls.Add(this.txtPass01);
            this.Controls.Add(this.grpSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGen";
            this.Load += new System.EventHandler(this.frmPassGen_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkIncludeAll;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.TextBox txtPass01;
        private System.Windows.Forms.TextBox txtPass02;
        private System.Windows.Forms.TextBox txtPass03;
        private System.Windows.Forms.TextBox txtPass04;
        private System.Windows.Forms.TextBox txtPass05;
        private System.Windows.Forms.TextBox txtPass06;
        private System.Windows.Forms.TextBox txtPass07;
        private System.Windows.Forms.TextBox txtPass08;
        private System.Windows.Forms.TextBox txtPass09;
        private System.Windows.Forms.TextBox txtPass10;
        private System.Windows.Forms.CheckBox chkSpace;
        private System.ComponentModel.BackgroundWorker bkgGetPasswords;
    }
}

