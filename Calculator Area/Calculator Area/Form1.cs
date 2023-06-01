using System.Security.Cryptography.Pkcs;

namespace Calculator_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox2.Visible = false;
            label6.Visible = false;
            panel1.Visible = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cevre, alan, kenar1, kenar2;
            if (textBox2.Visible == true)
            {
              
                kenar1 = Convert.ToInt32(textBox1.Text);
                kenar2
                   = Convert.ToInt32(textBox2.Text);
                cevre = kenar1 * 2 + kenar2 * 2;
                alan = kenar1 * kenar2;
                label3.Text = Convert.ToString(cevre);
                label5.Text = Convert.ToString(alan);

            }
            else
            {
                kenar1 = Convert.ToInt32(textBox1.Text);
                cevre = kenar1 * 4;
                alan = kenar1 * kenar1;
                label3.Text = Convert.ToString(cevre);
                label5.Text = Convert.ToString(alan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }
    }
}