namespace OrganiserApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ModulesGrpBox = new System.Windows.Forms.GroupBox();
            this.module5 = new System.Windows.Forms.Button();
            this.module4 = new System.Windows.Forms.Button();
            this.module3 = new System.Windows.Forms.Button();
            this.module2 = new System.Windows.Forms.Button();
            this.module1 = new System.Windows.Forms.Button();
            this.module0 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.ModulesGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModulesGrpBox
            // 
            this.ModulesGrpBox.Controls.Add(this.module5);
            this.ModulesGrpBox.Controls.Add(this.module4);
            this.ModulesGrpBox.Controls.Add(this.module3);
            this.ModulesGrpBox.Controls.Add(this.module2);
            this.ModulesGrpBox.Controls.Add(this.module1);
            this.ModulesGrpBox.Controls.Add(this.module0);
            this.ModulesGrpBox.Location = new System.Drawing.Point(12, 12);
            this.ModulesGrpBox.Name = "ModulesGrpBox";
            this.ModulesGrpBox.Size = new System.Drawing.Size(936, 548);
            this.ModulesGrpBox.TabIndex = 0;
            this.ModulesGrpBox.TabStop = false;
            this.ModulesGrpBox.Text = "Modules";
            // 
            // module5
            // 
            this.module5.Location = new System.Drawing.Point(628, 284);
            this.module5.Name = "module5";
            this.module5.Size = new System.Drawing.Size(300, 250);
            this.module5.TabIndex = 0;
            this.module5.Text = "button7";
            this.module5.UseVisualStyleBackColor = true;
            this.module5.Click += new System.EventHandler(this.module5_Click);
            // 
            // module4
            // 
            this.module4.Location = new System.Drawing.Point(628, 28);
            this.module4.Name = "module4";
            this.module4.Size = new System.Drawing.Size(300, 250);
            this.module4.TabIndex = 0;
            this.module4.Text = "button6";
            this.module4.UseVisualStyleBackColor = true;
            this.module4.Click += new System.EventHandler(this.module4_Click);
            // 
            // module3
            // 
            this.module3.Location = new System.Drawing.Point(322, 284);
            this.module3.Name = "module3";
            this.module3.Size = new System.Drawing.Size(300, 250);
            this.module3.TabIndex = 0;
            this.module3.Text = "button5";
            this.module3.UseVisualStyleBackColor = true;
            this.module3.Click += new System.EventHandler(this.module3_Click);
            // 
            // module2
            // 
            this.module2.Location = new System.Drawing.Point(322, 28);
            this.module2.Name = "module2";
            this.module2.Size = new System.Drawing.Size(300, 250);
            this.module2.TabIndex = 0;
            this.module2.Text = "button4";
            this.module2.UseVisualStyleBackColor = true;
            this.module2.Click += new System.EventHandler(this.module2_Click);
            // 
            // module1
            // 
            this.module1.Location = new System.Drawing.Point(16, 284);
            this.module1.Name = "module1";
            this.module1.Size = new System.Drawing.Size(300, 250);
            this.module1.TabIndex = 0;
            this.module1.Text = "button3";
            this.module1.UseVisualStyleBackColor = true;
            this.module1.Click += new System.EventHandler(this.module1_Click);
            // 
            // module0
            // 
            this.module0.Location = new System.Drawing.Point(16, 28);
            this.module0.Name = "module0";
            this.module0.Size = new System.Drawing.Size(300, 250);
            this.module0.TabIndex = 0;
            this.module0.Text = "button1";
            this.module0.UseVisualStyleBackColor = true;
            this.module0.Click += new System.EventHandler(this.module0_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(848, 566);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 38);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 616);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.ModulesGrpBox);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Organiser App";
            this.ModulesGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ModulesGrpBox;
        private System.Windows.Forms.Button module5;
        private System.Windows.Forms.Button module4;
        private System.Windows.Forms.Button module3;
        private System.Windows.Forms.Button module2;
        private System.Windows.Forms.Button module1;
        private System.Windows.Forms.Button module0;
        private System.Windows.Forms.Button exitBtn;
    }
}

