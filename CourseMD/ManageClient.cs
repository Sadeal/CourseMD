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
    public partial class ManageClient : Form
    {
        public ManageClient()
        {
            InitializeComponent();
            id.Enabled = true;
            cancel.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void get_Click(object sender, EventArgs e)
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

                SqlCommand select = new SqlCommand("SELECT client_name, [key], address, phone, reserve, city FROM Clients WHERE id_client = " + id.Text, con);
                SqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    client_name.Text = reader["client_name"].ToString();
                    key.Text = reader["key"].ToString();
                    address.Text = reader["address"].ToString();
                    phone.Text = reader["phone"].ToString();
                    reserve.Text = reader["reserve"].ToString();
                    city.Text = reader["city"].ToString();

                }
                con.Close();
                id.Enabled = false;
                cancel.Show();
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

        private void update_Click(object sender, EventArgs e)
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

                SqlCommand insert = new SqlCommand("UPDATE Clients " +
                                     "SET client_name = @client_name, [key] = @key, address = @address, phone = @phone, reserve = @reserve, city = @city " +
                                     "WHERE id_client = " + id.Text, con);
                insert.Parameters.AddWithValue("@client_name", client_name.Text);
                insert.Parameters.AddWithValue("@key", key.Text);
                insert.Parameters.AddWithValue("@address", address.Text);
                insert.Parameters.AddWithValue("@phone", phone.Text);
                insert.Parameters.AddWithValue("@reserve", reserve.Text);
                insert.Parameters.AddWithValue("@city", city.Text);
                insert.ExecuteNonQuery();

                result.Text = "Готово!";
                client_name.Text = "";
                key.Text = "";
                address.Text = "";
                phone.Text = "";
                reserve.Text = "";
                city.Text = "";
                id.Enabled = true;
                cancel.Hide();

                con.Close();
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;// "Ошибка!";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            result.Text = "";
            client_name.Text = "";
            key.Text = "";
            address.Text = "";
            phone.Text = "";
            reserve.Text = "";
            city.Text = "";
            id.Text = "";
            id.Enabled = true;
            cancel.Hide();
        }
    }
}
