namespace forom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lable3 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnlogin = new Button();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 124);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 198);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // lable3
            // 
            lable3.AutoSize = true;
            lable3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lable3.Location = new Point(273, 33);
            lable3.Name = "lable3";
            lable3.Size = new Size(193, 28);
            lable3.TabIndex = 2;
            lable3.Text = "Examination system";
            lable3.Click += label3_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(369, 121);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 31);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(369, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.Location = new Point(320, 255);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 40);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.Location = new Point(246, 341);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(282, 38);
            btnSignup.TabIndex = 7;
            btnSignup.Text = "Don't have an acc Click here";
            btnSignup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 565);
            Controls.Add(btnSignup);
            Controls.Add(btnlogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lable3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lable3;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnlogin;
        private Button btnSignup;
    }
}