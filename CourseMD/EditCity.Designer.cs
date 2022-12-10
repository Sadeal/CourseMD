namespace CourseMD
{
    partial class EditCity
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
            this.edit = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(32, 93);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Вернуться";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(34, 156);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(396, 46);
            this.edit.TabIndex = 14;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(33, 208);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(397, 83);
            this.result.TabIndex = 13;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(203, 128);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(227, 22);
            this.price.TabIndex = 12;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(203, 94);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(227, 22);
            this.city.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Новая стоимость за литр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Город :";
            // 
            // EditCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 333);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.price);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "EditCity";
            this.Text = "EditCity";
            this.Load += new System.EventHandler(this.EditCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}