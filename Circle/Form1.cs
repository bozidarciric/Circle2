namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox1.Text);
            double perimeter = 2 * r * Math.PI;
            double area = Math.Pow(r, 2) * Math.PI;
            label3.Text = perimeter.ToString();
            label5.Text = area.ToString();
        }
    }
}