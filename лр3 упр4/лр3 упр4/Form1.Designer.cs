namespace лр3_упр4
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
            validationControl1 = new ValidationControl();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // validationControl1
            // 
            validationControl1.Location = new Point(12, 13);
            validationControl1.Margin = new Padding(3, 4, 3, 4);
            validationControl1.Name = "validationControl1";
            validationControl1.Size = new Size(358, 334);
            validationControl1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(376, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(300, 322);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 363);
            Controls.Add(richTextBox1);
            Controls.Add(validationControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Пользователь";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ValidationControl validationControl1;
        private RichTextBox richTextBox1;
    }
}
