namespace Lab2BD1
{
    partial class Filtration_Drivers
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
            this.label5 = new System.Windows.Forms.Label();
            this.filter_fn1 = new System.Windows.Forms.TextBox();
            this.filter_st1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Range FROM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // filter_fn1
            // 
            this.filter_fn1.Location = new System.Drawing.Point(226, 145);
            this.filter_fn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filter_fn1.Name = "filter_fn1";
            this.filter_fn1.Size = new System.Drawing.Size(173, 26);
            this.filter_fn1.TabIndex = 20;
            // 
            // filter_st1
            // 
            this.filter_st1.Location = new System.Drawing.Point(42, 145);
            this.filter_st1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filter_st1.Name = "filter_st1";
            this.filter_st1.Size = new System.Drawing.Size(161, 26);
            this.filter_st1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "TO";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(333, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(42, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 25;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Filtration_Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filter_fn1);
            this.Controls.Add(this.filter_st1);
            this.Controls.Add(this.label4);
            this.Name = "Filtration_Drivers";
            this.Text = "Filtration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filter_fn1;
        private System.Windows.Forms.TextBox filter_st1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}