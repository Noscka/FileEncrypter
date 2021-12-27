using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Linq;

namespace FileEncrypter
{
    public partial class StartForm : Form
    {
        public string USERNAME;
        public string PASSPHRASE;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firsttimecheck();
        }

        private void ControlBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void ExitPictureBox_MouseHover(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizePictureBox_MouseHover(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = true;
            LoginPanel.Visible = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            SignUpPanel.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SignUpPanel.Visible = false;
            LoginPanel.Visible = false;
        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordLogin.PasswordChar = '\0';
        }

        private void ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordLogin.PasswordChar = Convert.ToChar("•");
        }

        private void ShowPasswordSignup_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordSignup.PasswordChar = '\0';
            RedoPasswordSignup.PasswordChar = '\0';
        }

        private void ShowPasswordSignup_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordSignup.PasswordChar = Convert.ToChar("•");
            RedoPasswordSignup.PasswordChar = Convert.ToChar("•");
        }

        private void Donesignup_Click(object sender, EventArgs e)
        {
            if (UsernameSignup.TextLength == 0 && PasswordSignup.TextLength == 0 && RedoPasswordSignup.TextLength == 0)
            {
                signupError.Visible = true;
                signupError.Text = "Enter a Password, Password Redo and Username";
            }
            else if (PasswordSignup.TextLength == 0)
            {
                signupError.Visible = true;
                signupError.Text = "Enter a Password";
            }
            else if (UsernameSignup.TextLength == 0)
            {
                signupError.Visible = true;
                signupError.Text = "Enter a Username";
            }
            else if (PasswordSignup.Text != RedoPasswordSignup.Text)
            {
                signupError.Visible = true;
                signupError.Text = "Password and Redo dont match";
            }
            else
            {
                signupError.Visible = false;
                string[] logininfo = { Encryption.StringEncrypt(UsernameSignup.Text), Encryption.StringEncrypt(CreateHash(PasswordSignup.Text)) };
                File.WriteAllLines("Login.txt", logininfo);
                LoginPanel.Visible = true;


                GCHandle GCh = GCHandle.Alloc(PasswordSignup.Text, GCHandleType.Pinned);
                Encryption.ZeroMemory(GCh.AddrOfPinnedObject(), PasswordSignup.Text.Length * 2);
                GCh.Free();

                UsernameSignup.Text = "";
                PasswordSignup.Text = "";
                RedoPasswordSignup.Text = "";
            }
        }

        private void Donelogin_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;

            if (!File.Exists("Login.txt"))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "No account detected";
            }
            else
            {
                string Username = Encryption.StringDecrypt(File.ReadLines("Login.txt").First());
                string passwordhash = File.ReadLines("Login.txt").Last();

                if (ValidatePassword(PasswordLogin.Text, Encryption.StringDecrypt(passwordhash)) && UsernameLogin.Text == Username)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Correct";

                    Main main = new Main(this);
                    main.Show();
                    USERNAME = Username;
                    PASSPHRASE = passwordhash;
                    this.Hide();

                    GCHandle GCh = GCHandle.Alloc(PasswordLogin.Text, GCHandleType.Pinned);
                    Encryption.ZeroMemory(GCh.AddrOfPinnedObject(), PasswordLogin.Text.Length * 2);
                    GCh.Free();
                }
                else if (UsernameLogin.TextLength == 0 && PasswordLogin.TextLength == 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Enter a Password and Username";
                }
                else if (PasswordLogin.TextLength == 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Enter a Password";
                }
                else if (UsernameLogin.TextLength == 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Enter a Username";
                }
                else
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Password or Username is wrong";
                }
            }
        }

        #region FirstTime
        static string hashpassword;

        private void firsttimecheck()
        {
            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\EncryptionFolderStorer");
            object value = key.GetValue("PassPhrase");

            if (value != null)
            {
                hashpassword = key.GetValue("PassPhrase").ToString();
                Encryption.hashphrase = hashpassword;
                key.Close();
            }
            else
            {
                firsttime();
            }
        }

        public static void firsttime()
        {
            hashpassword = RandomString(10);
            MessageBox.Show("First Time set up", "Going to run First Time Set up");
            var key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EncryptionFolderStorer");
            key.SetValue("PassPhrase", hashpassword);
            key.Close();
        }

        static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
        #endregion

        

        #region PasswordHashing

        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;

        public static string CreateHash(string password)
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);
            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return PBKDF2_ITERATIONS + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = Int32.Parse(split[ITERATION_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }
        #endregion
    }
}
