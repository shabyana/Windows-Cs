namespace л1_упр5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();

            myPath.AddPolygon(new Point[] { new Point(25, 225),
                              new Point(175, 25),
                              new Point(325, 225),
                              new Point(175, 425)});

            Region myRegion = new Region(myPath);

            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
