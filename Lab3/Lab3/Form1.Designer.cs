
namespace Lab3
{
    partial class Form1
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
            this.refill_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.get_button = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.task_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refill_button
            // 
            this.refill_button.Location = new System.Drawing.Point(12, 30);
            this.refill_button.Name = "refill_button";
            this.refill_button.Size = new System.Drawing.Size(196, 24);
            this.refill_button.TabIndex = 0;
            this.refill_button.Text = "Перезаполнить";
            this.refill_button.UseVisualStyleBackColor = true;
            this.refill_button.Click += new System.EventHandler(this.refill_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 93);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 69);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // get_button
            // 
            this.get_button.Location = new System.Drawing.Point(12, 168);
            this.get_button.Name = "get_button";
            this.get_button.Size = new System.Drawing.Size(196, 21);
            this.get_button.TabIndex = 8;
            this.get_button.Text = "Взять";
            this.get_button.UseVisualStyleBackColor = true;
            this.get_button.Click += new System.EventHandler(this.get_button_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(12, 61);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(195, 26);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // task_button
            // 
            this.task_button.Location = new System.Drawing.Point(12, 4);
            this.task_button.Name = "task_button";
            this.task_button.Size = new System.Drawing.Size(195, 20);
            this.task_button.TabIndex = 10;
            this.task_button.Text = "Задание";
            this.task_button.UseVisualStyleBackColor = true;
            this.task_button.Click += new System.EventHandler(this.task_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 208);
            this.Controls.Add(this.task_button);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.get_button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.refill_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refill_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button get_button;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button task_button;
    }
}

