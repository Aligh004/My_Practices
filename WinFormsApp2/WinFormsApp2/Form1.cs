namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operaator;
        float num1, num2, result;

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operaator = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }



        private void button13_Click(object sender, EventArgs e)
        {
            operaator = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operaator = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operaator = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
              
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);
            if (operaator == "+")
                result = num1 + num2;
            else if (operaator == "-")
                result = num1 - num2;
            else if (operaator == "*")
                result = num1 * num2;
            else if (operaator == "/")
            {
                if (num2 == 0)
                    MessageBox.Show("Cannot divide by zero");
                else
                    result = num1 / num2;
            }
                txtTotal.Text = result.ToString();
                num1 = 0;
                num2 = 0;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}