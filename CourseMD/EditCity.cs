using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMD
{
    public partial class EditCity : MaterialForm
    {
        public EditCity()
        {
            InitializeComponent();
        }

        private void EditCity_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("user id=User;" +
                                       "password=1q3e2w4r;server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=water_db; " +
                                       "connection timeout=10");
                con.Open();

                //вставить
                SqlCommand insert = new SqlCommand("UPDATE Tariff SET price = " + price.Text +
                                         "WHERE city = \'" + city.Text + "\'", con);
                insert.ExecuteNonQuery();
                result.Text = "Городу " + city.Text + " установлен новый тариф: " + price.Text + " руб.";
                con.Close();
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }
        }
    }
}
