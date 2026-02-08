namespace лр3_упр4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            validationControl1.OnValidationSuccess += ValidationFormControl_OnValidationSuccess;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ValidationFormControl_OnValidationSuccess(User user)
        {
            richTextBox1.Text = user.ToString();
        }
    }
}
