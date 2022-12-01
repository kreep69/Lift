using System.Media;

namespace Lift
{
    partial class Lifty

    {

        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        
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
            
            
            
            this.start_button = new System.Windows.Forms.Button();
            this.pausebutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.createbutton = new System.Windows.Forms.Button();
            this.menu_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.PaleGreen;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.Location = new System.Drawing.Point(4, 4);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(100, 28);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Пуск";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pausebutton
            // 
            this.pausebutton.BackColor = System.Drawing.Color.PeachPuff;
            this.pausebutton.FlatAppearance.BorderSize = 0;
            this.pausebutton.Location = new System.Drawing.Point(4, 40);
            this.pausebutton.Margin = new System.Windows.Forms.Padding(4);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(100, 28);
            this.pausebutton.TabIndex = 1;
            this.pausebutton.Text = "Пауза";
            this.pausebutton.UseVisualStyleBackColor = false;
            this.pausebutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.Color.IndianRed;
            this.stopbutton.FlatAppearance.BorderSize = 0;
            this.stopbutton.Location = new System.Drawing.Point(4, 76);
            this.stopbutton.Margin = new System.Windows.Forms.Padding(4);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(100, 28);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "Стоп";
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.start_button);
            this.flowLayoutPanel1.Controls.Add(this.pausebutton);
            this.flowLayoutPanel1.Controls.Add(this.stopbutton);
            this.flowLayoutPanel1.Controls.Add(this.createbutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(672, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 344);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // createbutton
            // 
            this.createbutton.BackColor = System.Drawing.Color.Teal;
            this.createbutton.FlatAppearance.BorderSize = 0;
            this.createbutton.Location = new System.Drawing.Point(4, 112);
            this.createbutton.Margin = new System.Windows.Forms.Padding(4);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(100, 76);
            this.createbutton.TabIndex = 3;
            this.createbutton.Text = "Создать пассажира";
            this.createbutton.UseVisualStyleBackColor = false;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // menu_button
            // 
            this.menu_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menu_button.Location = new System.Drawing.Point(672, 388);
            this.menu_button.MaximumSize = new System.Drawing.Size(250, 100);
            this.menu_button.MinimumSize = new System.Drawing.Size(116, 50);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(116, 50);
            this.menu_button.TabIndex = 3;
            this.menu_button.Text = "В меню";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.panel1.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(100, 960);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.panel2.MinimumSize = new System.Drawing.Size(170, 100);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1700, 1000);
            this.panel2.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.Location = new System.Drawing.Point(620, 280);
            this.panel12.Margin = new System.Windows.Forms.Padding(10);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10);
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Location = new System.Drawing.Point(620, 400);
            this.panel11.Margin = new System.Windows.Forms.Padding(10);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10);
            this.panel11.Size = new System.Drawing.Size(200, 100);
            this.panel11.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Location = new System.Drawing.Point(620, 520);
            this.panel10.Margin = new System.Windows.Forms.Padding(10);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10);
            this.panel10.Size = new System.Drawing.Size(200, 100);
            this.panel10.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Location = new System.Drawing.Point(620, 640);
            this.panel9.Margin = new System.Windows.Forms.Padding(10);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10);
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Location = new System.Drawing.Point(620, 760);
            this.panel8.Margin = new System.Windows.Forms.Padding(10);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Location = new System.Drawing.Point(620, 880);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Location = new System.Drawing.Point(500, 20);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.panel6.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(100, 960);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Location = new System.Drawing.Point(380, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.panel5.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(100, 960);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(260, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(10);
            this.panel4.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.panel4.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(100, 960);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(140, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.MaximumSize = new System.Drawing.Size(1700, 1000);
            this.panel3.MinimumSize = new System.Drawing.Size(100, 100);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(100, 960);
            this.panel3.TabIndex = 5;
            // 
            // Lifty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lifty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lyfty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lifty_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button pausebutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button createbutton;
    }
}

