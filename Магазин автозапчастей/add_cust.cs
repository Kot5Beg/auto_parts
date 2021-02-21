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
    public partial class add_cust : Form
    {
        public add_cust()
        {
            InitializeComponent();
        }

        private void add_but_cust_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.OpenCon();
                string add = String.Format("INSERT INTO Customers (Surname, Name, Patronymic, Address, Phone) VALUES ('" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')");
                SqlCommand sc = new SqlCommand(add, DataBase.Con);
                sc.ExecuteNonQuery();
                DataBase.CloseConnection();
                MessageBox.Show("Заказчик успешно добавлен");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления записи");
            }
        }
    }
}
