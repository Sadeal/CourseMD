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
    public partial class GetSQL : MaterialForm
    {
        public GetSQL()
        {
            InitializeComponent();
        }

        private void GetSQL_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
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

                SqlCommand select = new SqlCommand("SELECT [Columns].id_column, [Columns].[city], [Columns].month_liters, [Usage].date, count([Usage].liters) as 'Liters'\r\nFROM [Columns]\r\nINNER JOIN Tariff\r\n\tON Tariff.city = [Columns].city\r\nINNER JOIN Usage\r\n\tON Usage.id_column = [Columns].id_column\r\nWHERE [columns].id_column = " + id.Text +"\r\nGROUP BY [Columns].id_column, [Columns].city, [Columns].month_liters, [Usage].date", con);
                SqlDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    table.Rows.Add(
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString()
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
