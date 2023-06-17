namespace ConsoleApplication2udp
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
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.listBox_received = new System.Windows.Forms.ListBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(247, 159);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(190, 28);
            this.textBox_message.TabIndex = 0;
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.LightGray;
            this.button_send.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_send.Location = new System.Drawing.Point(302, 230);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(109, 25);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "button1";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // listBox_received
            // 
            this.listBox_received.FormattingEnabled = true;
            this.listBox_received.ItemHeight = 16;
            this.listBox_received.Location = new System.Drawing.Point(154, 310);
            this.listBox_received.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_received.Name = "listBox_received";
            this.listBox_received.Size = new System.Drawing.Size(679, 196);
            this.listBox_received.TabIndex = 2;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(121, 39);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(255, 22);
            this.textBox_ip.TabIndex = 6;
            this.textBox_ip.Text = "192.168.0.177";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(440, 39);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(255, 22);
            this.textBox_port.TabIndex = 8;
            this.textBox_port.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(404, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.listBox_received);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_message);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "UDP Client (Host must running first)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ListBox listBox_received;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

