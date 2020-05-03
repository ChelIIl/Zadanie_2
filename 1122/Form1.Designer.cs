namespace _1122
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Кратна ли сумма \r\nдвузначного числа 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(70, 83);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 20);
            this.num.TabIndex = 2;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(81, 128);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(89, 33);
            this.check.TabIndex = 3;
            this.check.Text = "Проверить";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // rez
            // 
            this.rez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rez.Location = new System.Drawing.Point(194, 83);
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(53, 13);
            this.rez.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 173);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.check);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox rez;
    }
}

