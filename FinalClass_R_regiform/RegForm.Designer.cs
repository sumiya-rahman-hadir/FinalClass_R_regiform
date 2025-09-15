namespace FinalClass_R_regiform
{
    partial class RegForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.chkCplus = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(199, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(161, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(273, 50);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 40);
            this.txtName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(273, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(193, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // dtpDob
            // 
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Location = new System.Drawing.Point(273, 159);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(371, 27);
            this.dtpDob.TabIndex = 4;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(209, 161);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(58, 25);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "DOB";
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(3, 5);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(58, 20);
            this.rdbmale.TabIndex = 6;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(105, 5);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(74, 20);
            this.rdbfemale.TabIndex = 7;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(184, 207);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbmale);
            this.panel1.Controls.Add(this.rdbfemale);
            this.panel1.Location = new System.Drawing.Point(273, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 38);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Skill";
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(273, 262);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(59, 20);
            this.chkJava.TabIndex = 11;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Location = new System.Drawing.Point(338, 262);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(45, 20);
            this.chkCsharp.TabIndex = 12;
            this.chkCsharp.Text = "C#";
            this.chkCsharp.UseVisualStyleBackColor = true;
            // 
            // chkCplus
            // 
            this.chkCplus.AutoSize = true;
            this.chkCplus.Location = new System.Drawing.Point(389, 262);
            this.chkCplus.Name = "chkCplus";
            this.chkCplus.Size = new System.Drawing.Size(52, 20);
            this.chkCplus.TabIndex = 13;
            this.chkCplus.Text = "C++";
            this.chkCplus.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkCplus);
            this.Controls.Add(this.chkCsharp);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.CheckBox chkCplus;
    }
}