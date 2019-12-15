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
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // outputStaffList
            // 
            this.outputStaffList.AllowUserToAddRows = false;
            this.outputStaffList.AllowUserToDeleteRows = false;
            this.outputStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputStaffList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.outputStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputStaffList.Location = new System.Drawing.Point(12, 248);
            this.outputStaffList.Name = "outputStaffList";
            this.outputStaffList.ReadOnly = true;
            this.outputStaffList.Size = new System.Drawing.Size(617, 315);
            this.outputStaffList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(154, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Yapmak istediğiniz parametrelleri giriniz.";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelID.Location = new System.Drawing.Point(8, 71);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(149, 19);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "TC kimlik numarası :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.Location = new System.Drawing.Point(12, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 19);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Ad :";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSurname.Location = new System.Drawing.Point(12, 169);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(63, 19);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Soyad : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(436, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 117);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(158, 70);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(225, 20);
            this.inputID.TabIndex = 6;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(158, 119);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(225, 20);
            this.inputName.TabIndex = 7;
            // 
            // inputSurname
            // 
            this.inputSurname.Location = new System.Drawing.Point(158, 168);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.Size = new System.Drawing.Size(225, 20);
            this.inputSurname.TabIndex = 8;
            // 
            // ShowStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(641, 575);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputStaffList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "ShowStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowStaff";
            this.Load += new System.EventHandler(this.ShowStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputStaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outputStaffList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputSurname;
    }
}