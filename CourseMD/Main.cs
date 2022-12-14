using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMD
{
    public partial class Main : MaterialForm
    {
        int x = 423;
        int y = 200;
        public Main()
        {
            InitializeComponent();

            addClient.Hide();
            manageClient.Hide();
            getClientUsage.Hide();
            getClients.Hide();

            addColumn.Hide();
            manageColumn.Hide();
            getColumnUsage.Hide();
            getColumns.Hide();

            addCity.Hide();
            editCity.Hide();

            this.Size = new Size(423, 130);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
        }

        private void getColumnUsage_Click(object sender, EventArgs e)
        {
            GetColumnUsage getColumnUsage = new GetColumnUsage();
            getColumnUsage.Show();
            this.Hide();
        }

        private void manageClient_Click(object sender, EventArgs e)
        {
            ManageClient manageClient = new ManageClient();
            manageClient.Show();
            this.Hide();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
            this.Hide();
        }

        private void addColumn_Click(object sender, EventArgs e)
        {
            AddColumn addColumn = new AddColumn();
            addColumn.Show();
            this.Hide();
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            AddCity addCity = new AddCity();
            addCity.Show();
            this.Hide();
        }

        private void getClientUsage_Click(object sender, EventArgs e)
        {
            GetClientUsage getClientUsage = new GetClientUsage();
            getClientUsage.Show();
            this.Hide();
        }

        private void ManageColumn_Click(object sender, EventArgs e)
        {
            ManageColumn manageColumn = new ManageColumn();
            manageColumn.Show();
            this.Hide();
        }

        private void client_Click(object sender, EventArgs e)
        {
            this.Size = new Size(x, y+80);
            //show
            addClient.Show();
            manageClient.Show();
            getClientUsage.Show();
            getClients.Show();
        

            //hide
            addCity.Hide();
            editCity.Hide();

            addColumn.Hide();
            manageColumn.Hide();
            getColumnUsage.Hide();
            getColumns.Hide();
        }

        private void column_Click(object sender, EventArgs e)
        {
            this.Size = new Size(x, y+80);
            //show
            addColumn.Show();
            manageColumn.Show();
            getColumnUsage.Show();
            getColumns.Show();

            //hide
            addCity.Hide();
            editCity.Hide();

            addClient.Hide();
            manageClient.Hide();
            getClientUsage.Hide();
            getClients.Hide();
        }

        private void city_Click(object sender, EventArgs e)
        {

            this.Size = new Size(x, y);  //405 190
            //show
            addCity.Show();
            editCity.Show();
            
            //hide
            addClient.Hide();
            manageClient.Hide();
            getClientUsage.Hide();
            getClients.Hide();

            addColumn.Hide();
            manageColumn.Hide();
            getColumnUsage.Hide();
            getColumns.Hide();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getClients_Click(object sender, EventArgs e)
        {
            GetClients getClients = new GetClients();
            getClients.Show();
            this.Hide();
        }

        private void getColumns_Click(object sender, EventArgs e)
        {
            GetColumns getColumns = new GetColumns();
            getColumns.Show();
            this.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            GetSQL getSQL = new GetSQL();
            getSQL.Show();
        }

        private void editCity_Click(object sender, EventArgs e)
        {
            EditCity editCity = new EditCity();
            editCity.Show();
            this.Hide();
        }
    }
}
