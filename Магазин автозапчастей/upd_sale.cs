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
    public partial class upd_sale : Form
    {
        public static string id { get; set; }
        public static string cust { get; set; }
        public static string det { get; set; }
        public static string quan { get; set; }
        public static string price { get; set; }

        public upd_sale()
        {
            InitializeComponent();
        }

        public upd_sale(string ID, string Cust, string Det, string Quan, string Price)
        {
            InitializeComponent();
            id = ID;
            cust = Cust;
            det = Det;
            quan = Quan;
            price = Price;
            TextLoad();
            LoadCombo();
        }

        private void TextLoad()
        {
            comboBox1.Text = cust;
            comboBox2.Text = det;
            textBox1.Text = quan;
            textBox2.Text = price;
        }

        private void add_sale_but_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(comboBox1.SelectedValue);
                int d = Convert.ToInt32(comboBox2.SelectedValue);
                int q = Convert.ToInt32(textBox1.Text);
                int pr = Convert.ToInt32(textBox2.Text);

                DataBase.OpenCon();
                string add = String.Format("UPDATE {0} SET ID_Customer = {1}, ID_Details = {2}, Quantity = {3}, Price = {4} WHERE ID = '{5}'", "Sales",c,d,q,pr, id);
                SqlCommand sc = new SqlCommand(add, DataBase.Con);
                sc.ExecuteNonQuery();
                DataBase.CloseConnection();
                MessageBox.Show("Запись успешно изменена");
            }
            catch
            {
                MessageBox.Show("Ошибка редактирования");
            }
        }

        public void LoadCombo()
        {
            DataBase.OpenCon();

            SqlCommand sc = new SqlCommand("SELECT * FROM Customers", DataBase.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Surname";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = 0;

            SqlCommand sc1 = new SqlCommand("SELECT * FROM Details", DataBase.Con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(sc1);
            da1.Fill(dt1);
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Appelation";
            comboBox2.ValueMember = "ID";
            comboBox2.SelectedIndex = 0;

            DataBase.CloseConnection();
        }
    }
}
