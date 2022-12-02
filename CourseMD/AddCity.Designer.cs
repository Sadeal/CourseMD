namespace CourseMD
{
    partial class AddCity
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
            this.label2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Вернуться";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Город :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стоимость за литр";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(182, 13);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(227, 22);
            this.city.TabIndex = 5;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(182, 47);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(227, 22);
            this.price.TabIndex = 6;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 127);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(397, 83);
            this.result.TabIndex = 7;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(13, 75);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(396, 46);
            this.add.TabIndex = 8;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 222);
            this.Controls.Add(this.add);
            this.Controls.Add(this.result);
            this.Controls.Add(this.price);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "AddCity";
            this.Text = "Добавить населённый пункт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button add;
    }
}