namespace forom
{
    internal class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnSignup = new Button();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.Location = new Point(377, 326);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(196, 39);
            btnSignup.TabIndex = 0;
            btnSignup.Text = "Create an account";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(326, 379);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(314, 40);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Already have an acc then click me";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 53);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 2;
            label1.Text = "Sign_up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 129);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 187);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 252);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(478, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(478, 181);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(478, 249);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '_';
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 8;
            // 
            // Form2
            // 
            ClientSize = new Size(879, 493);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Name = "Form2";
            Text = "Sign_up";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }

        private Button btnSignup;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }

}