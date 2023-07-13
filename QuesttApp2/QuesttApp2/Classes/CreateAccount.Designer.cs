namespace QuesttApp2.Classes
{
    partial class CreateAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstNameTbb = new System.Windows.Forms.TextBox();
            this.FirstNameTb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DepartmentTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxBtn = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SenderTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SenderPassTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(618, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 450);
            this.panel1.TabIndex = 0;
            // 
            // FirstNameTbb
            // 
            this.FirstNameTbb.Location = new System.Drawing.Point(12, 50);
            this.FirstNameTbb.Name = "FirstNameTbb";
            this.FirstNameTbb.Size = new System.Drawing.Size(253, 22);
            this.FirstNameTbb.TabIndex = 1;
            this.FirstNameTbb.TextChanged += new System.EventHandler(this.UsernameTb_TextChanged);
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.AutoSize = true;
            this.FirstNameTb.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTb.Location = new System.Drawing.Point(12, 25);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(106, 22);
            this.FirstNameTb.TabIndex = 2;
            this.FirstNameTb.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(12, 110);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(253, 22);
            this.LastNameTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // UsernameTb
            // 
            this.UsernameTb.Location = new System.Drawing.Point(12, 177);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(253, 22);
            this.UsernameTb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(12, 239);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(253, 22);
            this.EmailTb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Another"});
            this.GenderCb.Location = new System.Drawing.Point(12, 302);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(247, 24);
            this.GenderCb.TabIndex = 11;
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(16, 387);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(120, 39);
            this.CreateBtn.TabIndex = 12;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(145, 387);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(120, 39);
            this.LoginBtn.TabIndex = 13;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Department";
            // 
            // DepartmentTb
            // 
            this.DepartmentTb.Location = new System.Drawing.Point(297, 50);
            this.DepartmentTb.Name = "DepartmentTb";
            this.DepartmentTb.Size = new System.Drawing.Size(253, 22);
            this.DepartmentTb.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Is Admin";
            // 
            // CheckBoxBtn
            // 
            this.CheckBoxBtn.AutoSize = true;
            this.CheckBoxBtn.Location = new System.Drawing.Point(301, 111);
            this.CheckBoxBtn.Name = "CheckBoxBtn";
            this.CheckBoxBtn.Size = new System.Drawing.Size(67, 20);
            this.CheckBoxBtn.TabIndex = 17;
            this.CheckBoxBtn.Text = "Admin";
            this.CheckBoxBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sender Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SenderTb
            // 
            this.SenderTb.Location = new System.Drawing.Point(297, 177);
            this.SenderTb.Name = "SenderTb";
            this.SenderTb.Size = new System.Drawing.Size(253, 22);
            this.SenderTb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sender Password";
            // 
            // SenderPassTb
            // 
            this.SenderPassTb.Location = new System.Drawing.Point(293, 239);
            this.SenderPassTb.Name = "SenderPassTb";
            this.SenderPassTb.Size = new System.Drawing.Size(253, 22);
            this.SenderPassTb.TabIndex = 20;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SenderPassTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SenderTb);
            this.Controls.Add(this.CheckBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DepartmentTb);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.FirstNameTb);
            this.Controls.Add(this.FirstNameTbb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FirstNameTbb;
        private System.Windows.Forms.Label FirstNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DepartmentTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SenderTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SenderPassTb;
    }
}