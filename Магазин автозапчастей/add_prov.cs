using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Магазин_автозапчастей
{
    public partial class add_prov : Form
    {
        public add_prov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.OpenCon();
                string add = String.Format("INSERT INTO Providers (Appelation, Address, Phone, Site) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')");
                SqlCommand sc = new SqlCommand(add, DataBase.Con);
                sc.ExecuteNonQuery();
                DataBase.CloseConnection();
                MessageBox.Show("Поставщик успешно добавлен");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления записи");
            }
        }
    }
}
