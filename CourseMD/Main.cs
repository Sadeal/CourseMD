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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            addClient.Hide();
            manageClient.Hide();
            getClientUsage.Hide();

            addColumn.Hide();
            manageColumn.Hide();
            getColumnUsage.Hide();

            addCity.Hide();
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

        private void clients_Click(object sender, EventArgs e)
        {
            //show
            addClient.Show();
            manageClient.Show();
            getClientUsage.Show();
        

            //hide
            addCity.Hide();

            addColumn.Hide();
            manageColumn.Hide();
            getColumnUsage.Hide();
        }

        private void columns_Click(object sender, EventArgs e)
        {
            //show
            addColumn.Show();
            manageColumn.Show();
            getColumnUsage.Show();

            //hide
            addCity.Hide();

            addClient.Hide();
            manageClient.Hide();
            getClientUsage.Hide();
        }

        private void citys_Click(object sender, EventArgs e)
        {
            //show
            addCity.Show();
            
            //hide
            addClient.Hide();
            manageClient.Hide();
            getClientUsage.Hide();

            addColumn.Hide();
            manageColumn.Hide();
            getColumnUsage.Hide();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
