namespace Mini_Cookbook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbSignName = new System.Windows.Forms.TextBox();
            this.txbSignPass = new System.Windows.Forms.TextBox();
            this.txbLoginName = new System.Windows.Forms.TextBox();
            this.txbLoginPass = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSignName
            // 
            this.txbSignName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSignName.Location = new System.Drawing.Point(171, 233);
            this.txbSignName.Name = "txbSignName";
            this.txbSignName.Size = new System.Drawing.Size(134, 22);
            this.txbSignName.TabIndex = 1;
            this.txbSignName.Text = "Enter Username";
            this.txbSignName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbSignName_MouseClick);
            // 
            // txbSignPass
            // 
            this.txbSignPass.Location = new System.Drawing.Point(171, 261);
            this.txbSignPass.Name = "txbSignPass";
            this.txbSignPass.Size = new System.Drawing.Size(134, 22);
            this.txbSignPass.TabIndex = 2;
            this.txbSignPass.Text = "Enter Password";
            this.txbSignPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbSignPass_MouseClick);
            // 
            // txbLoginName
            // 
            this.txbLoginName.Location = new System.Drawing.Point(171, 323);
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.Size = new System.Drawing.Size(134, 22);
            this.txbLoginName.TabIndex = 3;
            this.txbLoginName.Text = "Enter Username";
            this.txbLoginName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbLoginName_MouseClick);
            this.txbLoginName.TextChanged += new System.EventHandler(this.txbLoginName_TextChanged);
            // 
            // txbLoginPass
            // 
            this.txbLoginPass.Location = new System.Drawing.Point(171, 351);
            this.txbLoginPass.Name = "txbLoginPass";
            this.txbLoginPass.Size = new System.Drawing.Size(134, 22);
            this.txbLoginPass.TabIndex = 4;
            this.txbLoginPass.Text = "Enter Password";
            this.txbLoginPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbLoginPass_MouseClick);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(312, 233);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(89, 50);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "CONFIRM";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(312, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 50);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "CONFIRM";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(171, 415);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(134, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Test Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(312, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mini_Cookbook.Properties.Resources._1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "add recipe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txbLoginPass);
            this.Controls.Add(this.txbLoginName);
            this.Controls.Add(this.txbSignPass);
            this.Controls.Add(this.txbSignName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbSignName;
        private System.Windows.Forms.TextBox txbSignPass;
        private System.Windows.Forms.TextBox txbLoginName;
        private System.Windows.Forms.TextBox txbLoginPass;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

