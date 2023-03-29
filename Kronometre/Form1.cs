namespace Kronometre
{
    public partial class Form1 : Form
    {
        int saniye = 0;
        int salise = 0;
        int dakika = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
            }
            if (dakika < 10)
            {
                label1.Text = "0" + dakika.ToString();
            }
            else
            {
                label1.Text = dakika.ToString();
            }
            if (saniye < 10)
            {
                label1.Text += ":0" + saniye.ToString();
            }
            else
            {
                label1.Text += ":" + saniye.ToString();
            }
            if (salise < 10)
            {
                label1.Text += ":0" + salise.ToString();
            }
            else
            {
                label1.Text += ":" + salise.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            label1.Text = "00.00.00";
        }
    }
}