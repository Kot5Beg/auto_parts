﻿using System;
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
    public partial class upd_cust : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }

        public upd_cust()
        {
            InitializeComponent();
        }

        public upd_cust(string ID, string Surname, string Name, string Patronymic, string Address, string Phone)
        {
            InitializeComponent();
            id = ID;
            surname = Surname;
            name = Name;
            patronymic = Patronymic;
            address = Address;
            phone = Phone;
            TextLoad();
        }

        public void TextLoad()
        {
            textBox1.Text = surname;
            textBox5.Text = name;
            textBox4.Text = patronymic;
            textBox2.Text = address;
            textBox3.Text = phone;
        }

        private void upd_but_cust_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.OpenCon();
                string save = String.Format("UPDATE {0} SET Surname = '{1}', Name = '{2}', Patronymic = '{3}', Address = '{4}', Phone = '{5}' WHERE ID = '{6}'", "Customers", textBox1.Text, textBox5.Text, textBox4.Text, textBox2.Text, textBox3.Text, id);
                SqlCommand com = new SqlCommand(save, DataBase.Con);
                com.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
