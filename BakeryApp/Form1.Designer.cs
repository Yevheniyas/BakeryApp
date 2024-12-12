namespace BakeryApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioBasicBread = new System.Windows.Forms.RadioButton();
            this.radioSweetBread = new System.Windows.Forms.RadioButton();
            this.btnCreateBread = new System.Windows.Forms.Button();
            this.btnCloneBread = new System.Windows.Forms.Button();
            this.listBoxBread = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSweetBread);
            this.groupBox1.Controls.Add(this.radioBasicBread);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип хліба";
            // 
            // radioBasicBread
            // 
            this.radioBasicBread.AutoSize = true;
            this.radioBasicBread.Location = new System.Drawing.Point(6, 35);
            this.radioBasicBread.Name = "radioBasicBread";
            this.radioBasicBread.Size = new System.Drawing.Size(102, 20);
            this.radioBasicBread.TabIndex = 0;
            this.radioBasicBread.TabStop = true;
            this.radioBasicBread.Text = "Basic Bread";
            this.radioBasicBread.UseVisualStyleBackColor = true;
            // 
            // radioSweetBread
            // 
            this.radioSweetBread.AutoSize = true;
            this.radioSweetBread.Location = new System.Drawing.Point(6, 61);
            this.radioSweetBread.Name = "radioSweetBread";
            this.radioSweetBread.Size = new System.Drawing.Size(105, 20);
            this.radioSweetBread.TabIndex = 1;
            this.radioSweetBread.TabStop = true;
            this.radioSweetBread.Text = "Sweet Bread";
            this.radioSweetBread.UseVisualStyleBackColor = true;
            // 
            // btnCreateBread
            // 
            this.btnCreateBread.Location = new System.Drawing.Point(36, 152);
            this.btnCreateBread.Name = "btnCreateBread";
            this.btnCreateBread.Size = new System.Drawing.Size(177, 23);
            this.btnCreateBread.TabIndex = 1;
            this.btnCreateBread.Text = "Create Bread";
            this.btnCreateBread.UseVisualStyleBackColor = true;
            this.btnCreateBread.Click += new System.EventHandler(this.btnCreateBread_Click);
            // 
            // btnCloneBread
            // 
            this.btnCloneBread.Location = new System.Drawing.Point(36, 213);
            this.btnCloneBread.Name = "btnCloneBread";
            this.btnCloneBread.Size = new System.Drawing.Size(177, 23);
            this.btnCloneBread.TabIndex = 2;
            this.btnCloneBread.Text = "Clone Bread";
            this.btnCloneBread.UseVisualStyleBackColor = true;
            this.btnCloneBread.Click += new System.EventHandler(this.btnCloneBread_Click);
            // 
            // listBoxBread
            // 
            this.listBoxBread.FormattingEnabled = true;
            this.listBoxBread.ItemHeight = 16;
            this.listBoxBread.Location = new System.Drawing.Point(305, 28);
            this.listBoxBread.Name = "listBoxBread";
            this.listBoxBread.Size = new System.Drawing.Size(344, 388);
            this.listBoxBread.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxBread);
            this.Controls.Add(this.btnCloneBread);
            this.Controls.Add(this.btnCreateBread);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSweetBread;
        private System.Windows.Forms.RadioButton radioBasicBread;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCreateBread;
        private System.Windows.Forms.Button btnCloneBread;
        private System.Windows.Forms.ListBox listBoxBread;
    }
}

