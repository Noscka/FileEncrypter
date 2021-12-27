
namespace FileEncrypter
{
    partial class Main
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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.FilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Refreshing = new System.ComponentModel.BackgroundWorker();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.FilePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Control_Bar.Controls.Add(this.MinimizePictureBox);
            this.Control_Bar.Controls.Add(this.ExitPictureBox);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(800, 32);
            this.Control_Bar.TabIndex = 3;
            this.Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBar_Panel_MouseDown);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePictureBox.Image = global::FileEncrypter.Properties.Resources._;
            this.MinimizePictureBox.Location = new System.Drawing.Point(736, 0);
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
            this.ExitPictureBox.Location = new System.Drawing.Point(768, 0);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(32, 32);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitPictureBox.TabIndex = 3;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            this.ExitPictureBox.MouseHover += new System.EventHandler(this.ExitPictureBox_MouseHover);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ControlPanel.Controls.Add(this.encryptbutton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlPanel.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.ControlPanel.Location = new System.Drawing.Point(0, 32);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(176, 418);
            this.ControlPanel.TabIndex = 5;
            // 
            // FilePanel
            // 
            this.FilePanel.AllowDrop = true;
            this.FilePanel.Controls.Add(this.panel1);
            this.FilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FilePanel.Font = new System.Drawing.Font("BankGothic Lt BT", 12F);
            this.FilePanel.Location = new System.Drawing.Point(176, 32);
            this.FilePanel.Name = "FilePanel";
            this.FilePanel.Size = new System.Drawing.Size(624, 418);
            this.FilePanel.TabIndex = 6;
            this.FilePanel.WrapContents = false;
            this.FilePanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePanel_DragDrop);
            this.FilePanel.DragOver += new System.Windows.Forms.DragEventHandler(this.FilePanel_DragOver);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 24);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(30, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Refreshing
            // 
            this.Refreshing.WorkerReportsProgress = true;
            this.Refreshing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Refreshing_DoWork);
            this.Refreshing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Refreshing_ProgressChanged);
            this.Refreshing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Refreshing_RunWorkerCompleted);
            // 
            // encryptbutton
            // 
            this.encryptbutton.Font = new System.Drawing.Font("BankGothic Lt BT", 18F);
            this.encryptbutton.Location = new System.Drawing.Point(12, 7);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(149, 39);
            this.encryptbutton.TabIndex = 0;
            this.encryptbutton.Text = "Encrypt";
            this.encryptbutton.UseVisualStyleBackColor = true;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilePanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Control_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.FilePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.FlowLayoutPanel FilePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker Refreshing;
        private System.Windows.Forms.Button encryptbutton;
    }
}