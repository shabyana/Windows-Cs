using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            OutputDisplay.Text = "0";
            toolTip1.SetToolTip(this.KeyPow, "Возведение в степень");
            toolTip2.SetToolTip(this.KeySquareRoot, "Извлечение квадратного корня");
            toolTip3.SetToolTip(this.KeyReverse, "Расчет обратного значения");
            toolTip4.SetToolTip(this.KeySquared, "Определение квадрата числа");
            toolTip5.SetToolTip(this.KeyFactorial, "Расчет факториала числа");
            toolTip6.SetToolTip(this.KeyCubedRoot, "Извлечение кубического корня");
            toolTip7.SetToolTip(this.KeyEquation, "Решение квадратного уравнения");
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void KeyEquation_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            if (F3.ShowDialog() == DialogResult.OK)
            {
                double a = F3.FirstCo;
                double b = F3.SecondCo;
                double c = F3.ThirdCo;

                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    OutputDisplay.Text = $"Корни уравнения: {root1}, {root2}";
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    OutputDisplay.Text = $"Единственный корень: {root}";
                }
                else
                {
                    OutputDisplay.Text = "Действительные корни отсутствуют";
                }
            }
        }
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";


        private void KeyPow_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
        }

        private void KeySquareRoot_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSquareRoot);
        }
        private void KeyReverse_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eReverse);
        }
        private void KeySquared_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSquare);
        }
        private void KeyFactorial_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
        }
        private void KeyCubedRoot_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eCubedRoot);
        }


        private void KeyPlus_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        private void KeyMinus_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        private void KeyMultiply_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        private void KeyDivide_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        private void KeySign_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        private void KeyPoint_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        private void KeyClear_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        private void KeyEqual_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void KeyNine_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        private void KeyEight_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        private void KeySeven_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        private void KeySix_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        private void KeyFive_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        private void KeyFour_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        private void KeyThree_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        private void KeyTwo_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        private void KeyOne_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        private void KeyZero_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
