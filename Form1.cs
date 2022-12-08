namespace Test
{
    public partial class WastingTime : Form
    {
        public WastingTime()
        {
            InitializeComponent();
        }

        double a = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)a;
            label1.Text = string.Format("{0}%", (int)a);
            if (a < 100)
            {
                a += 0.01;
            }
            else
            {
                MessageBox.Show("축하합니다! 당신은 시간을 낭비했습니다!", "감사합니다", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}