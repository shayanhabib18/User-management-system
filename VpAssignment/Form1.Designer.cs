namespace VpAssignment
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
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtCnic = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            linkLogin = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 94);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 0;
            label1.Text = "FirstName:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(381, 94);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 148);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 0;
            label2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(381, 148);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 28);
            label3.Name = "label3";
            label3.Size = new Size(202, 38);
            label3.TabIndex = 2;
            label3.Text = "Sign-Up-Form";
            // 
            // txtCnic
            // 
            txtCnic.BorderStyle = BorderStyle.FixedSingle;
            txtCnic.Location = new Point(381, 204);
            txtCnic.Name = "txtCnic";
            txtCnic.Size = new Size(150, 31);
            txtCnic.TabIndex = 1;
            txtCnic.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(381, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(381, 324);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 207);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 0;
            label4.Text = "CNIC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(275, 263);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(275, 324);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 0;
            label6.Text = "Password:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(226, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 34);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register Now";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLogin.Location = new Point(372, 387);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(346, 28);
            linkLogin.TabIndex = 6;
            linkLogin.TabStop = true;
            linkLogin.Text = "Already have an account? Login here";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtCnic);
            Controls.Add(txtLastName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtCnic;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private LinkLabel linkLogin;
    }
}
