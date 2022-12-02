using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CourseMD
{
    public partial class AddClient : Form
    {
        int id;
        public AddClient()
        {
            InitializeComponent();
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
                                           "connection timeout=10; " +
                                           "MultipleActiveResultSets = True");
                con.Open();

                SqlCommand select = new SqlCommand("SELECT count(id_client) as count FROM Clients", con);
                SqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader["count"].ToString()) + 1;
                }

                SqlCommand insert = new SqlCommand("INSERT INTO Clients (id_client, client_name, [key], address, phone, reserve, city) " +
                                     "Values (@id_client, @client_name, @key, @address, @phone, @reserve, @city)", con);
                insert.Parameters.AddWithValue("@id_client", id);
                insert.Parameters.AddWithValue("@client_name", client_name.Text);
                insert.Parameters.AddWithValue("@key", key.Text);
                insert.Parameters.AddWithValue("@address", address.Text);
                insert.Parameters.AddWithValue("@phone", phone.Text);
                insert.Parameters.AddWithValue("@reserve", reserve.Text);
                insert.Parameters.AddWithValue("@city", city.Text);
                insert.ExecuteNonQuery();

                result.Text = "Готово!";

                con.Close();
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;// "Ошибка!";
            }
        }
    }
}
