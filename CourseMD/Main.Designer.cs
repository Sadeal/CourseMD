namespace CourseMD
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.manageClient = new System.Windows.Forms.Button();
            this.addColumn = new System.Windows.Forms.Button();
            this.getColumnUsage = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.addCity = new System.Windows.Forms.Button();
            this.getClientUsage = new System.Windows.Forms.Button();
            this.manageColumn = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.columns = new System.Windows.Forms.Button();
            this.citys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageClient
            // 
            this.manageClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.manageClient.Location = new System.Drawing.Point(60, 140);
            this.manageClient.Name = "manageClient";
            this.manageClient.Size = new System.Drawing.Size(180, 83);
            this.manageClient.TabIndex = 0;
            this.manageClient.Text = "Редактировать данные о клиенте";
            this.manageClient.UseVisualStyleBackColor = false;
            this.manageClient.Click += new System.EventHandler(this.manageClient_Click);
            // 
            // addColumn
            // 
            this.addColumn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addColumn.Location = new System.Drawing.Point(61, 51);
            this.addColumn.Name = "addColumn";
            this.addColumn.Size = new System.Drawing.Size(180, 83);
            this.addColumn.TabIndex = 1;
            this.addColumn.Text = "Добавить колонку";
            this.addColumn.UseVisualStyleBackColor = false;
            this.addColumn.Click += new System.EventHandler(this.addColumn_Click);
            // 
            // getColumnUsage
            // 
            this.getColumnUsage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.getColumnUsage.Location = new System.Drawing.Point(61, 229);
            this.getColumnUsage.Name = "getColumnUsage";
            this.getColumnUsage.Size = new System.Drawing.Size(180, 83);
            this.getColumnUsage.TabIndex = 2;
            this.getColumnUsage.Text = "Посмотреть использования по колонке";
            this.getColumnUsage.UseVisualStyleBackColor = false;
            this.getColumnUsage.Click += new System.EventHandler(this.getColumnUsage_Click);
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addClient.Location = new System.Drawing.Point(60, 51);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(180, 83);
            this.addClient.TabIndex = 3;
            this.addClient.Text = "Добавить клиента";
            this.addClient.UseVisualStyleBackColor = false;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // addCity
            // 
            this.addCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCity.Location = new System.Drawing.Point(61, 51);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(180, 83);
            this.addCity.TabIndex = 4;
            this.addCity.Text = "Добавить населённый пункт";
            this.addCity.UseVisualStyleBackColor = false;
            this.addCity.Click += new System.EventHandler(this.addCity_Click);
            // 
            // getClientUsage
            // 
            this.getClientUsage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.getClientUsage.Location = new System.Drawing.Point(61, 229);
            this.getClientUsage.Name = "getClientUsage";
            this.getClientUsage.Size = new System.Drawing.Size(180, 83);
            this.getClientUsage.TabIndex = 5;
            this.getClientUsage.Text = "Посмотреть использования по клиенту";
            this.getClientUsage.UseVisualStyleBackColor = false;
            this.getClientUsage.Click += new System.EventHandler(this.getClientUsage_Click);
            // 
            // manageColumn
            // 
            this.manageColumn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.manageColumn.Location = new System.Drawing.Point(61, 140);
            this.manageColumn.Name = "manageColumn";
            this.manageColumn.Size = new System.Drawing.Size(180, 83);
            this.manageColumn.TabIndex = 6;
            this.manageColumn.Text = "Удалить колонку";
            this.manageColumn.UseVisualStyleBackColor = false;
            this.manageColumn.Click += new System.EventHandler(this.ManageColumn_Click);
            // 
            // clients
            // 
            this.clients.Location = new System.Drawing.Point(12, 12);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(89, 33);
            this.clients.TabIndex = 7;
            this.clients.Text = "Клиенты";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // columns
            // 
            this.columns.Location = new System.Drawing.Point(107, 12);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(89, 33);
            this.columns.TabIndex = 8;
            this.columns.Text = "Колонки";
            this.columns.UseVisualStyleBackColor = true;
            this.columns.Click += new System.EventHandler(this.columns_Click);
            // 
            // citys
            // 
            this.citys.Location = new System.Drawing.Point(202, 12);
            this.citys.Name = "citys";
            this.citys.Size = new System.Drawing.Size(91, 33);
            this.citys.TabIndex = 9;
            this.citys.Text = "Города";
            this.citys.UseVisualStyleBackColor = true;
            this.citys.Click += new System.EventHandler(this.citys_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(301, 338);
            this.Controls.Add(this.citys);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.manageColumn);
            this.Controls.Add(this.getClientUsage);
            this.Controls.Add(this.addCity);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.getColumnUsage);
            this.Controls.Add(this.addColumn);
            this.Controls.Add(this.manageClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageClient;
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.Button getColumnUsage;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.Button getClientUsage;
        private System.Windows.Forms.Button manageColumn;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button columns;
        private System.Windows.Forms.Button citys;
    }
}

