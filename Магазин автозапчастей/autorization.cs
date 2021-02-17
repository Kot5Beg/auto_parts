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
            Main m = new Main();
            m.Show();
            Hide();
        }
    }
}
