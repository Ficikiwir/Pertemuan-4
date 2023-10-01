using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aplikasi_Input_Data_Mahasiswa
{
    public partial class Form1 : Form
    {
        private List<Mahasiswa> list = new List<Mahasiswa>();

        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InisialisasiListView()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;


            AddColumn("No.", 30, HorizontalAlignment.Center);
            AddColumn("Nim", 91, HorizontalAlignment.Center);
            AddColumn("Nama", 200, HorizontalAlignment.Left);
            AddColumn("Kelas", 70, HorizontalAlignment.Center);
            AddColumn("Nilai", 50, HorizontalAlignment.Center);
            AddColumn("Nilai Huruf", 90, HorizontalAlignment.Center);
        }

        private void AddColumn(string header, int width, HorizontalAlignment align)
        {
            lvwMahasiswa.Columns.Add(header, width, align);
        }
       
        private void btnSimpan_Click(object sender, EventArgs e)
        {
  
            Mahasiswa mhs = new Mahasiswa();

            mhs.Nim = txtNim.Text;
            mhs.Nama = txtNama.Text;
            mhs.Kelas = txtKelas.Text;
            mhs.Nilai = int.Parse(txtNilai.Text);
 
            list.Add(mhs);
            var msg = "Data mahasiswa berhasil disimpan.";

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            ResetForm();
        }
        private void ResetForm()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtKelas.Clear();
            txtNilai.Text = "0";
            txtNim.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void TampilkanData()
        {

            lvwMahasiswa.Items.Clear();
 
            foreach (var mhs in list)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Kelas);
                item.SubItems.Add(mhs.Nilai.ToString());
                item.SubItems.Add(mhs.nilaihuruf);
                lvwMahasiswa.Items.Add(item);
            }
        }
        private void btnTampilkanData_Click_1(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {

            if (lvwMahasiswa.SelectedItems.Count > 0)
            {

                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus ? ", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {

                    var index = lvwMahasiswa.SelectedIndices[0];


                    list.RemoveAt(index);

                    TampilkanData();
                }
            }
            else 
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

 
    }
}
