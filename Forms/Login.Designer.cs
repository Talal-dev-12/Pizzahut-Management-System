namespace Pizzahut_Management_System.Forms
{
    partial class Login
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
            label3 = new Label();
            TxtPassword = new TextBox();
            TxtUsername = new TextBox();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 164);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "USERNAME :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 228);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 44);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "LOGIN";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(413, 228);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(163, 27);
            TxtPassword.TabIndex = 3;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(413, 164);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(163, 27);
            TxtUsername.TabIndex = 4;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(365, 335);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(94, 29);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogin);
            Controls.Add(TxtUsername);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtPassword;
        private TextBox TxtUsername;
        private Button BtnLogin;
    }
}