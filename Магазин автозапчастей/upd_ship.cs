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
    public partial class upd_ship : Form
    {
        public static string id { get; set; }
        public static string det { get; set; }
        public static string prov { get; set; }
        public static string quan { get; set; }
        public static string date { get; set; }

        public upd_ship()
        {
            InitializeComponent();
            
        }

        public upd_ship(string ID, string Det, string Prov, string Quan, string Date)
        {
            InitializeComponent();
            id = ID;
            det = Det;
            prov = Prov;
            quan = Quan;
            date = Date;
            TextLoad();
            LoadCombo();
        }

        private void TextLoad()
        {
            comboBox1.Text = det;
            comboBox2.Text = prov;
            textBox1.Text = quan;
            dateTimePicker1.Text = date;
        }

        private void add_ship_but_Click(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(comboBox1.SelectedValue);
                int p = Convert.ToInt32(comboBox2.SelectedValue);
                int q = Convert.ToInt32(textBox1.Text);

                DataBase.OpenCon();
                string add = String.Format("UPDATE {0} SET ID_Details = {1}, ID_Provider = {2}, Quantity = {3}, Date = '{4}' WHERE ID = '{5}'", "Shipments",d,p,q, dateTimePicker1.Value.Date, id);
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

            SqlCommand sc = new SqlCommand("SELECT * FROM Details", DataBase.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Appelation";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = 0;

            SqlCommand sc1 = new SqlCommand("SELECT * FROM Providers", DataBase.Con);
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
