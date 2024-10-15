
namespace ExpenseManagerPV178.Forms
{
    partial class EnterInfoSignIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.CheckIncome = new System.Windows.Forms.CheckBox();
            this.CheckBudget = new System.Windows.Forms.CheckBox();
            this.CheckExpense = new System.Windows.Forms.CheckBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(161, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(164, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(164, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(388, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(319, 27);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(388, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(319, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(388, 102);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(318, 27);
            this.txtPassword2.TabIndex = 5;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSignIn.FlatAppearance.BorderSize = 2;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSignIn.ForeColor = System.Drawing.Color.White;
            this.BtnSignIn.Location = new System.Drawing.Point(455, 380);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(251, 64);
            this.BtnSignIn.TabIndex = 6;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.balance.Location = new System.Drawing.Point(164, 184);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(140, 21);
            this.balance.TabIndex = 7;
            this.balance.Text = "Current Balance";
            this.balance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(388, 182);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(318, 27);
            this.txtBalance.TabIndex = 10;
            // 
            // CheckIncome
            // 
            this.CheckIncome.AutoSize = true;
            this.CheckIncome.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.CheckIncome.Location = new System.Drawing.Point(164, 253);
            this.CheckIncome.Name = "CheckIncome";
            this.CheckIncome.Size = new System.Drawing.Size(193, 25);
            this.CheckIncome.TabIndex = 11;
            this.CheckIncome.Text = "Add Monthly Income";
            this.CheckIncome.UseVisualStyleBackColor = true;
            this.CheckIncome.CheckedChanged += new System.EventHandler(this.CheckIncome_CheckedChanged);
            // 
            // CheckBudget
            // 
            this.CheckBudget.AutoSize = true;
            this.CheckBudget.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.CheckBudget.Location = new System.Drawing.Point(164, 322);
            this.CheckBudget.Name = "CheckBudget";
            this.CheckBudget.Size = new System.Drawing.Size(193, 25);
            this.CheckBudget.TabIndex = 12;
            this.CheckBudget.Text = "Add Monthly Budget";
            this.CheckBudget.UseVisualStyleBackColor = true;
            this.CheckBudget.CheckedChanged += new System.EventHandler(this.CheckBudget_CheckedChanged);
            // 
            // CheckExpense
            // 
            this.CheckExpense.AutoSize = true;
            this.CheckExpense.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(96)))), ((int)(((byte)(99)))));
            this.CheckExpense.Location = new System.Drawing.Point(164, 288);
            this.CheckExpense.Name = "CheckExpense";
            this.CheckExpense.Size = new System.Drawing.Size(205, 25);
            this.CheckExpense.TabIndex = 13;
            this.CheckExpense.Text = "Add Monthly Expense";
            this.CheckExpense.UseVisualStyleBackColor = true;
            this.CheckExpense.CheckedChanged += new System.EventHandler(this.CheckExpense_CheckedChanged);
            // 
            // txtIncome
            // 
            this.txtIncome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtIncome.Enabled = false;
            this.txtIncome.Location = new System.Drawing.Point(421, 251);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(265, 27);
            this.txtIncome.TabIndex = 14;
            this.txtIncome.Text = "0";
            // 
            // txtExpense
            // 
            this.txtExpense.Enabled = false;
            this.txtExpense.Location = new System.Drawing.Point(421, 287);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(265, 27);
            this.txtExpense.TabIndex = 15;
            this.txtExpense.Text = "0";
            // 
            // txtBudget
            // 
            this.txtBudget.Enabled = false;
            this.txtBudget.Location = new System.Drawing.Point(421, 322);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(265, 27);
            this.txtBudget.TabIndex = 16;
            this.txtBudget.Text = "0";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnBack.FlatAppearance.BorderSize = 2;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(161, 380);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(254, 64);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // EnterInfoSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 540);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.CheckExpense);
            this.Controls.Add(this.CheckBudget);
            this.Controls.Add(this.CheckIncome);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EnterInfoSignIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.CheckBox CheckIncome;
        private System.Windows.Forms.CheckBox CheckBudget;
        private System.Windows.Forms.CheckBox CheckExpense;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Button BtnBack;
    }
}