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
    public partial class upd_prov : Form
    {
        public static string id { get; set; }
        public static string appelation { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }
        public static string site { get; set; }

        public upd_prov()
        {
            InitializeComponent();
        }

        public upd_prov(string ID, string Appelation, string Address, string Phone, string Site)
        {
            InitializeComponent();
            id = ID;
            appelation = Appelation;
            address = Address;
            phone = Phone;
            site = Site;
            LoadText();
        }

        public void LoadText()
        {
            textBox1.Text = appelation;
            textBox2.Text = address;
            textBox3.Text = phone;
            textBox4.Text = site;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.OpenCon();
                string save = String.Format("UPDATE {0} SET Appelation = '{1}', Address = '{2}', Phone = '{3}', Site = '{4}' WHERE ID = '{5}'", "Providers", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, id);
                SqlCommand com = new SqlCommand(save, DataBase.Con);
                com.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена");

            }
            catch
            {
                MessageBox.Show("Ошибка редактирования");
            }
        }
    }
}
