namespace CourseMD
{
    partial class GetClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(21, 93);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Вернуться";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.client_name,
            this.liters,
            this.date,
            this.phone,
            this.reserve,
            this.city});
            this.table.Location = new System.Drawing.Point(6, 122);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(1061, 402);
            this.table.TabIndex = 7;
            // 
            // id_column
            // 
            this.id_column.HeaderText = "id";
            this.id_column.MinimumWidth = 6;
            this.id_column.Name = "id_column";
            this.id_column.Width = 50;
            // 
            // client_name
            // 
            this.client_name.HeaderText = "ФИО";
            this.client_name.MinimumWidth = 6;
            this.client_name.Name = "client_name";
            this.client_name.Width = 160;
            // 
            // liters
            // 
            this.liters.HeaderText = "Ключ";
            this.liters.MinimumWidth = 6;
            this.liters.Name = "liters";
            this.liters.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Адрес";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // reserve
            // 
            this.reserve.HeaderText = "Резерв";
            this.reserve.MinimumWidth = 6;
            this.reserve.Name = "reserve";
            this.reserve.Width = 50;
            // 
            // city
            // 
            this.city.HeaderText = "Город";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 125;
            // 
            // GetClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 530);
            this.Controls.Add(this.table);
            this.Controls.Add(this.back);
            this.Name = "GetClients";
            this.Text = "GetClients";
            this.Load += new System.EventHandler(this.GetClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn liters;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}