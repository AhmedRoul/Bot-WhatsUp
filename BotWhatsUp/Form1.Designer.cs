namespace BotWhatsUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Message_design = new System.Windows.Forms.TextBox();
            this.Choose_design = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_design = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // Message_design
            // 
            this.Message_design.Location = new System.Drawing.Point(348, 56);
            this.Message_design.Name = "Message_design";
            this.Message_design.Size = new System.Drawing.Size(100, 20);
            this.Message_design.TabIndex = 1;
            // 
            // Choose_design
            // 
            this.Choose_design.FormattingEnabled = true;
            this.Choose_design.Location = new System.Drawing.Point(348, 132);
            this.Choose_design.Name = "Choose_design";
            this.Choose_design.Size = new System.Drawing.Size(121, 21);
            this.Choose_design.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "choose";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name_design
            // 
            this.Name_design.Location = new System.Drawing.Point(348, 225);
            this.Name_design.Name = "Name_design";
            this.Name_design.Size = new System.Drawing.Size(100, 20);
            this.Name_design.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name or #phone";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(311, 313);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "button1";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_design);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Choose_design);
            this.Controls.Add(this.Message_design);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message_design;
        private System.Windows.Forms.ComboBox Choose_design;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_design;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
    }
}