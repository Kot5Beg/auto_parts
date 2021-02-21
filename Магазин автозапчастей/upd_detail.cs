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
    public partial class upd_detail : Form
    {
        public static string id { get; set; }
        public static string appelation { get; set; }
        public static string artnum { get; set; }
        public static string price { get; set; }
        public static string note { get; set; }

        public upd_detail()
        {
            InitializeComponent();
        }

        public upd_detail(string ID, string Appelation, string Artnum, string Price, string Note)
        {
            InitializeComponent();
            id = ID;
            appelation = Appelation;
            artnum = Artnum;
            price = Price;
            note = Note;
            LoadText();
        }

        public void LoadText()
        {
            textBox1.Text = appelation;
            textBox2.Text = artnum;
            textBox3.Text = price;
            textBox4.Text = note;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.OpenCon();
                string save = String.Format("UPDATE {0} SET Appelation = '{1}', Article_number = '{2}', Price = '{3}', Notes = '{4}' WHERE ID = '{5}'", "Details", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, id);
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
