namespace CovidMangementApp.UI
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
            infoValue = new RJCodeAdvance.RJControls.RJTextBox();
            rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            rjTextBox2 = new RJCodeAdvance.RJControls.RJTextBox();
            SuspendLayout();
            // 
            // infoValue
            // 
            infoValue.BackColor = SystemColors.Window;
            infoValue.BorderColor = Color.RoyalBlue;
            infoValue.BorderFocusColor = Color.HotPink;
            infoValue.BorderRadius = 0;
            infoValue.BorderSize = 2;
            infoValue.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            infoValue.ForeColor = Color.FromArgb(64, 64, 64);
            infoValue.Location = new Point(211, 100);
            infoValue.Margin = new Padding(4);
            infoValue.Multiline = false;
            infoValue.Name = "infoValue";
            infoValue.Padding = new Padding(10, 7, 10, 7);
            infoValue.PasswordChar = false;
            infoValue.PlaceholderColor = Color.DarkGray;
            infoValue.PlaceholderText = "";
            infoValue.Size = new Size(215, 43);
            infoValue.TabIndex = 4;
            infoValue.Texts = "test2";
            infoValue.UnderlinedStyle = true;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.RoyalBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(211, 49);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Holder1";
            rjTextBox1.Size = new Size(215, 43);
            rjTextBox1.TabIndex = 5;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = true;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(385, 292);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(312, 35);
            rjTextBox2.TabIndex = 6;
            rjTextBox2.Texts = "texs";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rjTextBox2);
            Controls.Add(rjTextBox1);
            Controls.Add(infoValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox infoValue;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox2;
    }
}