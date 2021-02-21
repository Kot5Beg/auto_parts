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
    public partial class add_shipcs : Form
    {
        public add_shipcs()
        {
            InitializeComponent();
            LoadCombo();
        }

        private void add_ship_but_Click(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(comboBox1.SelectedValue);
                int p = Convert.ToInt32(comboBox2.SelectedValue);
                int q = Convert.ToInt32(textBox1.Text);

                DataBase.OpenCon();
                string add = String.Format("INSERT INTO Shipments (ID_Details, ID_Provider, Quantity, Date ) VALUES (" + d + ", " + p + ", " + q + ", '" + dateTimePicker1.Value.Date + "')");
                SqlCommand sc = new SqlCommand(add, DataBase.Con);
                sc.ExecuteNonQuery();
                DataBase.CloseConnection();
                MessageBox.Show("Поставка успешно зарегистрирована");
            }
            catch
            {
                MessageBox.Show("Ошибка регистрации поставки");
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
