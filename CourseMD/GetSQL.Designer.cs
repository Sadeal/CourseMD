namespace CourseMD
{
    partial class GetSQL
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
            this.table = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.city,
            this.month_liters,
            this.date,
            this.Liters});
            this.table.Location = new System.Drawing.Point(7, 163);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(864, 281);
            this.table.TabIndex = 0;
            // 
            // id_column
            // 
            this.id_column.HeaderText = "id_column";
            this.id_column.MinimumWidth = 6;
            this.id_column.Name = "id_column";
            this.id_column.Width = 125;
            // 
            // city
            // 
            this.city.HeaderText = "city";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 125;
            // 
            // month_liters
            // 
            this.month_liters.HeaderText = "month_liters";
            this.month_liters.MinimumWidth = 6;
            this.month_liters.Name = "month_liters";
            this.month_liters.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // Liters
            // 
            this.Liters.HeaderText = "Liters";
            this.Liters.MinimumWidth = 6;
            this.Liters.Name = "Liters";
            this.Liters.Width = 125;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(29, 115);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(775, 36);
            this.show.TabIndex = 10;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(214, 85);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(590, 22);
            this.id.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "id колонки :";
            // 
            // GetSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Name = "GetSQL";
            this.Text = "GetSQL";
            this.Load += new System.EventHandler(this.GetSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_liters;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liters;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
    }
}