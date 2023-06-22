namespace Disconnected_Environmet
{
    partial class FormDataProdi
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
            this.nmp = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSaved = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.data_MahasiswaDataSet = new Disconnected_Environmet.Data_MahasiswaDataSet();
            this.prodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTableAdapter = new Disconnected_Environmet.Data_MahasiswaDataSetTableAdapters.ProdiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_MahasiswaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Prodi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(229, 301);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(167, 22);
            this.nmp.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(617, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(65, 33);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.Location = new System.Drawing.Point(229, 372);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(70, 35);
            this.btnSaved.TabIndex = 5;
            this.btnSaved.Text = "Save";
            this.btnSaved.UseVisualStyleBackColor = true;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(326, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // data_MahasiswaDataSet
            // 
            this.data_MahasiswaDataSet.DataSetName = "Data_MahasiswaDataSet";
            this.data_MahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodiBindingSource
            // 
            this.prodiBindingSource.DataMember = "Prodi";
            this.prodiBindingSource.DataSource = this.data_MahasiswaDataSet;
            // 
            // prodiTableAdapter
            // 
            this.prodiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Prodi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormDataProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataProdi";
            this.Text = "Data Prodi";
            this.Load += new System.EventHandler(this.Data_Prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_MahasiswaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSaved;
        private System.Windows.Forms.Button btnClear;
        private Data_MahasiswaDataSet data_MahasiswaDataSet;
        private System.Windows.Forms.BindingSource prodiBindingSource;
        private Data_MahasiswaDataSetTableAdapters.ProdiTableAdapter prodiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}