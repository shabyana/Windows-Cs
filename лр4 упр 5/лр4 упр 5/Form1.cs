using System;
using System.Drawing;
using System.Text;
using System.Text.Json.Nodes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace лр4_упр_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            Form2 newForm = new Form2();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                double first = newForm.FirstnNum;
                double second = newForm.SecondNum;
                double step = 0.1;
                for (double x = first; x <= second; x += step)
                {
                    double sinValue = Math.Sin(x);
                    sb.Append($"sin({x}) = {sinValue}\n");
                }
                IntervalLabel(first, second);
                richTextBox1.Text = sb.ToString();
            }
                
        }
        
        private void IntervalLabel(double first, double second)
        {
            label2.Text = $"Левая граница: {first}, правая граница {second}";
        }
    }
}
