using Microsoft.VisualBasic;
using System.Text;
using System.Web;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);

            {
                int f1 = 0, f2 = 1, f3 = 0;


                if (x == 1)
                    Console.WriteLine(f1);
                else if (x == 2)
                    Console.WriteLine(f2);
                else if (x > 2)
                    for (int i = 1; i < x; i++)
                    {
                        f1 = f2;
                        f2 = f3;
                        f3 = f1 + f2;
                    }
                MessageBox.Show("The Answer Is: " + f3.ToString());
            }




        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
