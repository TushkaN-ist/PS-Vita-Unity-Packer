namespace PS_Vita_Unity_Packer
{
    partial class Form_Packer
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
            if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Packer));
			this.InputBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Btn_Select = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.BTN_Pack = new System.Windows.Forms.Button();
			this.LogBox = new System.Windows.Forms.TextBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputBox
			// 
			this.InputBox.AcceptsReturn = true;
			this.InputBox.AllowDrop = true;
			this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InputBox.Location = new System.Drawing.Point(73, 12);
			this.InputBox.Name = "InputBox";
			this.InputBox.Size = new System.Drawing.Size(401, 20);
			this.InputBox.TabIndex = 0;
			this.InputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputBox_DragDrop);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(28, 15);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Папка";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Btn_Select
			// 
			this.Btn_Select.Location = new System.Drawing.Point(480, 10);
			this.Btn_Select.Name = "Btn_Select";
			this.Btn_Select.Size = new System.Drawing.Size(28, 23);
			this.Btn_Select.TabIndex = 3;
			this.Btn_Select.Text = "...";
			this.Btn_Select.UseVisualStyleBackColor = true;
			this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 38);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(235, 17);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Удалить исходную папку после упаковки";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(301, 39);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(207, 17);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "Удалить неиспользованные файлы";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(12, 61);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(152, 17);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "Fix Unsafe Homebrew Bug";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "eboot|eboot.bin;*.self";
			this.openFileDialog1.InitialDirectory = ".";
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(301, 62);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(131, 17);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 7;
			// 
			// BTN_Pack
			// 
			this.BTN_Pack.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.BTN_Pack.Enabled = false;
			this.BTN_Pack.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BTN_Pack.Location = new System.Drawing.Point(438, 62);
			this.BTN_Pack.Name = "BTN_Pack";
			this.BTN_Pack.Size = new System.Drawing.Size(70, 18);
			this.BTN_Pack.TabIndex = 8;
			this.BTN_Pack.Text = "Pack";
			this.BTN_Pack.UseVisualStyleBackColor = true;
			this.BTN_Pack.Click += new System.EventHandler(this.BTN_Pack_Click);
			// 
			// LogBox
			// 
			this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LogBox.Location = new System.Drawing.Point(12, 84);
			this.LogBox.Multiline = true;
			this.LogBox.Name = "LogBox";
			this.LogBox.ReadOnly = true;
			this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.LogBox.Size = new System.Drawing.Size(496, 126);
			this.LogBox.TabIndex = 9;
			this.LogBox.Text = "Log Packer\r\n";
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(170, 61);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(124, 17);
			this.checkBox4.TabIndex = 10;
			this.checkBox4.Text = "Удалить Watermark";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 213);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip1.Size = new System.Drawing.Size(520, 25);
			this.toolStrip1.TabIndex = 11;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.IsLink = true;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
			this.toolStripLabel1.Text = "TushkaN©";
			this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
			// 
			// Form_Packer
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 238);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.LogBox);
			this.Controls.Add(this.BTN_Pack);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Btn_Select);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_Packer";
			this.Text = "GUI psVita Packer 0.3";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_Packer_DragDrop);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button BTN_Pack;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}