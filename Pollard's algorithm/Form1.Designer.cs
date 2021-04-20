
namespace Pollard_s_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.e_textBox = new System.Windows.Forms.TextBox();
            this.p_textBox = new System.Windows.Forms.TextBox();
            this.crypto_textBox = new System.Windows.Forms.TextBox();
            this.d_textBox = new System.Windows.Forms.TextBox();
            this.q_textBox = new System.Windows.Forms.TextBox();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.hack_button = new System.Windows.Forms.Button();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.iterations_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // e_textBox
            // 
            this.e_textBox.Location = new System.Drawing.Point(56, 25);
            this.e_textBox.Name = "e_textBox";
            this.e_textBox.Size = new System.Drawing.Size(551, 22);
            this.e_textBox.TabIndex = 0;
            // 
            // p_textBox
            // 
            this.p_textBox.Location = new System.Drawing.Point(56, 80);
            this.p_textBox.Name = "p_textBox";
            this.p_textBox.ReadOnly = true;
            this.p_textBox.Size = new System.Drawing.Size(551, 22);
            this.p_textBox.TabIndex = 1;
            // 
            // crypto_textBox
            // 
            this.crypto_textBox.Location = new System.Drawing.Point(56, 220);
            this.crypto_textBox.Multiline = true;
            this.crypto_textBox.Name = "crypto_textBox";
            this.crypto_textBox.Size = new System.Drawing.Size(1216, 273);
            this.crypto_textBox.TabIndex = 2;
            // 
            // d_textBox
            // 
            this.d_textBox.Location = new System.Drawing.Point(394, 160);
            this.d_textBox.Name = "d_textBox";
            this.d_textBox.ReadOnly = true;
            this.d_textBox.Size = new System.Drawing.Size(551, 22);
            this.d_textBox.TabIndex = 6;
            // 
            // q_textBox
            // 
            this.q_textBox.Location = new System.Drawing.Point(721, 80);
            this.q_textBox.Name = "q_textBox";
            this.q_textBox.ReadOnly = true;
            this.q_textBox.Size = new System.Drawing.Size(551, 22);
            this.q_textBox.TabIndex = 5;
            // 
            // n_textBox
            // 
            this.n_textBox.Location = new System.Drawing.Point(721, 25);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(551, 22);
            this.n_textBox.TabIndex = 4;
            // 
            // hack_button
            // 
            this.hack_button.Location = new System.Drawing.Point(636, 508);
            this.hack_button.Name = "hack_button";
            this.hack_button.Size = new System.Drawing.Size(68, 34);
            this.hack_button.TabIndex = 8;
            this.hack_button.Text = "hack";
            this.hack_button.UseVisualStyleBackColor = true;
            this.hack_button.Click += new System.EventHandler(this.hack_button_Click);
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(56, 565);
            this.result_textBox.Multiline = true;
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(1216, 181);
            this.result_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "E";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1300, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "D";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(1299, 80);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(19, 17);
            this.label.TabIndex = 14;
            this.label.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Crypto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Result";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(1089, 749);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(43, 17);
            this.time_label.TabIndex = 18;
            this.time_label.Text = "Time:";
            // 
            // iterations_label
            // 
            this.iterations_label.AutoSize = true;
            this.iterations_label.Location = new System.Drawing.Point(53, 751);
            this.iterations_label.Name = "iterations_label";
            this.iterations_label.Size = new System.Drawing.Size(70, 17);
            this.iterations_label.TabIndex = 19;
            this.iterations_label.Text = "Iterations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 777);
            this.Controls.Add(this.iterations_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.hack_button);
            this.Controls.Add(this.d_textBox);
            this.Controls.Add(this.q_textBox);
            this.Controls.Add(this.n_textBox);
            this.Controls.Add(this.crypto_textBox);
            this.Controls.Add(this.p_textBox);
            this.Controls.Add(this.e_textBox);
            this.Name = "Form1";
            this.Text = "Pollard\'s algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox e_textBox;
        private System.Windows.Forms.TextBox p_textBox;
        private System.Windows.Forms.TextBox crypto_textBox;
        private System.Windows.Forms.TextBox d_textBox;
        private System.Windows.Forms.TextBox q_textBox;
        private System.Windows.Forms.TextBox n_textBox;
        private System.Windows.Forms.Button hack_button;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label iterations_label;
    }
}

