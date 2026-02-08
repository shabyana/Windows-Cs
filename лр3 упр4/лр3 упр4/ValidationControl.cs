using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace лр3_упр4
{
    public partial class ValidationControl : UserControl
    {
        public event Action<User> OnValidationSuccess;

        public ValidationControl()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }
        
        private bool Validate()
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Имя обязательно!");
                return false;
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Фамилия обязательна!");
                return false;
            }
            if (numAge.Value <= 0 || numAge.Value > 100)
            {
                MessageBox.Show("Возраст должен быть корректным!");
                return false;
            }
            return true;
        }
        

            private void button2_Click(object sender, EventArgs e)
            {
              txtName.Clear();
              txtSurname.Clear();
              numAge.Value = 0;
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Validate())
            {
                User u = new User
                {
                    Name = txtName.Text.Trim(),
                    Surname = txtSurname.Text.Trim(),
                    Age = (int)numAge.Value
                };

                OnValidationSuccess?.Invoke(u);
            }
        }
    }
}
