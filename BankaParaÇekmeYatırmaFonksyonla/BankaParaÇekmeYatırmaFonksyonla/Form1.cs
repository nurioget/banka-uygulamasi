namespace BankaParaÇekmeYatırmaFonksyonla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ad = "taci";
        int parola = 123;
        int hak = 3;
        int bakiye = 10000;
        static int paracek(int x, int y)
        {
            return x - y;

        }
        static int parayatir(int x, int y)
        {
            return x + y;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string isim = Convert.ToString(textBox1.Text);
                int sifre = Convert.ToInt32(textBox2.Text);

                if (hak == 0)
                {
                    MessageBox.Show("hatalı giriş hakkınız kalmadı");
                    this.Close();
                }
                else
                {
                    if (sifre == parola && ad == isim)
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                    }
                    else
                    {
                        hak--;
                        label4.Text = hak.ToString();
                        MessageBox.Show("kullanıcı adı veya şifre yanlış tekrar deneyiniz");
                        label4.Visible = true;
                        label5.Visible = true;
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = hak.ToString();
            textBox1.Focus();
            panel2.Visible = false;
            label6.Text = bakiye.ToString();
            label4.Visible = false;
            label5.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    int cekilentutar = Convert.ToInt32(textBox3.Text);
                    int sonpara = paracek(bakiye, cekilentutar);
                    bakiye -= cekilentutar;
                    label6.Text = sonpara.ToString();
                }
            }
            catch
            {

                MessageBox.Show("hatalı giriş yaptınız");
            }

            textBox3.Clear();
            checkBox1.Checked = false;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int yatirilantutar = Convert.ToInt32(textBox4.Text);
                if (checkBox2.Checked == true)
                {
                    int sonpara = parayatir(bakiye, yatirilantutar);
                    bakiye += yatirilantutar;
                    label6.Text = sonpara.ToString();

                }
            }
            catch
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }
            textBox4.Clear();
            checkBox2.Checked = false;


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}