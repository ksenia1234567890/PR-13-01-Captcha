namespace PR_13_01_Capcha
{
    partial class Capcha
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tcaptcha = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст с картинки";
            // 
            // Tcaptcha
            // 
            this.Tcaptcha.Location = new System.Drawing.Point(106, 237);
            this.Tcaptcha.Multiline = true;
            this.Tcaptcha.Name = "Tcaptcha";
            this.Tcaptcha.Size = new System.Drawing.Size(314, 35);
            this.Tcaptcha.TabIndex = 2;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(448, 292);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 3;
            this.input.Text = "Ввод";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 292);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Capcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 327);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Tcaptcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Capcha";
            this.Text = "Капча";
            this.Load += new System.EventHandler(this.Capcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tcaptcha;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button exit;
    }
}