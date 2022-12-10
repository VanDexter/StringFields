using System.Text.RegularExpressions;

namespace StringFields
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))

            {
                var errorMsg = MessageBox.Show("Enter only Letters");
                return;
            }
                
            else if (!Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 1 Error. Enter only Letters");
            }           
            else if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 2 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox3.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 3 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 4 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox5.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 5 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox6.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 6 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox7.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 7 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox8.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 8 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox9.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 9 Error. Enter only Letters");
            }
            else if (!Regex.IsMatch(textBox10.Text, @"^[a-zA-Z]+$"))
            {
                var errorMsG = MessageBox.Show("Text Box 10 Error. Enter only Letters");
            }
            else 
            
            {
                                var length = 
                    textBox1.Text.Length +
                    textBox2.Text.Length +
                    textBox3.Text.Length +
                    textBox4.Text.Length +
                    textBox5.Text.Length +
                    textBox6.Text.Length +
                    textBox7.Text.Length +
                    textBox8.Text.Length +
                    textBox8.Text.Length +
                    textBox9.Text.Length +
                    textBox10.Text.Length;
              
                var showLength = MessageBox.Show("the number of letters is: " + length.ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            //    e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}