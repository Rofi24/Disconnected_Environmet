using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environmet
{
    public partial class FormDataMaster : Form
    {
        public FormDataMaster()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataProdi fp = new FormDataProdi();
            fp.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataMahasiswa fo = new FormDataMahasiswa();
            fo.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataStatusMahasiswa fd = new FormDataStatusMahasiswa();
            fd.Show();
            this.Hide();
        }
    }
}
