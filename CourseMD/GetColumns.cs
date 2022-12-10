﻿using MaterialSkin.Controls;
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
    public partial class GetColumns : MaterialForm
    {
        public GetColumns()
        {
            InitializeComponent();
            table.Rows.Clear();
            table.Refresh();
            try
            {
                SqlConnection con = new SqlConnection("user id=User;" +
                                           "password=1q3e2w4r;server=localhost;" +
                                           "Trusted_Connection=yes;" +
                                           "database=water_db; " +
                                           "connection timeout=10; " +
                                           "MultipleActiveResultSets = True");
                con.Open();

                SqlCommand select = new SqlCommand("SELECT id_column, city, temp, month_liters, signal, refresh, last_message, error FROM Columns", con);
                SqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    table.Rows.Add(
                        reader["id_column"].ToString(),
                        reader["city"].ToString(),
                        reader["temp"].ToString(),
                        reader["month_liters"].ToString(),
                        reader["signal"].ToString(),
                        reader["refresh"].ToString(),
                        reader["last_message"].ToString(),
                        reader["error"].ToString()
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

        private void GetColumns_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
