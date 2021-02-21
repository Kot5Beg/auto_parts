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
    public partial class add_sale : Form
    {
        public add_sale()
        {
            InitializeComponent();
            LoadCombo();
        }

        private void add_sale_but_Click(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(comboBox1.SelectedValue);
                int c = Convert.ToInt32(comboBox2.SelectedValue);
                int q = Convert.ToInt32(textBox1.Text);
                int pr = Convert.ToInt32(textBox2.Text);

                DataBase.OpenCon();
                string add = String.Format("INSERT INTO Sales (ID_Customer, ID_Details, Quantity, Price) VALUES (" + d + ", " + c + ", " + q + ", " + pr + ")");
                SqlCommand sc = new SqlCommand(add, DataBase.Con);
                sc.ExecuteNonQuery();
                DataBase.CloseConnection();
                MessageBox.Show("Продажа успешно оформлена");
            }
            catch
            {
                MessageBox.Show("Ошибка продажи");
            }
        }

        public void LoadCombo()
        {
            DataBase.OpenCon();

            SqlCommand sc = new SqlCommand("SELECT * FROM Details", DataBase.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Appelation";
            comboBox2.ValueMember = "ID";
            comboBox2.SelectedIndex = 0;

            SqlCommand sc1 = new SqlCommand("SELECT * FROM Customers", DataBase.Con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(sc1);
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Surname";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = 0;

            DataBase.CloseConnection();
        }
    }
}
