using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environmet
{
    public partial class FormDataProdi : Form
    {
        private string stringConnection = "data source = TRIPLECENTRE\\IRAWAN_ROFI_H;" +
            "database=Data_Mahasiswa;multipleActiveResultSets=true;user ID= sa; Password = Irh081999";
        private SqlConnection koneksi;
        public FormDataProdi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshForm();

        }

        private void Data_Prodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_MahasiswaDataSet.Prodi' table. You can move, or remove it, as needed.
            this.prodiTableAdapter.Fill(this.data_MahasiswaDataSet.Prodi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshForm()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            btnSaved.Enabled = false;
            btnClear.Enabled = false;
        }

     
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_prodi, nama_prodi from dbo.Prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void FormDataProdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHalamanUtama hu = new FormHalamanUtama();
            hu.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSaved.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;
            string idProdi = textBox1.Text;
            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (idProdi == "")
            {
                MessageBox.Show("Masukkan Nama Id Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO prodi (id_prodi, nama_prodi) VALUES (@id_prodi, @nama_prodi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_prodi", idProdi));
                cmd.Parameters.Add(new SqlParameter("@nama_prodi", nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshForm();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDataMaster dm = new FormDataMaster();
            dm.Show();
            this.Hide();
        }
    }
}
