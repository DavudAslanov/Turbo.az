namespace Turbo.az
{
    partial class Login
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
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(129, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 371);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(156, 101);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 4;
            label3.Text = "Nömrəniz Yalnışdır";
            label3.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(84, 224);
            button1.Name = "button1";
            button1.Size = new Size(352, 55);
            button1.TabIndex = 3;
            button1.Text = "Giris";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(147, 54);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 2;
            label2.Text = "Nömrənizi Daxil Edin";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            maskedTextBox1.Location = new Point(84, 155);
            maskedTextBox1.Mask = "(000) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(352, 43);
            maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(195, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Giris Etmek";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 555);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Button button1;
        private Label label3;
    }
}