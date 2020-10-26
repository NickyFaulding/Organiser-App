namespace OrganiserApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.rmvTskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(14, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(413, 268);
            this.checkedListBox1.TabIndex = 1;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(14, 327);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(217, 60);
            this.addTaskBtn.TabIndex = 2;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // rmvTskBtn
            // 
            this.rmvTskBtn.Location = new System.Drawing.Point(237, 327);
            this.rmvTskBtn.Name = "rmvTskBtn";
            this.rmvTskBtn.Size = new System.Drawing.Size(190, 60);
            this.rmvTskBtn.TabIndex = 3;
            this.rmvTskBtn.Text = "Remove Checked Tasks";
            this.rmvTskBtn.UseVisualStyleBackColor = true;
            this.rmvTskBtn.Click += new System.EventHandler(this.rmvTskBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 399);
            this.Controls.Add(this.rmvTskBtn);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Button rmvTskBtn;
    }
}