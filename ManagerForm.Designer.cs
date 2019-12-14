namespace EducationAutomation
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.specialPanel2 = new EducationAutomation.SpecialPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.specialPanel1 = new EducationAutomation.SpecialPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelStaff = new EducationAutomation.SpecialPanel();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnStaffOperation = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.specialPanel2.SuspendLayout();
            this.specialPanel1.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.Controls.Add(this.specialPanel2);
            this.menuPanel.Controls.Add(this.specialPanel1);
            this.menuPanel.Controls.Add(this.panelStaff);
            this.menuPanel.Location = new System.Drawing.Point(-1, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 645);
            this.menuPanel.TabIndex = 0;
            // 
            // specialPanel2
            // 
            this.specialPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.specialPanel2.Controls.Add(this.button5);
            this.specialPanel2.Controls.Add(this.button6);
            this.specialPanel2.Controls.Add(this.button7);
            this.specialPanel2.Controls.Add(this.button8);
            this.specialPanel2.Location = new System.Drawing.Point(3, 185);
            this.specialPanel2.Name = "specialPanel2";
            this.specialPanel2.Size = new System.Drawing.Size(190, 60);
            this.specialPanel2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(47, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "Update Staff";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(47, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 35);
            this.button6.TabIndex = 2;
            this.button6.Text = "Delete Staff";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(47, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 35);
            this.button7.TabIndex = 1;
            this.button7.Text = "Add Staff";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 50);
            this.button8.TabIndex = 0;
            this.button8.Text = "Staff Operation";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // specialPanel1
            // 
            this.specialPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.specialPanel1.Controls.Add(this.button1);
            this.specialPanel1.Controls.Add(this.button2);
            this.specialPanel1.Controls.Add(this.button3);
            this.specialPanel1.Controls.Add(this.button4);
            this.specialPanel1.Location = new System.Drawing.Point(3, 367);
            this.specialPanel1.Name = "specialPanel1";
            this.specialPanel1.Size = new System.Drawing.Size(190, 60);
            this.specialPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(47, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update Staff";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(47, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Staff";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(47, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Staff";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "Staff Operation";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelStaff
            // 
            this.panelStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelStaff.Controls.Add(this.btnUpdateStaff);
            this.panelStaff.Controls.Add(this.btnDeleteStaff);
            this.panelStaff.Controls.Add(this.btnAddStaff);
            this.panelStaff.Controls.Add(this.btnStaffOperation);
            this.panelStaff.Location = new System.Drawing.Point(3, 3);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(190, 60);
            this.panelStaff.TabIndex = 0;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(47, 141);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(140, 35);
            this.btnUpdateStaff.TabIndex = 3;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStaff.Location = new System.Drawing.Point(47, 100);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(140, 35);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.Location = new System.Drawing.Point(47, 59);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(140, 35);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnStaffOperation
            // 
            this.btnStaffOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStaffOperation.Location = new System.Drawing.Point(3, 3);
            this.btnStaffOperation.Name = "btnStaffOperation";
            this.btnStaffOperation.Size = new System.Drawing.Size(184, 50);
            this.btnStaffOperation.TabIndex = 0;
            this.btnStaffOperation.Text = "Staff Operation";
            this.btnStaffOperation.UseVisualStyleBackColor = true;
            this.btnStaffOperation.Click += new System.EventHandler(this.btnStaffOperation_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 645);
            this.Controls.Add(this.menuPanel);
            this.IsMdiContainer = true;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.menuPanel.ResumeLayout(false);
            this.specialPanel2.ResumeLayout(false);
            this.specialPanel1.ResumeLayout(false);
            this.panelStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private EducationAutomation.SpecialPanel panelStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnStaffOperation;
        private System.Windows.Forms.Panel menuPanel;
        private SpecialPanel specialPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private SpecialPanel specialPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}