namespace QuesttApp2.Classes
{
    partial class Employees
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProviderNameTb = new System.Windows.Forms.TextBox();
            this.DocumentNumberTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrencyCb = new System.Windows.Forms.ComboBox();
            this.DateTb = new System.Windows.Forms.DateTimePicker();
            this.CostTypeTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.IdTbl = new System.Windows.Forms.TextBox();
            this.IdTb = new System.Windows.Forms.Label();
            this.EmployeeListerTb = new System.Windows.Forms.DataGridView();
            this.ExcelFileBtn = new System.Windows.Forms.Button();
            this.TotalSumBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListerTb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider Name";
            // 
            // ProviderNameTb
            // 
            this.ProviderNameTb.Location = new System.Drawing.Point(48, 77);
            this.ProviderNameTb.Name = "ProviderNameTb";
            this.ProviderNameTb.Size = new System.Drawing.Size(365, 22);
            this.ProviderNameTb.TabIndex = 1;
            // 
            // DocumentNumberTb
            // 
            this.DocumentNumberTb.Location = new System.Drawing.Point(48, 163);
            this.DocumentNumberTb.Name = "DocumentNumberTb";
            this.DocumentNumberTb.Size = new System.Drawing.Size(365, 22);
            this.DocumentNumberTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Document Number";
            // 
            // DataTb
            // 
            this.DataTb.Location = new System.Drawing.Point(48, 249);
            this.DataTb.Name = "DataTb";
            this.DataTb.Size = new System.Drawing.Size(365, 22);
            this.DataTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // AmountTb
            // 
            this.AmountTb.Location = new System.Drawing.Point(48, 410);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(365, 22);
            this.AmountTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Currency";
            // 
            // CurrencyCb
            // 
            this.CurrencyCb.FormattingEnabled = true;
            this.CurrencyCb.Items.AddRange(new object[] {
            "AED",
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "DKK",
            "EGP",
            "EUR",
            "GBP",
            "HUF",
            "INR",
            "JPY",
            "KRW",
            "LEU",
            "MDL",
            "MXN",
            "NOK",
            "NZD",
            "PLN",
            "RSD",
            "RUB",
            "SEK",
            "THB",
            "TRY",
            "UAH",
            "USD",
            "XAU",
            "XDR",
            "ZAR"});
            this.CurrencyCb.Location = new System.Drawing.Point(48, 508);
            this.CurrencyCb.Name = "CurrencyCb";
            this.CurrencyCb.Size = new System.Drawing.Size(371, 24);
            this.CurrencyCb.TabIndex = 12;
            // 
            // DateTb
            // 
            this.DateTb.Location = new System.Drawing.Point(470, 81);
            this.DateTb.Name = "DateTb";
            this.DateTb.Size = new System.Drawing.Size(197, 22);
            this.DateTb.TabIndex = 13;
            // 
            // CostTypeTb
            // 
            this.CostTypeTb.Location = new System.Drawing.Point(48, 328);
            this.CostTypeTb.Name = "CostTypeTb";
            this.CostTypeTb.Size = new System.Drawing.Size(365, 22);
            this.CostTypeTb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cost Type";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(13, 567);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(87, 32);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(106, 568);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(92, 32);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(206, 568);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(87, 32);
            this.LoginBtn.TabIndex = 18;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // IdTbl
            // 
            this.IdTbl.Location = new System.Drawing.Point(456, 163);
            this.IdTbl.Name = "IdTbl";
            this.IdTbl.Size = new System.Drawing.Size(216, 22);
            this.IdTbl.TabIndex = 20;
            // 
            // IdTb
            // 
            this.IdTb.AutoSize = true;
            this.IdTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(454, 121);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(41, 32);
            this.IdTb.TabIndex = 19;
            this.IdTb.Text = "Id";
            // 
            // EmployeeListerTb
            // 
            this.EmployeeListerTb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeListerTb.Location = new System.Drawing.Point(503, 216);
            this.EmployeeListerTb.Name = "EmployeeListerTb";
            this.EmployeeListerTb.RowHeadersWidth = 51;
            this.EmployeeListerTb.RowTemplate.Height = 24;
            this.EmployeeListerTb.Size = new System.Drawing.Size(767, 383);
            this.EmployeeListerTb.TabIndex = 21;
            this.EmployeeListerTb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeListerTb_CellContentClick);
            // 
            // ExcelFileBtn
            // 
            this.ExcelFileBtn.Location = new System.Drawing.Point(301, 568);
            this.ExcelFileBtn.Name = "ExcelFileBtn";
            this.ExcelFileBtn.Size = new System.Drawing.Size(95, 32);
            this.ExcelFileBtn.TabIndex = 22;
            this.ExcelFileBtn.Text = "ExcelFile";
            this.ExcelFileBtn.UseVisualStyleBackColor = true;
            this.ExcelFileBtn.Click += new System.EventHandler(this.ExcelFileBtn_Click);
            // 
            // TotalSumBtn
            // 
            this.TotalSumBtn.Location = new System.Drawing.Point(402, 568);
            this.TotalSumBtn.Name = "TotalSumBtn";
            this.TotalSumBtn.Size = new System.Drawing.Size(95, 32);
            this.TotalSumBtn.TabIndex = 23;
            this.TotalSumBtn.Text = "TotalSum";
            this.TotalSumBtn.UseVisualStyleBackColor = true;
            this.TotalSumBtn.Click += new System.EventHandler(this.TotalSumBtn_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1300, 622);
            this.Controls.Add(this.TotalSumBtn);
            this.Controls.Add(this.ExcelFileBtn);
            this.Controls.Add(this.EmployeeListerTb);
            this.Controls.Add(this.IdTbl);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CostTypeTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTb);
            this.Controls.Add(this.CurrencyCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocumentNumberTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProviderNameTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeListerTb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProviderNameTb;
        private System.Windows.Forms.TextBox DocumentNumberTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CurrencyCb;
        private System.Windows.Forms.DateTimePicker DateTb;
        private System.Windows.Forms.TextBox CostTypeTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox IdTbl;
        private System.Windows.Forms.Label IdTb;
        private System.Windows.Forms.DataGridView EmployeeListerTb;
        private System.Windows.Forms.Button ExcelFileBtn;
        private System.Windows.Forms.Button TotalSumBtn;
    }
}