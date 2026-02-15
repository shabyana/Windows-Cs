namespace Calculator
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
            KeySign = new Button();
            KeyZero = new Button();
            KeyPoint = new Button();
            KeyEqual = new Button();
            KeyOne = new Button();
            KeyTwo = new Button();
            KeyThree = new Button();
            KeyPlus = new Button();
            KeyFour = new Button();
            KeyFive = new Button();
            KeySix = new Button();
            KeyMinus = new Button();
            KeySeven = new Button();
            KeyEight = new Button();
            KeyNine = new Button();
            KeyMultiply = new Button();
            label1 = new Label();
            OutputDisplay = new TextBox();
            menuStrip1 = new MenuStrip();
            калькуляторToolStripMenuItem = new ToolStripMenuItem();
            обычныйToolStripMenuItem = new ToolStripMenuItem();
            инженерныйToolStripMenuItem = new ToolStripMenuItem();
            KeyDivide = new Button();
            KeyClear = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // KeySign
            // 
            KeySign.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeySign.Location = new Point(5, 336);
            KeySign.Name = "KeySign";
            KeySign.Size = new Size(84, 46);
            KeySign.TabIndex = 1;
            KeySign.Text = "+/-";
            KeySign.UseVisualStyleBackColor = true;
            KeySign.Click += KeySign_Click;
            // 
            // KeyZero
            // 
            KeyZero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyZero.Location = new Point(95, 336);
            KeyZero.Name = "KeyZero";
            KeyZero.Size = new Size(84, 46);
            KeyZero.TabIndex = 2;
            KeyZero.Text = "0";
            KeyZero.UseVisualStyleBackColor = true;
            KeyZero.Click += KeyZero_Click;
            // 
            // KeyPoint
            // 
            KeyPoint.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyPoint.Location = new Point(185, 336);
            KeyPoint.Name = "KeyPoint";
            KeyPoint.Size = new Size(84, 46);
            KeyPoint.TabIndex = 3;
            KeyPoint.Text = ",";
            KeyPoint.UseVisualStyleBackColor = true;
            KeyPoint.Click += KeyPoint_Click;
            // 
            // KeyEqual
            // 
            KeyEqual.BackColor = SystemColors.HotTrack;
            KeyEqual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyEqual.ForeColor = SystemColors.Window;
            KeyEqual.Location = new Point(275, 336);
            KeyEqual.Name = "KeyEqual";
            KeyEqual.Size = new Size(84, 46);
            KeyEqual.TabIndex = 4;
            KeyEqual.Text = "=";
            KeyEqual.UseVisualStyleBackColor = false;
            KeyEqual.Click += KeyEqual_Click;
            // 
            // KeyOne
            // 
            KeyOne.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyOne.Location = new Point(5, 284);
            KeyOne.Name = "KeyOne";
            KeyOne.Size = new Size(84, 46);
            KeyOne.TabIndex = 5;
            KeyOne.Text = "1";
            KeyOne.UseVisualStyleBackColor = true;
            KeyOne.Click += KeyOne_Click;
            // 
            // KeyTwo
            // 
            KeyTwo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyTwo.Location = new Point(95, 284);
            KeyTwo.Name = "KeyTwo";
            KeyTwo.Size = new Size(84, 46);
            KeyTwo.TabIndex = 6;
            KeyTwo.Text = "2";
            KeyTwo.UseVisualStyleBackColor = true;
            KeyTwo.Click += KeyTwo_Click;
            // 
            // KeyThree
            // 
            KeyThree.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyThree.Location = new Point(185, 284);
            KeyThree.Name = "KeyThree";
            KeyThree.Size = new Size(84, 46);
            KeyThree.TabIndex = 7;
            KeyThree.Text = "3";
            KeyThree.UseVisualStyleBackColor = true;
            KeyThree.Click += KeyThree_Click;
            // 
            // KeyPlus
            // 
            KeyPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyPlus.Location = new Point(275, 284);
            KeyPlus.Name = "KeyPlus";
            KeyPlus.Size = new Size(84, 46);
            KeyPlus.TabIndex = 8;
            KeyPlus.Text = "+";
            KeyPlus.UseVisualStyleBackColor = true;
            KeyPlus.Click += KeyPlus_Click;
            // 
            // KeyFour
            // 
            KeyFour.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyFour.Location = new Point(5, 232);
            KeyFour.Name = "KeyFour";
            KeyFour.Size = new Size(84, 46);
            KeyFour.TabIndex = 9;
            KeyFour.Text = "4";
            KeyFour.UseVisualStyleBackColor = true;
            KeyFour.Click += KeyFour_Click;
            // 
            // KeyFive
            // 
            KeyFive.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyFive.Location = new Point(95, 232);
            KeyFive.Name = "KeyFive";
            KeyFive.Size = new Size(84, 46);
            KeyFive.TabIndex = 10;
            KeyFive.Text = "5";
            KeyFive.UseVisualStyleBackColor = true;
            KeyFive.Click += KeyFive_Click;
            // 
            // KeySix
            // 
            KeySix.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeySix.Location = new Point(185, 232);
            KeySix.Name = "KeySix";
            KeySix.Size = new Size(84, 46);
            KeySix.TabIndex = 11;
            KeySix.Text = "6";
            KeySix.UseVisualStyleBackColor = true;
            KeySix.Click += KeySix_Click;
            // 
            // KeyMinus
            // 
            KeyMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyMinus.Location = new Point(275, 232);
            KeyMinus.Name = "KeyMinus";
            KeyMinus.Size = new Size(84, 46);
            KeyMinus.TabIndex = 12;
            KeyMinus.Text = "-";
            KeyMinus.UseVisualStyleBackColor = true;
            KeyMinus.Click += KeyMinus_Click;
            // 
            // KeySeven
            // 
            KeySeven.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeySeven.Location = new Point(5, 180);
            KeySeven.Name = "KeySeven";
            KeySeven.Size = new Size(84, 46);
            KeySeven.TabIndex = 13;
            KeySeven.Text = "7";
            KeySeven.UseVisualStyleBackColor = true;
            KeySeven.Click += KeySeven_Click;
            // 
            // KeyEight
            // 
            KeyEight.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyEight.Location = new Point(95, 180);
            KeyEight.Name = "KeyEight";
            KeyEight.Size = new Size(84, 46);
            KeyEight.TabIndex = 14;
            KeyEight.Text = "8";
            KeyEight.UseVisualStyleBackColor = true;
            KeyEight.Click += KeyEight_Click;
            // 
            // KeyNine
            // 
            KeyNine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyNine.Location = new Point(185, 180);
            KeyNine.Name = "KeyNine";
            KeyNine.Size = new Size(84, 46);
            KeyNine.TabIndex = 15;
            KeyNine.Text = "9";
            KeyNine.UseVisualStyleBackColor = true;
            KeyNine.Click += KeyNine_Click;
            // 
            // KeyMultiply
            // 
            KeyMultiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyMultiply.Location = new Point(275, 180);
            KeyMultiply.Name = "KeyMultiply";
            KeyMultiply.Size = new Size(84, 46);
            KeyMultiply.TabIndex = 16;
            KeyMultiply.Text = "×";
            KeyMultiply.UseVisualStyleBackColor = true;
            KeyMultiply.Click += KeyMultiply_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(123, 24);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 17;
            label1.Text = "Обычный калькулятор";
            // 
            // OutputDisplay
            // 
            OutputDisplay.BackColor = SystemColors.ActiveCaption;
            OutputDisplay.BorderStyle = BorderStyle.FixedSingle;
            OutputDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OutputDisplay.Location = new Point(6, 57);
            OutputDisplay.Multiline = true;
            OutputDisplay.Name = "OutputDisplay";
            OutputDisplay.ReadOnly = true;
            OutputDisplay.RightToLeft = RightToLeft.Yes;
            OutputDisplay.Size = new Size(354, 62);
            OutputDisplay.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { калькуляторToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(366, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // калькуляторToolStripMenuItem
            // 
            калькуляторToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { обычныйToolStripMenuItem, инженерныйToolStripMenuItem });
            калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            калькуляторToolStripMenuItem.Size = new Size(89, 20);
            калькуляторToolStripMenuItem.Text = "Калькулятор";
            // 
            // обычныйToolStripMenuItem
            // 
            обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            обычныйToolStripMenuItem.Size = new Size(148, 22);
            обычныйToolStripMenuItem.Text = "Обычный";
            // 
            // инженерныйToolStripMenuItem
            // 
            инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            инженерныйToolStripMenuItem.Size = new Size(180, 22);
            инженерныйToolStripMenuItem.Text = "Инженерный";
            инженерныйToolStripMenuItem.Click += инженерныйToolStripMenuItem_Click;
            // 
            // KeyDivide
            // 
            KeyDivide.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyDivide.Location = new Point(275, 128);
            KeyDivide.Name = "KeyDivide";
            KeyDivide.Size = new Size(84, 46);
            KeyDivide.TabIndex = 20;
            KeyDivide.Text = "÷";
            KeyDivide.UseVisualStyleBackColor = true;
            KeyDivide.Click += KeyDivide_Click;
            // 
            // KeyClear
            // 
            KeyClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeyClear.Location = new Point(185, 128);
            KeyClear.Name = "KeyClear";
            KeyClear.Size = new Size(84, 46);
            KeyClear.TabIndex = 21;
            KeyClear.Text = "C";
            KeyClear.UseVisualStyleBackColor = true;
            KeyClear.Click += KeyClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(366, 389);
            Controls.Add(KeyClear);
            Controls.Add(KeyDivide);
            Controls.Add(OutputDisplay);
            Controls.Add(label1);
            Controls.Add(KeyMultiply);
            Controls.Add(KeyNine);
            Controls.Add(KeyEight);
            Controls.Add(KeySeven);
            Controls.Add(KeyMinus);
            Controls.Add(KeySix);
            Controls.Add(KeyFive);
            Controls.Add(KeyFour);
            Controls.Add(KeyPlus);
            Controls.Add(KeyThree);
            Controls.Add(KeyTwo);
            Controls.Add(KeyOne);
            Controls.Add(KeyEqual);
            Controls.Add(KeyPoint);
            Controls.Add(KeyZero);
            Controls.Add(KeySign);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button KeySign;
        private Button KeyZero;
        private Button KeyPoint;
        private Button KeyEqual;
        private Button KeyOne;
        private Button KeyTwo;
        private Button KeyThree;
        private Button KeyPlus;
        private Button KeyFour;
        private Button KeyFive;
        private Button KeySix;
        private Button KeyMinus;
        private Button KeySeven;
        private Button KeyEight;
        private Button KeyNine;
        private Button KeyMultiply;
        private Label label1;
        private TextBox OutputDisplay;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem калькуляторToolStripMenuItem;
        private ToolStripMenuItem обычныйToolStripMenuItem;
        private ToolStripMenuItem инженерныйToolStripMenuItem;
        private Button KeyDivide;
        private Button KeyClear;
    }
}
