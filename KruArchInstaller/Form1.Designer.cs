namespace KruArchInstaller
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnConfAcct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAcctDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnConfirmPackages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAccounts = new System.Windows.Forms.CheckBox();
            this.cbPackages = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdoDMNone = new System.Windows.Forms.RadioButton();
            this.rdoDMLightDM = new System.Windows.Forms.RadioButton();
            this.rdoDMGDM = new System.Windows.Forms.RadioButton();
            this.gbDesktop = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRootPW = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.875F));
            this.tableLayoutPanel1.Controls.Add(this.lblWelcome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.111111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(116, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(681, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the KruArch Installer";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(116, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 404);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Some Text Describing the Distro or this installer.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRootPW);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.maskedTextBox1);
            this.tabPage2.Controls.Add(this.btnConfAcct);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblAcctDesc);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(67, 57);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // btnConfAcct
            // 
            this.btnConfAcct.Location = new System.Drawing.Point(592, 350);
            this.btnConfAcct.Name = "btnConfAcct";
            this.btnConfAcct.Size = new System.Drawing.Size(75, 23);
            this.btnConfAcct.TabIndex = 6;
            this.btnConfAcct.Text = "Confirm Step";
            this.btnConfAcct.UseVisualStyleBackColor = true;
            this.btnConfAcct.Click += new System.EventHandler(this.btnConfAcct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // lblAcctDesc
            // 
            this.lblAcctDesc.AutoSize = true;
            this.lblAcctDesc.Location = new System.Drawing.Point(6, 8);
            this.lblAcctDesc.Name = "lblAcctDesc";
            this.lblAcctDesc.Size = new System.Drawing.Size(251, 13);
            this.lblAcctDesc.TabIndex = 0;
            this.lblAcctDesc.Text = "Please, Enter your desired username and password.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbDesktop);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnConfirmPackages);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPackages
            // 
            this.btnConfirmPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmPackages.Location = new System.Drawing.Point(592, 349);
            this.btnConfirmPackages.Name = "btnConfirmPackages";
            this.btnConfirmPackages.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmPackages.TabIndex = 7;
            this.btnConfirmPackages.Text = "Confirm Step";
            this.btnConfirmPackages.UseVisualStyleBackColor = true;
            this.btnConfirmPackages.Click += new System.EventHandler(this.btnConfirmPackages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remaining Steps:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbAccounts);
            this.flowLayoutPanel1.Controls.Add(this.cbPackages);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(107, 404);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // cbAccounts
            // 
            this.cbAccounts.AutoSize = true;
            this.cbAccounts.Enabled = false;
            this.cbAccounts.Location = new System.Drawing.Point(3, 3);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(66, 17);
            this.cbAccounts.TabIndex = 0;
            this.cbAccounts.Text = "Account";
            this.cbAccounts.UseVisualStyleBackColor = true;
            // 
            // cbPackages
            // 
            this.cbPackages.AutoSize = true;
            this.cbPackages.Enabled = false;
            this.cbPackages.Location = new System.Drawing.Point(3, 26);
            this.cbPackages.Name = "cbPackages";
            this.cbPackages.Size = new System.Drawing.Size(107, 17);
            this.cbPackages.TabIndex = 1;
            this.cbPackages.Text = "Select Packages";
            this.cbPackages.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select the Desktop and other packages you want, and specify additional packages i" +
    "f needed.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDMGDM);
            this.groupBox1.Controls.Add(this.rdoDMLightDM);
            this.groupBox1.Controls.Add(this.rdoDMNone);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Manager";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "sudo?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rdoDMNone
            // 
            this.rdoDMNone.AutoSize = true;
            this.rdoDMNone.Location = new System.Drawing.Point(6, 19);
            this.rdoDMNone.Name = "rdoDMNone";
            this.rdoDMNone.Size = new System.Drawing.Size(51, 17);
            this.rdoDMNone.TabIndex = 0;
            this.rdoDMNone.TabStop = true;
            this.rdoDMNone.Text = "None";
            this.rdoDMNone.UseVisualStyleBackColor = true;
            // 
            // rdoDMLightDM
            // 
            this.rdoDMLightDM.AutoSize = true;
            this.rdoDMLightDM.Location = new System.Drawing.Point(6, 42);
            this.rdoDMLightDM.Name = "rdoDMLightDM";
            this.rdoDMLightDM.Size = new System.Drawing.Size(65, 17);
            this.rdoDMLightDM.TabIndex = 1;
            this.rdoDMLightDM.TabStop = true;
            this.rdoDMLightDM.Text = "LightDM";
            this.rdoDMLightDM.UseVisualStyleBackColor = true;
            // 
            // rdoDMGDM
            // 
            this.rdoDMGDM.AutoSize = true;
            this.rdoDMGDM.Location = new System.Drawing.Point(6, 66);
            this.rdoDMGDM.Name = "rdoDMGDM";
            this.rdoDMGDM.Size = new System.Drawing.Size(50, 17);
            this.rdoDMGDM.TabIndex = 2;
            this.rdoDMGDM.TabStop = true;
            this.rdoDMGDM.Text = "GDM";
            this.rdoDMGDM.UseVisualStyleBackColor = true;
            // 
            // gbDesktop
            // 
            this.gbDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDesktop.Controls.Add(this.checkBox4);
            this.gbDesktop.Controls.Add(this.checkBox3);
            this.gbDesktop.Controls.Add(this.checkBox2);
            this.gbDesktop.Location = new System.Drawing.Point(334, 24);
            this.gbDesktop.Name = "gbDesktop";
            this.gbDesktop.Size = new System.Drawing.Size(333, 100);
            this.gbDesktop.TabIndex = 10;
            this.gbDesktop.TabStop = false;
            this.gbDesktop.Text = "Desktop";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Gnome 3";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 42);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "KDE";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Budgie";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Root Password:";
            // 
            // tbRootPW
            // 
            this.tbRootPW.Location = new System.Drawing.Point(9, 119);
            this.tbRootPW.Name = "tbRootPW";
            this.tbRootPW.Size = new System.Drawing.Size(248, 20);
            this.tbRootPW.TabIndex = 10;
            this.tbRootPW.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDesktop.ResumeLayout(false);
            this.gbDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAcctDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cbAccounts;
        private System.Windows.Forms.CheckBox cbPackages;
        private System.Windows.Forms.Button btnConfAcct;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnConfirmPackages;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbDesktop;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDMGDM;
        private System.Windows.Forms.RadioButton rdoDMLightDM;
        private System.Windows.Forms.RadioButton rdoDMNone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbRootPW;
        private System.Windows.Forms.Label label6;
    }
}

