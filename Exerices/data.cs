using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerices
{
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }

        private void data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.FromArgb(77, 208, 225);
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.FromArgb(129, 199, 132);
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.FromArgb(191, 54, 12);
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 98, 146);
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 87, 34);
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 118, 210);
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.FromArgb(183, 28, 28);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datagrid dw = new datagrid();
            dw.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dw.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dw.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dw.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dw.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dw.Show();
            this.Hide();
            
            
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
