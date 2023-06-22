namespace Disconnected_Environmet
{
    partial class FormDataStatusMahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.data_MahasiswaDataSet1 = new Disconnected_Environmet.Data_MahasiswaDataSet1();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Disconnected_Environmet.Data_MahasiswaDataSet1TableAdapters.MahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_MahasiswaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Mahaiswa";
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(362, 272);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(165, 24);
            this.cbxNama.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(624, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 33);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nomor Induk Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tahun Masuk";
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "nim", true));
            this.txtNIM.Location = new System.Drawing.Point(359, 316);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 7;
            this.txtNIM.Text = "txtNIM";
            this.txtNIM.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Items.AddRange(new object[] {
            "Aktif",
            "Lulus"});
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(362, 355);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(165, 24);
            this.cbxStatusMahasiswa.TabIndex = 8;
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(362, 395);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(165, 24);
            this.cbxTahunMasuk.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(543, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(543, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(543, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // data_MahasiswaDataSet1
            // 
            this.data_MahasiswaDataSet1.DataSetName = "Data_MahasiswaDataSet1";
            this.data_MahasiswaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.data_MahasiswaDataSet1;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // FormDataStatusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataStatusMahasiswa";
            this.Text = "Data Status Mahasiswa";
            this.Load += new System.EventHandler(this.FormDataStatusMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_MahasiswaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private Data_MahasiswaDataSet1 data_MahasiswaDataSet1;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private Data_MahasiswaDataSet1TableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
    }
}