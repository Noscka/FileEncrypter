
namespace FileEncrypter
{
    partial class StartForm
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
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Donelogin = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.PictureBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.UsernameLogin = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginBack = new System.Windows.Forms.Button();
            this.Donesignup = new System.Windows.Forms.Button();
            this.ShowPasswordSignup = new System.Windows.Forms.PictureBox();
            this.signupError = new System.Windows.Forms.Label();
            this.RedoPasswordSignup = new System.Windows.Forms.TextBox();
            this.PasswordSignup = new System.Windows.Forms.TextBox();
            this.UsernameSignup = new System.Windows.Forms.TextBox();
            this.RedoPass = new System.Windows.Forms.Label();
            this.PasswordLabelSignup = new System.Windows.Forms.Label();
            this.UsernameLabelSignup = new System.Windows.Forms.Label();
            this.signupBack = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordSignup)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Control_Bar.Controls.Add(this.MinimizePictureBox);
            this.Control_Bar.Controls.Add(this.ExitPictureBox);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(2, 2);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(457, 32);
            this.Control_Bar.TabIndex = 2;
            this.Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_Panel_MouseDown);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePictureBox.Image = global::FileEncrypter.Properties.Resources._;
            this.MinimizePictureBox.Location = new System.Drawing.Point(393, 0);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(32, 32);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizePictureBox.TabIndex = 3;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
            this.MinimizePictureBox.MouseHover += new System.EventHandler(this.MinimizePictureBox_MouseHover);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPictureBox.Image = global::FileEncrypter.Properties.Resources.x;
            this.ExitPictureBox.Location = new System.Drawing.Point(425, 0);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(32, 32);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitPictureBox.TabIndex = 3;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            this.ExitPictureBox.MouseHover += new System.EventHandler(this.ExitPictureBox_MouseHover);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.StartPanel.Controls.Add(this.SignUpPanel);
            this.StartPanel.Controls.Add(this.SignUpButton);
            this.StartPanel.Controls.Add(this.LoginButton);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(2, 34);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(457, 370);
            this.StartPanel.TabIndex = 3;
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SignUpPanel.Controls.Add(this.LoginPanel);
            this.SignUpPanel.Controls.Add(this.Donesignup);
            this.SignUpPanel.Controls.Add(this.ShowPasswordSignup);
            this.SignUpPanel.Controls.Add(this.signupError);
            this.SignUpPanel.Controls.Add(this.RedoPasswordSignup);
            this.SignUpPanel.Controls.Add(this.PasswordSignup);
            this.SignUpPanel.Controls.Add(this.UsernameSignup);
            this.SignUpPanel.Controls.Add(this.RedoPass);
            this.SignUpPanel.Controls.Add(this.PasswordLabelSignup);
            this.SignUpPanel.Controls.Add(this.UsernameLabelSignup);
            this.SignUpPanel.Controls.Add(this.signupBack);
            this.SignUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpPanel.Location = new System.Drawing.Point(0, 0);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(457, 370);
            this.SignUpPanel.TabIndex = 9;
            this.SignUpPanel.Visible = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LoginPanel.Controls.Add(this.Donelogin);
            this.LoginPanel.Controls.Add(this.ShowPassword);
            this.LoginPanel.Controls.Add(this.ErrorLabel);
            this.LoginPanel.Controls.Add(this.PasswordLogin);
            this.LoginPanel.Controls.Add(this.UsernameLogin);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.LoginBack);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(457, 370);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Visible = false;
            // 
            // Donelogin
            // 
            this.Donelogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Donelogin.Font = new System.Drawing.Font("BankGothic Lt BT", 13F);
            this.Donelogin.Location = new System.Drawing.Point(339, 316);
            this.Donelogin.Name = "Donelogin";
            this.Donelogin.Size = new System.Drawing.Size(103, 39);
            this.Donelogin.TabIndex = 7;
            this.Donelogin.Text = "Done";
            this.Donelogin.UseVisualStyleBackColor = true;
            this.Donelogin.Click += new System.EventHandler(this.Donelogin_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.Image = global::FileEncrypter.Properties.Resources._777497_200;
            this.ShowPassword.Location = new System.Drawing.Point(415, 74);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(24, 24);
            this.ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseDown);
            this.ShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassword_MouseUp);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(25, 221);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(62, 19);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(155, 74);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.PasswordChar = '•';
            this.PasswordLogin.Size = new System.Drawing.Size(254, 24);
            this.PasswordLogin.TabIndex = 3;
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.Location = new System.Drawing.Point(155, 31);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new System.Drawing.Size(254, 24);
            this.UsernameLogin.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 16F);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordLabel.Location = new System.Drawing.Point(15, 73);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(136, 23);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 16F);
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UsernameLabel.Location = new System.Drawing.Point(15, 30);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(134, 23);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // LoginBack
            // 
            this.LoginBack.Font = new System.Drawing.Font("BankGothic Lt BT", 13F);
            this.LoginBack.Location = new System.Drawing.Point(15, 316);
            this.LoginBack.Name = "LoginBack";
            this.LoginBack.Size = new System.Drawing.Size(103, 39);
            this.LoginBack.TabIndex = 2;
            this.LoginBack.Text = "Back";
            this.LoginBack.UseVisualStyleBackColor = true;
            this.LoginBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // Donesignup
            // 
            this.Donesignup.Font = new System.Drawing.Font("BankGothic Lt BT", 14F);
            this.Donesignup.Location = new System.Drawing.Point(339, 316);
            this.Donesignup.Name = "Donesignup";
            this.Donesignup.Size = new System.Drawing.Size(103, 39);
            this.Donesignup.TabIndex = 7;
            this.Donesignup.Text = "Done";
            this.Donesignup.UseVisualStyleBackColor = true;
            this.Donesignup.Click += new System.EventHandler(this.Donesignup_Click);
            // 
            // ShowPasswordSignup
            // 
            this.ShowPasswordSignup.Image = global::FileEncrypter.Properties.Resources._777497_200;
            this.ShowPasswordSignup.Location = new System.Drawing.Point(415, 115);
            this.ShowPasswordSignup.Name = "ShowPasswordSignup";
            this.ShowPasswordSignup.Size = new System.Drawing.Size(24, 24);
            this.ShowPasswordSignup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordSignup.TabIndex = 6;
            this.ShowPasswordSignup.TabStop = false;
            this.ShowPasswordSignup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordSignup_MouseDown);
            this.ShowPasswordSignup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordSignup_MouseUp);
            // 
            // signupError
            // 
            this.signupError.AutoSize = true;
            this.signupError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.signupError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signupError.Location = new System.Drawing.Point(25, 221);
            this.signupError.Name = "signupError";
            this.signupError.Size = new System.Drawing.Size(62, 19);
            this.signupError.TabIndex = 5;
            this.signupError.Text = "Error";
            this.signupError.Visible = false;
            // 
            // RedoPasswordSignup
            // 
            this.RedoPasswordSignup.Location = new System.Drawing.Point(155, 115);
            this.RedoPasswordSignup.Name = "RedoPasswordSignup";
            this.RedoPasswordSignup.PasswordChar = '•';
            this.RedoPasswordSignup.Size = new System.Drawing.Size(254, 24);
            this.RedoPasswordSignup.TabIndex = 3;
            // 
            // PasswordSignup
            // 
            this.PasswordSignup.Location = new System.Drawing.Point(155, 74);
            this.PasswordSignup.Name = "PasswordSignup";
            this.PasswordSignup.PasswordChar = '•';
            this.PasswordSignup.Size = new System.Drawing.Size(254, 24);
            this.PasswordSignup.TabIndex = 3;
            // 
            // UsernameSignup
            // 
            this.UsernameSignup.Location = new System.Drawing.Point(155, 31);
            this.UsernameSignup.Name = "UsernameSignup";
            this.UsernameSignup.Size = new System.Drawing.Size(254, 24);
            this.UsernameSignup.TabIndex = 4;
            // 
            // RedoPass
            // 
            this.RedoPass.AutoSize = true;
            this.RedoPass.Font = new System.Drawing.Font("BankGothic Lt BT", 16F);
            this.RedoPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RedoPass.Location = new System.Drawing.Point(8, 114);
            this.RedoPass.Name = "RedoPass";
            this.RedoPass.Size = new System.Drawing.Size(145, 23);
            this.RedoPass.TabIndex = 3;
            this.RedoPass.Text = "Redo Pass:";
            // 
            // PasswordLabelSignup
            // 
            this.PasswordLabelSignup.AutoSize = true;
            this.PasswordLabelSignup.Font = new System.Drawing.Font("BankGothic Lt BT", 16F);
            this.PasswordLabelSignup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordLabelSignup.Location = new System.Drawing.Point(15, 73);
            this.PasswordLabelSignup.Name = "PasswordLabelSignup";
            this.PasswordLabelSignup.Size = new System.Drawing.Size(136, 23);
            this.PasswordLabelSignup.TabIndex = 3;
            this.PasswordLabelSignup.Text = "Password:";
            // 
            // UsernameLabelSignup
            // 
            this.UsernameLabelSignup.AutoSize = true;
            this.UsernameLabelSignup.Font = new System.Drawing.Font("BankGothic Lt BT", 16F);
            this.UsernameLabelSignup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UsernameLabelSignup.Location = new System.Drawing.Point(15, 30);
            this.UsernameLabelSignup.Name = "UsernameLabelSignup";
            this.UsernameLabelSignup.Size = new System.Drawing.Size(134, 23);
            this.UsernameLabelSignup.TabIndex = 3;
            this.UsernameLabelSignup.Text = "Username:";
            // 
            // signupBack
            // 
            this.signupBack.Font = new System.Drawing.Font("BankGothic Lt BT", 14F);
            this.signupBack.Location = new System.Drawing.Point(15, 316);
            this.signupBack.Name = "signupBack";
            this.signupBack.Size = new System.Drawing.Size(103, 39);
            this.signupBack.TabIndex = 2;
            this.signupBack.Text = "Back";
            this.signupBack.UseVisualStyleBackColor = true;
            this.signupBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SignUpButton.Font = new System.Drawing.Font("BankGothic Lt BT", 22F);
            this.SignUpButton.Location = new System.Drawing.Point(143, 170);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(170, 35);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginButton.Font = new System.Drawing.Font("BankGothic Lt BT", 22F);
            this.LoginButton.Location = new System.Drawing.Point(143, 104);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(170, 35);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(461, 406);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.Control_Bar);
            this.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "StartForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Control_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.StartPanel.ResumeLayout(false);
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordSignup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button LoginBack;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.TextBox UsernameLogin;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.PictureBox ShowPassword;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.PictureBox ShowPasswordSignup;
        private System.Windows.Forms.Label signupError;
        private System.Windows.Forms.TextBox RedoPasswordSignup;
        private System.Windows.Forms.TextBox PasswordSignup;
        private System.Windows.Forms.TextBox UsernameSignup;
        private System.Windows.Forms.Label RedoPass;
        private System.Windows.Forms.Label PasswordLabelSignup;
        private System.Windows.Forms.Label UsernameLabelSignup;
        private System.Windows.Forms.Button signupBack;
        private System.Windows.Forms.Button Donelogin;
        private System.Windows.Forms.Button Donesignup;
    }
}

