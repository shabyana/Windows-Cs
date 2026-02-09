namespace лр4_упр_5
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "Границы интервала";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(28, 107);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 3;
            button1.Text = "Передать данные";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(148, 107);
            button2.Name = "button2";
            button2.Size = new Size(126, 23);
            button2.TabIndex = 4;
            button2.Text = "Отменить передачу";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(28, 66);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(114, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(154, 66);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 166);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "FormRange";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}