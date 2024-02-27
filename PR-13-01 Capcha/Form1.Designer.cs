namespace PR_13_01_Capcha
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
            this.Tlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entrance = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tlogin
            // 
            this.Tlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tlogin.Location = new System.Drawing.Point(87, 65);
            this.Tlogin.Multiline = true;
            this.Tlogin.Name = "Tlogin";
            this.Tlogin.Size = new System.Drawing.Size(279, 32);
            this.Tlogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(191, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Tpassword
            // 
            this.Tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tpassword.Location = new System.Drawing.Point(87, 149);
            this.Tpassword.Multiline = true;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.Size = new System.Drawing.Size(279, 32);
            this.Tpassword.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(191, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // entrance
            // 
            this.entrance.Location = new System.Drawing.Point(380, 208);
            this.entrance.Name = "entrance";
            this.entrance.Size = new System.Drawing.Size(75, 23);
            this.entrance.TabIndex = 2;
            this.entrance.Text = "Вход";
            this.entrance.UseVisualStyleBackColor = true;
            this.entrance.Click += new System.EventHandler(this.entrance_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 208);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 243);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.entrance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.Tlogin);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrance;
        private System.Windows.Forms.Button exit;
    }
}

