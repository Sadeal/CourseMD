using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMD
{
    public partial class ManageColumn : MaterialForm
    {
        public ManageColumn()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("user id=User;" +
                                           "password=1q3e2w4r;server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=water_db; " +
                                           "connection timeout=10; " +
                                           "MultipleActiveResultSets = True");
                con.Open();

                SqlCommand delete = new SqlCommand("DELETE FROM Columns " +
                                     "WHERE id_column = " + id.Text, con);
                delete.ExecuteNonQuery();

                con.Close();
                result.Text = "Удалена колонка " + id.Text;
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;// "Ошибка!";
            }
        }
    }
}
