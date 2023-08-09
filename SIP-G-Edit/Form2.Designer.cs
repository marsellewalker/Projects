namespace SIP_G_Edit
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.open_file = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_B = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.RichTextBox();
            this.safty_B = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.find = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(39, 1);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(75, 23);
            this.open_file.TabIndex = 1;
            this.open_file.Text = "Open File";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(827, 2);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(120, 22);
            this.TB1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Replace";
            // 
            // delete_B
            // 
            this.delete_B.Location = new System.Drawing.Point(120, 1);
            this.delete_B.Name = "delete_B";
            this.delete_B.Size = new System.Drawing.Size(75, 23);
            this.delete_B.TabIndex = 13;
            this.delete_B.Text = "Delete";
            this.delete_B.UseVisualStyleBackColor = true;
            this.delete_B.Click += new System.EventHandler(this.button4_Click);
            // 
            // open
            // 
            this.open.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.open.Location = new System.Drawing.Point(39, 58);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(1100, 366);
            this.open.TabIndex = 15;
            this.open.Text = "";
            // 
            // safty_B
            // 
            this.safty_B.AutoSize = true;
            this.safty_B.Location = new System.Drawing.Point(474, 3);
            this.safty_B.Name = "safty_B";
            this.safty_B.Size = new System.Drawing.Size(95, 20);
            this.safty_B.TabIndex = 16;
            this.safty_B.TabStop = true;
            this.safty_B.Text = "Safty Block";
            this.safty_B.UseVisualStyleBackColor = true;
            this.safty_B.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(983, 1);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 18;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(1064, 1);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(75, 23);
            this.replace.TabIndex = 19;
            this.replace.Text = "Replace";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(636, 2);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(120, 22);
            this.TB2.TabIndex = 20;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(319, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 20);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sub Program End";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Find";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.find);
            this.Controls.Add(this.safty_B);
            this.Controls.Add(this.open);
            this.Controls.Add(this.delete_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_B;
        private System.Windows.Forms.RichTextBox open;
        private System.Windows.Forms.RadioButton safty_B;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}