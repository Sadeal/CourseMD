namespace CourseMD
{
    partial class ManageClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.reserve = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Вернуться";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "id клиента";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(192, 15);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(596, 22);
            this.id.TabIndex = 2;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(681, 42);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(107, 39);
            this.get.TabIndex = 3;
            this.get.Text = "Получить";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(615, 265);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 37;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(681, 255);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(107, 36);
            this.update.TabIndex = 36;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Населённый пункт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Начальный резерв";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ключ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "ФИО";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(170, 227);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(618, 22);
            this.city.TabIndex = 29;
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(170, 199);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(618, 22);
            this.reserve.TabIndex = 28;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(170, 171);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(618, 22);
            this.phone.TabIndex = 27;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(170, 143);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(618, 22);
            this.address.TabIndex = 26;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(170, 115);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(618, 22);
            this.key.TabIndex = 25;
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(170, 87);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(618, 22);
            this.client_name.TabIndex = 24;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(568, 43);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(107, 38);
            this.cancel.TabIndex = 38;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ManageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.city);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.address);
            this.Controls.Add(this.key);
            this.Controls.Add(this.client_name);
            this.Controls.Add(this.get);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "ManageClient";
            this.Text = "Управление клиентами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox reserve;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.Button cancel;
    }
}