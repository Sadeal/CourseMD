using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMD
{
    public partial class GetColumnUsage : Form
    {
        public GetColumnUsage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void GetColumnUsage_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            table.Refresh();
            try {
            SqlConnection con = new SqlConnection("user id=User;" +
                                       "password=1q3e2w4r;server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=water_db; " +
                                       "connection timeout=10; " +
                                       "MultipleActiveResultSets = True");
            con.Open();

            SqlCommand select = new SqlCommand("SELECT id_client, client_name, liters, date FROM Usage WHERE id_column = " + id.Text, con);
            SqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                    table.Rows.Add(
                        reader["id_client"].ToString(),
                        reader["client_name"].ToString(),
                        reader["liters"].ToString(),
                        reader["date"].ToString()
                    );

            }
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
}
    }
}
