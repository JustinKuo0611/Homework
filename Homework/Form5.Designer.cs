
namespace Homework
{
    partial class Form5
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
            this.money_txt = new System.Windows.Forms.TextBox();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.rate_txt = new System.Windows.Forms.TextBox();
            this.downpay_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // money_txt
            // 
            this.money_txt.Font = new System.Drawing.Font("新細明體", 20F);
            this.money_txt.Location = new System.Drawing.Point(240, 31);
            this.money_txt.Name = "money_txt";
            this.money_txt.Size = new System.Drawing.Size(262, 39);
            this.money_txt.TabIndex = 0;
            // 
            // year_txt
            // 
            this.year_txt.Font = new System.Drawing.Font("新細明體", 20F);
            this.year_txt.Location = new System.Drawing.Point(240, 95);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(262, 39);
            this.year_txt.TabIndex = 1;
            // 
            // rate_txt
            // 
            this.rate_txt.Font = new System.Drawing.Font("新細明體", 20F);
            this.rate_txt.Location = new System.Drawing.Point(240, 160);
            this.rate_txt.Name = "rate_txt";
            this.rate_txt.Size = new System.Drawing.Size(262, 39);
            this.rate_txt.TabIndex = 2;
            // 
            // downpay_txt
            // 
            this.downpay_txt.Font = new System.Drawing.Font("新細明體", 20F);
            this.downpay_txt.Location = new System.Drawing.Point(240, 220);
            this.downpay_txt.Name = "downpay_txt";
            this.downpay_txt.Size = new System.Drawing.Size(262, 39);
            this.downpay_txt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 20F);
            this.button1.Location = new System.Drawing.Point(67, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "月付 PMT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 20F);
            this.button2.Location = new System.Drawing.Point(292, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "總付款";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 20F);
            this.button3.Location = new System.Drawing.Point(528, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "貨款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "期限 (年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(66, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(66, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "頭期款";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downpay_txt);
            this.Controls.Add(this.rate_txt);
            this.Controls.Add(this.year_txt);
            this.Controls.Add(this.money_txt);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox money_txt;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.TextBox rate_txt;
        private System.Windows.Forms.TextBox downpay_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}