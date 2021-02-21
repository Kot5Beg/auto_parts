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
    public partial class autorization : Form
    {
        public autorization()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autorization_but_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (MessageBox.Show("Заполните поля!") == DialogResult.OK)
                    Focus();
            }
            else
                Check();
        }

        private void Check()
        {
            DataBase.OpenCon();

            string login = Convert.ToString(textBox1.Text);
            string password = Convert.ToString(textBox2.Text);
            int i = 0;

            string security = "SELECT * FROM worker WHERE login = '" + login + "' AND password = '" + password + "';";

            SqlCommand sc = new SqlCommand(security, DataBase.Con);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sc);


            sda.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                AdminInput();
            }
            else
            {
                SqlDataReader read = sc.ExecuteReader();
                Main main = new Main();
                main.Show();
                Hide();
            }

            DataBase.CloseConnection();
        }

        private void AdminInput()
        {
            string login = Convert.ToString(textBox1.Text);
            string password = Convert.ToString(textBox2.Text);
            int a;

            string admin = "SELECT * FROM admin WHERE login = '" + login + "' AND password = '" + password + "';";

            SqlCommand sc = new SqlCommand(admin, DataBase.Con);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sc);


            sda.Fill(dt);
            a = Convert.ToInt32(dt.Rows.Count.ToString());

            if (a == 0)
            {
                if (MessageBox.Show("Ошибка авторизации\nПопробуйте ещё раз!") == DialogResult.OK)
                {
                    Focus();
                }
            }
            else
            {
                SqlDataReader read = sc.ExecuteReader();
                Admin AdminForm = new Admin();
                AdminForm.Show();
                Hide();
            }
        }
    }
}
