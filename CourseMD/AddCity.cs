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
using System.Data.Common;
using System.Xml;
using System.Reflection.Emit;
using System.Globalization;

namespace CourseMD
{
    public partial class AddCity : Form
    {
        private SqlDataReader myReader;

        public AddCity()
        {
            InitializeComponent();
            /*SqlConnection myConnection = new SqlConnection("user id=User;" +
                                       "password=1q3e2w4r;server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=water_db; " +
                                       "connection timeout=10");
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //вставить
            SqlCommand insert = new SqlCommand("INSERT INTO Tariff (city, price) " +
                                     "Values (@city, @price)", myConnection);
            insert.Parameters.AddWithValue("@city", "Pivovariha");
            insert.Parameters.AddWithValue("@price", "0.001");
            insert.ExecuteNonQuery();

            //вытянуть
            SqlCommand select = new SqlCommand("SELECT * FROM Tariff", myConnection);
            SqlDataReader reader = select.ExecuteReader();
            while (reader.Read())
            {
                test.Text = reader["city"].ToString() + reader["price"].ToString() + "\n";
            }*/
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
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
            SqlCommand insert = new SqlCommand("INSERT INTO Tariff (city, price) " +
                                     "Values (@city, @price)", con);
                insert.Parameters.AddWithValue("@city", city.Text);
                insert.Parameters.AddWithValue("@price", float.Parse(price.Text));
                insert.ExecuteNonQuery();
                result.Text = "Добавлен!";
                con.Close();
            }
            catch(Exception ex)
            {
                result.Text = ex.Message;
            }


        }
    }
}
