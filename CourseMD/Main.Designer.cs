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
            this.client = new MaterialSkin.Controls.MaterialButton();
            this.column = new MaterialSkin.Controls.MaterialButton();
            this.city = new MaterialSkin.Controls.MaterialButton();
            this.getClients = new System.Windows.Forms.Button();
            this.getColumns = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.editCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageClient
            // 
            this.manageClient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.manageClient.Location = new System.Drawing.Point(192, 149);
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
            this.addColumn.Location = new System.Drawing.Point(6, 149);
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
            this.getColumnUsage.Location = new System.Drawing.Point(378, 149);
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
            this.addClient.Location = new System.Drawing.Point(6, 149);
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
            this.addCity.Location = new System.Drawing.Point(93, 149);
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
            this.getClientUsage.Location = new System.Drawing.Point(378, 149);
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
            this.manageColumn.Location = new System.Drawing.Point(192, 149);
            this.manageColumn.Name = "manageColumn";
            this.manageColumn.Size = new System.Drawing.Size(180, 83);
            this.manageColumn.TabIndex = 6;
            this.manageColumn.Text = "Удалить колонку";
            this.manageColumn.UseVisualStyleBackColor = false;
            this.manageColumn.Click += new System.EventHandler(this.ManageColumn_Click);
            // 
            // client
            // 
            this.client.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.client.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.client.Depth = 0;
            this.client.HighEmphasis = true;
            this.client.Icon = null;
            this.client.Location = new System.Drawing.Point(34, 89);
            this.client.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.client.MouseState = MaterialSkin.MouseState.HOVER;
            this.client.Name = "client";
            this.client.NoAccentTextColor = System.Drawing.Color.Empty;
            this.client.Size = new System.Drawing.Size(92, 36);
            this.client.TabIndex = 10;
            this.client.Text = "Клиенты";
            this.client.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.client.UseAccentColor = false;
            this.client.UseVisualStyleBackColor = true;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // column
            // 
            this.column.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.column.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.column.Depth = 0;
            this.column.HighEmphasis = true;
            this.column.Icon = null;
            this.column.Location = new System.Drawing.Point(220, 89);
            this.column.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.column.MouseState = MaterialSkin.MouseState.HOVER;
            this.column.Name = "column";
            this.column.NoAccentTextColor = System.Drawing.Color.Empty;
            this.column.Size = new System.Drawing.Size(92, 36);
            this.column.TabIndex = 11;
            this.column.Text = "Колонки";
            this.column.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.column.UseAccentColor = false;
            this.column.UseVisualStyleBackColor = true;
            this.column.Click += new System.EventHandler(this.column_Click);
            // 
            // city
            // 
            this.city.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.city.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.city.Depth = 0;
            this.city.HighEmphasis = true;
            this.city.Icon = null;
            this.city.Location = new System.Drawing.Point(413, 89);
            this.city.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.city.MouseState = MaterialSkin.MouseState.HOVER;
            this.city.Name = "city";
            this.city.NoAccentTextColor = System.Drawing.Color.Empty;
            this.city.Size = new System.Drawing.Size(80, 36);
            this.city.TabIndex = 12;
            this.city.Text = "Города";
            this.city.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.city.UseAccentColor = false;
            this.city.UseVisualStyleBackColor = true;
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // getClients
            // 
            this.getClients.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.getClients.Location = new System.Drawing.Point(192, 238);
            this.getClients.Name = "getClients";
            this.getClients.Size = new System.Drawing.Size(180, 83);
            this.getClients.TabIndex = 13;
            this.getClients.Text = "Посмотреть клиентов";
            this.getClients.UseVisualStyleBackColor = false;
            this.getClients.Click += new System.EventHandler(this.getClients_Click);
            // 
            // getColumns
            // 
            this.getColumns.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.getColumns.Location = new System.Drawing.Point(192, 238);
            this.getColumns.Name = "getColumns";
            this.getColumns.Size = new System.Drawing.Size(180, 83);
            this.getColumns.TabIndex = 14;
            this.getColumns.Text = "Посмотреть колонки";
            this.getColumns.UseVisualStyleBackColor = false;
            this.getColumns.Click += new System.EventHandler(this.getColumns_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(248, 32);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(310, 37);
            this.b1.TabIndex = 15;
            this.b1.Text = "Оптимизированный запрос";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // editCity
            // 
            this.editCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editCity.Location = new System.Drawing.Point(279, 149);
            this.editCity.Name = "editCity";
            this.editCity.Size = new System.Drawing.Size(180, 83);
            this.editCity.TabIndex = 16;
            this.editCity.Text = "Редактировать населённый пункт";
            this.editCity.UseVisualStyleBackColor = false;
            this.editCity.Click += new System.EventHandler(this.editCity_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(619, 465);
            this.Controls.Add(this.editCity);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.getColumns);
            this.Controls.Add(this.getClients);
            this.Controls.Add(this.city);
            this.Controls.Add(this.column);
            this.Controls.Add(this.client);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageClient;
        private System.Windows.Forms.Button addColumn;
        private System.Windows.Forms.Button getColumnUsage;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button addCity;
        private System.Windows.Forms.Button getClientUsage;
        private System.Windows.Forms.Button manageColumn;
        private MaterialSkin.Controls.MaterialButton client;
        private MaterialSkin.Controls.MaterialButton column;
        private MaterialSkin.Controls.MaterialButton city;
        private System.Windows.Forms.Button getClients;
        private System.Windows.Forms.Button getColumns;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button editCity;
    }
}

