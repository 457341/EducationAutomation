namespace EducationAutomation
{
    partial class ShowStaff
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
            this.outputStaffList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.outputStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // outputStaffList
            // 
            this.outputStaffList.AllowUserToAddRows = false;
            this.outputStaffList.AllowUserToDeleteRows = false;
            this.outputStaffList.AllowUserToOrderColumns = true;
            this.outputStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputStaffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputStaffList.Location = new System.Drawing.Point(0, 0);
            this.outputStaffList.Name = "outputStaffList";
            this.outputStaffList.ReadOnly = true;
            this.outputStaffList.Size = new System.Drawing.Size(811, 459);
            this.outputStaffList.TabIndex = 0;
            // 
            // ShowStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 459);
            this.Controls.Add(this.outputStaffList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "ShowStaff";
            this.Text = "ShowStaff";
            this.Load += new System.EventHandler(this.ShowStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputStaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView outputStaffList;
    }
}