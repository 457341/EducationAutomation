﻿namespace EducationAutomation
{
    partial class LoginPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.outputResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputUsername);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password ";
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputPassword.Location = new System.Drawing.Point(192, 67);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(114, 23);
            this.inputPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // inputUsername
            // 
            this.inputUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputUsername.Location = new System.Drawing.Point(192, 19);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(114, 23);
            this.inputUsername.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(91, 148);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(155, 53);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // outputResult
            // 
            this.outputResult.Location = new System.Drawing.Point(64, 113);
            this.outputResult.Name = "outputResult";
            this.outputResult.Size = new System.Drawing.Size(200, 16);
            this.outputResult.TabIndex = 6;
            this.outputResult.Text = "label3";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 231);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputResult;
    }
}

