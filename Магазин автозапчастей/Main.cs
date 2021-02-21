using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магазин_автозапчастей
{
    public partial class Main : Form
    {
        public static DataTable res;

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
            upd_cust uc = new upd_cust();
            uc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_sale addsale = new add_sale();
            addsale.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            upd_sale us = new upd_sale();
            us.ShowDialog();
        }

        private void add_ship_Click(object sender, EventArgs e)
        {
            add_shipcs aship = new add_shipcs();
            aship.ShowDialog();
        }

        private void update_ship_Click(object sender, EventArgs e)
        {
            upd_ship us = new upd_ship();
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
            string shipsearch = "SELECT * FROM Shipments WHERE CONCAT (ID_Detail, ID_Provider, Quantity, Date) LIKE '%" + textBox5.Text + "%' ";
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
    }
}
