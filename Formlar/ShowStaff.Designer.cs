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
            this.components = new System.ComponentModel.Container();
            this.outputStaffList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.egitimVeriTabaniDataSet = new EducationAutomation.EgitimVeriTabaniDataSet();
            this.tBolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBolumTableAdapter = new EducationAutomation.EgitimVeriTabaniDataSetTableAdapters.tBolumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.outputStaffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // outputStaffList
            // 
            this.outputStaffList.AllowUserToOrderColumns = true;
            this.outputStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputStaffList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.outputStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputStaffList.Location = new System.Drawing.Point(12, 248);
            this.outputStaffList.Name = "outputStaffList";
            this.outputStaffList.Size = new System.Drawing.Size(617, 315);
            this.outputStaffList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Yapmak istediğiniz parametrelleri giriniz.";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelID.Location = new System.Drawing.Point(8, 84);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(149, 19);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "TC kimlik numarası :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.Location = new System.Drawing.Point(12, 131);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 19);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Personel Adı :";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSurname.Location = new System.Drawing.Point(8, 183);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(132, 19);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Personel Soyadı : ";
            // 
            // inputID
            // 
            this.inputID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputID.Location = new System.Drawing.Point(185, 81);
            this.inputID.Margin = new System.Windows.Forms.Padding(10);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(178, 27);
            this.inputID.TabIndex = 6;
            this.inputID.TextChanged += new System.EventHandler(this.inputID_TextChanged);
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputName.Location = new System.Drawing.Point(185, 128);
            this.inputName.Margin = new System.Windows.Forms.Padding(10);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(178, 27);
            this.inputName.TabIndex = 7;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // inputSurname
            // 
            this.inputSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputSurname.Location = new System.Drawing.Point(185, 175);
            this.inputSurname.Margin = new System.Windows.Forms.Padding(10);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.Size = new System.Drawing.Size(178, 27);
            this.inputSurname.TabIndex = 8;
            this.inputSurname.TextChanged += new System.EventHandler(this.inputSurname_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBolumBindingSource;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(449, 81);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 27);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(449, 128);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 27);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(449, 175);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(152, 27);
            this.comboBox3.TabIndex = 11;
            // 
            // egitimVeriTabaniDataSet
            // 
            this.egitimVeriTabaniDataSet.DataSetName = "EgitimVeriTabaniDataSet";
            this.egitimVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBolumBindingSource
            // 
            this.tBolumBindingSource.DataMember = "tBolum";
            this.tBolumBindingSource.DataSource = this.egitimVeriTabaniDataSet;
            // 
            // tBolumTableAdapter
            // 
            this.tBolumTableAdapter.ClearBeforeFill = true;
            // 
            // ShowStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(641, 575);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputID);
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
            ((System.ComponentModel.ISupportInitialize)(this.egitimVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBolumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView outputStaffList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputSurname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private EgitimVeriTabaniDataSet egitimVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tBolumBindingSource;
        private EgitimVeriTabaniDataSetTableAdapters.tBolumTableAdapter tBolumTableAdapter;
    }
}