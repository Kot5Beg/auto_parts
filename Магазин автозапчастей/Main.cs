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
    public partial class Main : Form
    {
        public static DataTable res;
        string i;

        public Main()
        {
            InitializeComponent();
            Loading("SELECT * FROM Details", detail_list);
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = DataBase.Load(query);
            grid.DataSource = res;
            grid.Columns["ID"].Visible = false;
        }

        private void menu_Selected(object sender, TabControlEventArgs e)
        {
            if (menu.SelectedTab == Details)
            {
                string det = "SELECT * FROM Details";
                Loading(det, detail_list);
            }
            else if (menu.SelectedTab == History)
            {
                string hist = "SELECT * FROM History_Price";
                Loading(hist, history_list);
            }
            else if (menu.SelectedTab == Providers)
            {
                string prov = "SELECT * FROM Providers";
                Loading(prov, provider_list);
            }
            else if (menu.SelectedTab == Shipments)
            {
                string ship = "SELECT * FROM Shipments";
                Loading(ship, shipment_list);
                LoadProv();
            }
            else if (menu.SelectedTab == Customers)
            {
                string cust = "SELECT * FROM Customers";
                Loading(cust, customer_list);
            }
            else if (menu.SelectedTab == Sales)
            {
                string sale = "SELECT * FROM Sales";
                Loading(sale, sale_list);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_cust ac = new add_cust();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> cust = new List<string>();
            var number = customer_list.CurrentCell.RowIndex;
            DataGridViewRow row = customer_list.Rows[number];
            upd_cust uc = new upd_cust(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString());
            uc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_sale addsale = new add_sale();
            addsale.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> sale = new List<string>();
            var number = sale_list.CurrentCell.RowIndex;
            DataGridViewRow row = sale_list.Rows[number];
            upd_sale us = new upd_sale(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString());
            us.ShowDialog();
        }

        private void add_ship_Click(object sender, EventArgs e)
        {
            add_shipcs aship = new add_shipcs();
            aship.ShowDialog();
        }

        private void update_ship_Click(object sender, EventArgs e)
        {
            List<string> ship = new List<string>();
            var number = shipment_list.CurrentCell.RowIndex;
            DataGridViewRow row = shipment_list.Rows[number];
            upd_ship us = new upd_ship(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString());
            us.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string det_search = "SELECT * FROM Details WHERE CONCAT (Appelation, Article_number, Price, Notes) LIKE '%" + textBox2.Text + "%' ";
            Loading(det_search, detail_list);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string histsearch = "SELECT * FROM History_Price WHERE CONCAT (ID_Detail, Date_Price, Price) LIKE '%" + textBox3.Text + "%' ";
            Loading(histsearch, history_list);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string provsearch = "SELECT * FROM Providers WHERE CONCAT (Appelation, Address, Phone, Site) LIKE '%" + textBox4.Text + "%' ";
            Loading(provsearch, provider_list);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string shipsearch = "SELECT * FROM Shipments WHERE CONCAT (ID_Details, ID_Provider, Quantity, Date) LIKE '%" + textBox5.Text + "%' ";
            Loading(shipsearch, shipment_list);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string custsearch = "SELECT * FROM Customers WHERE CONCAT (Surname, Name, Patronymic, Address, Phone) LIKE '%" + textBox6.Text + "%' ";
            Loading(custsearch, customer_list);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string salesearch = "SELECT * FROM Sales WHERE CONCAT (ID_Customer, ID_Details, Quantity, Price) LIKE '%" + textBox7.Text + "%' ";
            Loading(salesearch, sale_list);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string del_sale = "DELETE FROM Sales WHERE ID = {0}";
                    DataBase.Delete(sale_list, del_sale);
                    MessageBox.Show("Запись удалена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string del_cust = "DELETE FROM Customers WHERE ID = {0}";
                    DataBase.Delete(customer_list, del_cust);
                    MessageBox.Show("Запись удалена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void delete_ship_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string del_ship = "DELETE FROM Shipments WHERE ID = {0}";
                    DataBase.Delete(shipment_list, del_ship);
                    MessageBox.Show("Запись удалена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                string cust = "SELECT * FROM Customers ORDER BY Surname ASC";
                Loading(cust, customer_list);
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
            }
            else if (checkBox10.Checked == false)
            {
                string cust = "SELECT * FROM Customers";
                Loading(cust, customer_list);
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                string cust = "SELECT * FROM Customers ORDER BY Name ASC";
                Loading(cust, customer_list);
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
            }
            else if (checkBox8.Checked == false)
            {
                string cust = "SELECT * FROM Customers";
                Loading(cust, customer_list);
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                string cust = "SELECT * FROM Customers ORDER BY Patronymic ASC";
                Loading(cust, customer_list);
                checkBox8.Enabled = false;
                checkBox10.Enabled = false;
            }
            else if (checkBox10.Checked == false)
            {
                string cust = "SELECT * FROM Customers";
                Loading(cust, customer_list);
                checkBox8.Enabled = true;
                checkBox10.Enabled = true;
            }
        }

        private void alpha_sortirovka_CheckedChanged(object sender, EventArgs e)
        {
            if (alpha_sortirovka.Checked == true)
            {
                string det = "SELECT * FROM Details ORDER BY Appelation ASC";
                Loading(det, detail_list);
                price_down.Enabled = false;
                price_up.Enabled = false;
            }
            else if (alpha_sortirovka.Checked == false)
            {
                string det = "SELECT * FROM Details";
                Loading(det, detail_list);
                price_down.Enabled = true;
                price_up.Enabled = true;
            }
        }

        private void price_down_CheckedChanged(object sender, EventArgs e)
        {
            if (price_down.Checked == true)
            {
                string det = "SELECT * FROM Details ORDER BY Price ASC";
                Loading(det, detail_list);
                price_up.Enabled = false;
                alpha_sortirovka.Enabled = false;
            }
            else if (price_down.Checked == false)
            {
                string det = "SELECT * FROM Details";
                Loading(det, detail_list);
                alpha_sortirovka.Enabled = true;
                price_up.Enabled = true;
            }
        }

        private void price_up_CheckedChanged(object sender, EventArgs e)
        {
            if (price_up.Checked == true)
            {
                string det = "SELECT * FROM Details ORDER BY Price DESC";
                Loading(det, detail_list);
                price_down.Enabled = false;
                alpha_sortirovka.Enabled = false;
            }
            else if (price_up.Checked == false)
            {
                string det = "SELECT * FROM Details";
                Loading(det, detail_list);
                alpha_sortirovka.Enabled = true;
                price_down.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                string det = "SELECT * FROM History_Price ORDER BY Price ASC";
                Loading(det, history_list);
                checkBox1.Enabled = false;
            }
            else if (checkBox4.Checked == false)
            {
                string det = "SELECT * FROM History_Price";
                Loading(det, history_list);
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string det = "SELECT * FROM History_Price ORDER BY Price DESC";
                Loading(det, history_list);
                checkBox4.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                string det = "SELECT * FROM History_Price";
                Loading(det, history_list);
                checkBox4.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                string prov = "SELECT * FROM Providers ORDER BY Appelation ASC";
                Loading(prov, provider_list);
            }
            else if (checkBox5.Checked == false)
            {
                string prov = "SELECT * FROM Providers";
                Loading(prov, provider_list);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                string det = "SELECT * FROM Shipments ORDER BY Quantity ASC";
                Loading(det, history_list);
            }
            else if (checkBox6.Checked == false)
            {
                string det = "SELECT * FROM Shipments";
                Loading(det, history_list);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filter_ship = "SELECT * FROM Shipments WHERE ID_Provider = '" + i + "'";
            Loading(filter_ship, shipment_list);
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            i = comboBox3.SelectedValue.ToString();
        }

        public void LoadProv()
        {
            SqlCommand sc = new SqlCommand("SELECT * FROM Providers", DataBase.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Appelation";
            comboBox3.ValueMember = "ID";
            comboBox3.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < sale_list.Rows.Count; i++)
            {
                for (int j = 0; j < sale_list.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = sale_list.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < customer_list.Rows.Count; i++)
            {
                for (int j = 0; j < customer_list.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = customer_list.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < detail_list.Rows.Count; i++)
            {
                for (int j = 0; j < detail_list.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = detail_list.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
