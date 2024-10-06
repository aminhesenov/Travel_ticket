namespace travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label12.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
           // Form1 form = new Form1();
           // this.Close();
        }
        int say = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            say++;
            if (textBox3.Text.Contains("@") && textBox3.Text.Contains(".")){
                if(textBox3.Text.IndexOf("@")- textBox3.Text.IndexOf(".")==1||
                    textBox3.Text.IndexOf("@") - textBox3.Text.IndexOf(".") == -1)
                {
                    MessageBox.Show("Email yanlışdır");
                }
            }
            else
            {
                MessageBox.Show("Email yanlışdır");
            }
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Şəhərlər eynidir");
            }
            listBox1.Items.Add(say + ") Haradan: " + comboBox1.Text +
                " Haraya: " + comboBox2.Text + " Tarix: " + maskedTextBox1.Text +
                " Saat: " + maskedTextBox2.Text + " Yer: " + textBox1.Text +
                " Ad və soyad: " + textBox2.Text + " Seria: " + maskedTextBox3.Text +
                " Telefon: " + maskedTextBox4.Text + " Email: " + textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
            MessageBox.Show("Bilet uğurla silindi!");
        }
    }
}