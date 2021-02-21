using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магазин_автозапчастей
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Main.Loading("SELECT * FROM Details", dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> sale = new List<string>();
            var number = dataGridView2.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[number];
            upd_prov up = new upd_prov(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString());
            up.ShowDialog();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            if (tabControl1.SelectedTab == details)
            {
                string det = "SELECT * FROM Details";
                Main.Loading(det, dataGridView1);
            }
            else if (tabControl1.SelectedTab == providers)
            {
                string prov = "SELECT * FROM Providers";
                Main.Loading(prov, dataGridView2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_prov ap = new add_prov();
            ap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_detail ad = new add_detail();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> sale = new List<string>();
            var number = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[number];
            upd_detail up = new upd_detail(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString());
            up.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string del_det = "DELETE FROM Details WHERE ID = {0}";
                    DataBase.Delete(dataGridView1, del_det);
                    MessageBox.Show("Запись удалена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string del_prov = "DELETE FROM Providers WHERE ID = {0}";
                    DataBase.Delete(dataGridView2, del_prov);
                    MessageBox.Show("Запись удалена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string prov = "SELECT * FROM Providers";
            Main.Loading(prov, dataGridView2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string det = "SELECT * FROM Details";
            Main.Loading(det, dataGridView1);
        }
    }
}
