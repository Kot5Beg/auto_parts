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
    }
}
