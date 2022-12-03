using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CourseMD
{
    public partial class AddColumn : MaterialForm
    {
        int id;
        public AddColumn()
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

                SqlCommand select = new SqlCommand("SELECT count(id_column) as count FROM [Columns]", con);
                SqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    id = Int32.Parse(reader["count"].ToString()) + 1;
                    result.Text = "Добавлен!\n" + "Под id: " + id;

                }

                //вставить
                SqlCommand insert = new SqlCommand("INSERT INTO [Columns] (id_column, city) " +
                                         "Values (@id, @city)", con);
                insert.Parameters.AddWithValue("@id", id);
                insert.Parameters.AddWithValue("@city", city.Text);
                insert.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                result.Text = ex.Message;
            }
        }
    }
}
