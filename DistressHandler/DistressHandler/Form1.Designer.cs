namespace DistressHandler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_run = new System.Windows.Forms.Button();
            this.txtcommand = new System.Windows.Forms.TextBox();
            this.rtbcommand = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvDevices);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADB Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvDevices
            // 
            this.lvDevices.Location = new System.Drawing.Point(156, 31);
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(417, 251);
            this.lvDevices.TabIndex = 2;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Tile;
            this.lvDevices.SelectedIndexChanged += new System.EventHandler(this.lvDevices_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wireless ADB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initialize ADB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_run);
            this.tabPage2.Controls.Add(this.txtcommand);
            this.tabPage2.Controls.Add(this.rtbcommand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Terminal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(474, 258);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(91, 20);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // txtcommand
            // 
            this.txtcommand.Location = new System.Drawing.Point(20, 259);
            this.txtcommand.Name = "txtcommand";
            this.txtcommand.Size = new System.Drawing.Size(431, 20);
            this.txtcommand.TabIndex = 1;
            this.txtcommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcommand_KeyPress);
            // 
            // rtbcommand
            // 
            this.rtbcommand.Location = new System.Drawing.Point(20, 15);
            this.rtbcommand.Name = "rtbcommand";
            this.rtbcommand.ReadOnly = true;
            this.rtbcommand.Size = new System.Drawing.Size(546, 237);
            this.rtbcommand.TabIndex = 0;
            this.rtbcommand.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Custom";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "<args>";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Select Binary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 20);
            this.button3.TabIndex = 0;
            this.button3.Text = "Run Binary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 316);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Distress Handler (ADB Interface)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox txtcommand;
        private System.Windows.Forms.RichTextBox rtbcommand;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

