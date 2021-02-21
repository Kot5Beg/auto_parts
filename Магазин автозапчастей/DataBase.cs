using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Магазин_автозапчастей
{
    class DataBase
    {
        public static string connectString = @"Data Source=KOTBEGEMOT\SQLEXPRESS;Initial Catalog = auto_parts; Integrated Security = True;";//оставить только её
        public static SqlConnection Con;

        public static void OpenCon()
        {
            Con = new SqlConnection(connectString);
            Con.Open();
        }

        public static void CloseConnection()
        {
            Con.Close();
        }

        public static DataTable Load(string SqlQuery)
        {
            OpenCon();
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand(SqlQuery, Con);
            query.CommandType = CommandType.Text;
            SqlDataReader dr = query.ExecuteReader();
            dt.Load(dr);
            CloseConnection();
            return dt;
        }

        public static void Delete(DataGridView grid, string delete)
        {
            DataBase.OpenCon();
            var num = (int)grid.CurrentRow.Cells["ID"].Value;
            SqlCommand sc = new SqlCommand(String.Format(delete, num), DataBase.Con);
            sc.ExecuteNonQuery();
            DataBase.CloseConnection();
        }
    }
}
