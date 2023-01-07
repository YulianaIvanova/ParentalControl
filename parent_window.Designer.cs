namespace ParentalControl
{
    partial class parent_window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parent_window));
            this.label1 = new System.Windows.Forms.Label();
            this.choice_file = new System.Windows.Forms.Button();
            this.refresh_list = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backbutton = new System.Windows.Forms.Button();
            this.choose_time_block = new System.Windows.Forms.Button();
            this.unblock_app = new System.Windows.Forms.Button();
            this.block_app = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // choice_file
            // 
            resources.ApplyResources(this.choice_file, "choice_file");
            this.choice_file.Name = "choice_file";
            this.choice_file.UseVisualStyleBackColor = true;
            this.choice_file.Click += new System.EventHandler(this.choice_file_Click);
            // 
            // refresh_list
            // 
            resources.ApplyResources(this.refresh_list, "refresh_list");
            this.refresh_list.Name = "refresh_list";
            this.refresh_list.UseVisualStyleBackColor = true;
            this.refresh_list.Click += new System.EventHandler(this.refresh_list_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // backbutton
            // 
            resources.ApplyResources(this.backbutton, "backbutton");
            this.backbutton.Name = "backbutton";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // choose_time_block
            // 
            resources.ApplyResources(this.choose_time_block, "choose_time_block");
            this.choose_time_block.Name = "choose_time_block";
            this.choose_time_block.UseVisualStyleBackColor = true;
            this.choose_time_block.Click += new System.EventHandler(this.choose_time_block_Click);
            // 
            // unblock_app
            // 
            resources.ApplyResources(this.unblock_app, "unblock_app");
            this.unblock_app.Name = "unblock_app";
            this.unblock_app.UseVisualStyleBackColor = true;
            this.unblock_app.Click += new System.EventHandler(this.unblock_app_Click);
            // 
            // block_app
            // 
            resources.ApplyResources(this.block_app, "block_app");
            this.block_app.Name = "block_app";
            this.block_app.UseVisualStyleBackColor = true;
            this.block_app.Click += new System.EventHandler(this.block_app_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // parent_window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.block_app);
            this.Controls.Add(this.unblock_app);
            this.Controls.Add(this.choose_time_block);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.refresh_list);
            this.Controls.Add(this.choice_file);
            this.Controls.Add(this.label1);
            this.Name = "parent_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choice_file;
        private System.Windows.Forms.Button refresh_list;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button choose_time_block;
        private System.Windows.Forms.Button unblock_app;
        private System.Windows.Forms.Button block_app;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}