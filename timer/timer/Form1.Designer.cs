namespace timer
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
            components = new System.ComponentModel.Container();
            btnSetAlarm = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            saat = new System.Windows.Forms.ComboBox();
            saniye = new System.Windows.Forms.ComboBox();
            dakika = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dateandtime = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSetAlarm
            // 
            btnSetAlarm.Location = new System.Drawing.Point(452, 144);
            btnSetAlarm.Name = "btnSetAlarm";
            btnSetAlarm.Size = new System.Drawing.Size(84, 42);
            btnSetAlarm.TabIndex = 0;
            btnSetAlarm.Text = "Başla";
            btnSetAlarm.UseVisualStyleBackColor = true;
            btnSetAlarm.Click += btnSetAlarm_Click_1;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(601, 144);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(84, 42);
            button4.TabIndex = 3;
            button4.Text = "Kapat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // saat
            // 
            saat.FormattingEnabled = true;
            saat.Location = new System.Drawing.Point(382, 91);
            saat.Name = "saat";
            saat.Size = new System.Drawing.Size(84, 28);
            saat.TabIndex = 4;
            // 
            // saniye
            // 
            saniye.FormattingEnabled = true;
            saniye.Location = new System.Drawing.Point(652, 91);
            saniye.Name = "saniye";
            saniye.Size = new System.Drawing.Size(84, 28);
            saniye.TabIndex = 5;
            // 
            // dakika
            // 
            dakika.FormattingEnabled = true;
            dakika.Location = new System.Drawing.Point(517, 91);
            dakika.Name = "dakika";
            dakika.Size = new System.Drawing.Size(84, 28);
            dakika.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(382, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "SAAT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(517, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 20);
            label2.TabIndex = 8;
            label2.Text = "DAKİKA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(652, 56);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 20);
            label3.TabIndex = 9;
            label3.Text = "SANİYE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(510, 215);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 38);
            label4.TabIndex = 10;
            label4.Text = "00:00:00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Crimson;
            label5.Location = new System.Drawing.Point(382, 275);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(337, 57);
            label5.TabIndex = 11;
            label5.Text = "ALARM ÇALIYOR";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new System.Drawing.Point(21, 317);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(276, 121);
            panel1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(17, 65);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(71, 30);
            label7.TabIndex = 15;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(17, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 30);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // dateandtime
            // 
            dateandtime.AutoSize = true;
            dateandtime.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateandtime.Location = new System.Drawing.Point(21, 241);
            dateandtime.Name = "dateandtime";
            dateandtime.Size = new System.Drawing.Size(259, 57);
            dateandtime.TabIndex = 13;
            dateandtime.Text = "Tarih Ve Saat";
            dateandtime.Click += dateandtime_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(21, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 29);
            button1.TabIndex = 14;
            button1.Text = "Zamanlayıcı";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(132, 12);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 29);
            button2.TabIndex = 15;
            button2.Text = "Kronometre";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(243, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "Alarm";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateandtime);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dakika);
            Controls.Add(saniye);
            Controls.Add(saat);
            Controls.Add(button4);
            Controls.Add(btnSetAlarm);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox saat;
        private System.Windows.Forms.ComboBox saniye;
        private System.Windows.Forms.ComboBox dakika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dateandtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
