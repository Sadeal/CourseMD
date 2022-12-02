namespace CourseMD
{
    partial class GetColumnUsage
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
            this.components = new System.ComponentModel.Container();
            this.back = new System.Windows.Forms.Button();
            this.water_dbDataSet = new CourseMD.water_dbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.usageTableAdapter = new CourseMD.water_dbDataSetTableAdapters.UsageTableAdapter();
            this.table = new System.Windows.Forms.DataGridView();
            this.usageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.show = new System.Windows.Forms.Button();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.water_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Вернуться";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // water_dbDataSet
            // 
            this.water_dbDataSet.DataSetName = "water_dbDataSet";
            this.water_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "id колонки :";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(198, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(590, 22);
            this.id.TabIndex = 5;
            // 
            // usageTableAdapter
            // 
            this.usageTableAdapter.ClearBeforeFill = true;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.client_name,
            this.liters,
            this.date});
            this.table.Location = new System.Drawing.Point(13, 84);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(775, 354);
            this.table.TabIndex = 6;
            // 
            // usageBindingSource
            // 
            this.usageBindingSource.DataMember = "Usage";
            this.usageBindingSource.DataSource = this.water_dbDataSet;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(13, 42);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(775, 36);
            this.show.TabIndex = 7;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // id_client
            // 
            this.id_client.HeaderText = "id клиента";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.Width = 125;
            // 
            // client_name
            // 
            this.client_name.HeaderText = "ФИО клиента";
            this.client_name.MinimumWidth = 6;
            this.client_name.Name = "client_name";
            this.client_name.Width = 125;
            // 
            // liters
            // 
            this.liters.HeaderText = "Количество вылитых литров";
            this.liters.MinimumWidth = 6;
            this.liters.Name = "liters";
            this.liters.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // GetColumnUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.table);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "GetColumnUsage";
            this.Text = "Получить данные о использовании колонки";
            this.Load += new System.EventHandler(this.GetColumnUsage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.water_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private water_dbDataSet water_dbDataSet;
        private water_dbDataSetTableAdapters.UsageTableAdapter usageTableAdapter;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn litersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usageBindingSource;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn liters;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}