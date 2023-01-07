namespace ParentalControl
{
    partial class child
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
            this.back_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh_info = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // back_start
            // 
            this.back_start.Location = new System.Drawing.Point(690, 405);
            this.back_start.Name = "back_start";
            this.back_start.Size = new System.Drawing.Size(89, 43);
            this.back_start.TabIndex = 0;
            this.back_start.Text = "Ок";
            this.back_start.UseVisualStyleBackColor = true;
            this.back_start.Click += new System.EventHandler(this.back_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о времени блокировки и приложений ";
            // 
            // refresh_info
            // 
            this.refresh_info.Location = new System.Drawing.Point(314, 431);
            this.refresh_info.Name = "refresh_info";
            this.refresh_info.Size = new System.Drawing.Size(150, 33);
            this.refresh_info.TabIndex = 3;
            this.refresh_info.Text = "Обновить информацию";
            this.refresh_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refresh_info.UseVisualStyleBackColor = true;
            this.refresh_info.Click += new System.EventHandler(this.refresh_info_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(229, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 355);
            this.listBox1.TabIndex = 4;
            // 
            // child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 476);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.refresh_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_start);
            this.Name = "child";
            this.Text = "child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh_info;
        private System.Windows.Forms.ListBox listBox1;
    }
}