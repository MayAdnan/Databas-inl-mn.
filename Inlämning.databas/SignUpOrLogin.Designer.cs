namespace Inlämning.databas
{
    partial class SignUpOrLogin
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
            label1 = new Label();
            label2 = new Label();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            buttonLogin = new Button();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonSignUp = new Button();
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(31, 84);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(242, 27);
            textBoxUserName.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(31, 52);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(75, 20);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "Username";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(31, 261);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Log in ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(36, 151);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(31, 188);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(242, 27);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(179, 261);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(94, 29);
            buttonSignUp.TabIndex = 7;
            buttonSignUp.Text = "Sign up ";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(109, 313);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "Log out";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // SignUpOrLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 371);
            Controls.Add(buttonLogout);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(buttonLogin);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpOrLogin";
            Text = "Sign up / Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private Button buttonLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonSignUp;
        private Button buttonLogout;
    }
}