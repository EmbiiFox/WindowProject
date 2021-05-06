
namespace test
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.imgPassword = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSignup = new System.Windows.Forms.Label();
            this.linkSignUp = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.rdoBtnStudent = new System.Windows.Forms.RadioButton();
            this.rdoBtnTeacher = new System.Windows.Forms.RadioButton();
            this.rdoBtnAdmin = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 85);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(380, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogin.Appearance.Options.UseFont = true;
            this.lblLogin.Appearance.Options.UseForeColor = true;
            this.lblLogin.Location = new System.Drawing.Point(45, 35);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(74, 29);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "LOGIN";
            // 
            // imageSlider1
            // 
            this.imageSlider1.AnimationTime = 100;
            this.imageSlider1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(165, 92);
            this.imageSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(108, 102);
            this.imageSlider1.TabIndex = 1;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.Click += new System.EventHandler(this.imageSlider1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(154, 344);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 33);
            this.txtUsername.TabIndex = 2;
            // 
            // imgPassword
            // 
            this.imgPassword.AnimationTime = 100;
            this.imgPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imgPassword.CurrentImageIndex = 0;
            this.imgPassword.Images.Add(((System.Drawing.Image)(resources.GetObject("imgPassword.Images"))));
            this.imgPassword.Location = new System.Drawing.Point(105, 410);
            this.imgPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(31, 34);
            this.imgPassword.TabIndex = 4;
            this.imgPassword.Text = "Password";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(155, 373);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(172, 4);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(154, 440);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 4);
            this.labelControl2.TabIndex = 7;
            // 
            // picLoading
            // 
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(0, 189);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(431, 66);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 8;
            this.picLoading.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(98, 482);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 45);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSignup.Location = new System.Drawing.Point(133, 575);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(158, 17);
            this.lblSignup.TabIndex = 10;
            this.lblSignup.Text = "Don\'t have an account?";
            // 
            // linkSignUp
            // 
            this.linkSignUp.Location = new System.Drawing.Point(165, 596);
            this.linkSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(81, 16);
            this.linkSignUp.TabIndex = 11;
            this.linkSignUp.Text = "SIGN UP HERE";
            // 
            // rdoBtnStudent
            // 
            this.rdoBtnStudent.AutoSize = true;
            this.rdoBtnStudent.Location = new System.Drawing.Point(70, 275);
            this.rdoBtnStudent.Name = "rdoBtnStudent";
            this.rdoBtnStudent.Size = new System.Drawing.Size(78, 21);
            this.rdoBtnStudent.TabIndex = 12;
            this.rdoBtnStudent.TabStop = true;
            this.rdoBtnStudent.Text = "Student";
            this.rdoBtnStudent.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTeacher
            // 
            this.rdoBtnTeacher.AutoSize = true;
            this.rdoBtnTeacher.Location = new System.Drawing.Point(179, 275);
            this.rdoBtnTeacher.Name = "rdoBtnTeacher";
            this.rdoBtnTeacher.Size = new System.Drawing.Size(82, 21);
            this.rdoBtnTeacher.TabIndex = 13;
            this.rdoBtnTeacher.TabStop = true;
            this.rdoBtnTeacher.Text = "Teacher";
            this.rdoBtnTeacher.UseVisualStyleBackColor = true;
            // 
            // rdoBtnAdmin
            // 
            this.rdoBtnAdmin.AutoSize = true;
            this.rdoBtnAdmin.Location = new System.Drawing.Point(293, 275);
            this.rdoBtnAdmin.Name = "rdoBtnAdmin";
            this.rdoBtnAdmin.Size = new System.Drawing.Size(68, 21);
            this.rdoBtnAdmin.TabIndex = 14;
            this.rdoBtnAdmin.TabStop = true;
            this.rdoBtnAdmin.Text = "Admin";
            this.rdoBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(154, 410);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 34);
            this.txtPassword.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 651);
            this.Controls.Add(this.rdoBtnAdmin);
            this.Controls.Add(this.rdoBtnTeacher);
            this.Controls.Add(this.rdoBtnStudent);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblLogin;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.TextBox txtUsername;
        private DevExpress.XtraEditors.Controls.ImageSlider imgPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSignup;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkSignUp;
        private System.Windows.Forms.RadioButton rdoBtnStudent;
        private System.Windows.Forms.RadioButton rdoBtnTeacher;
        private System.Windows.Forms.RadioButton rdoBtnAdmin;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

