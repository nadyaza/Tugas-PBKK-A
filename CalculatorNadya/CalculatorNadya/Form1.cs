namespace CalculatorNadya
{
    public partial class Form1 : Form
    {
        decimal bill1;
        decimal bill2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "8";
            }
            else
            {
                txtDisplay1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "3";
            }
            else
            {
                txtDisplay1.Text += "3";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = ":";
            txtDisplay1.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "1";
            }
            else
            {
                txtDisplay1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "2";
            }
            else
            {
                txtDisplay1.Text += "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "5";
            }
            else
            {
                txtDisplay1.Text += "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "4";
            }
            else
            {
                txtDisplay1.Text += "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "6";
            }
            else
            {
                txtDisplay1.Text += "6";
            }
        }



        private void button13_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "+";
            txtDisplay1.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(txtDisplay1.Text != "0")
            {
                txtDisplay1.Text += "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "7";
            }
            else
            {
                txtDisplay1.Text += "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "9";
            }
            else
            {
                txtDisplay1.Text += "9";
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            bill1 = 0;
            bill2 = 0;
            txtDisplay2.Text = " ";

        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "×";
            txtDisplay1.Text = " ";
            opr = 1;
            opr_selesai = true;

        }

        private void buttoncoma_Click(object sender, EventArgs e)
        {
            if (!txtDisplay1.Text.Contains("."))
            {
                txtDisplay1.Text += ".";
            }
        }

        private void buttonkurang_Click(object sender, EventArgs e)
        {
            bill1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay2.Text = "-";
            txtDisplay1.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void buttonhasil_Click(object sender, EventArgs e)
        {
            if (opr_selesai)
            {
                decimal bilangan2 = Convert.ToDecimal(txtDisplay1.Text); // Ubah teks menjadi decimal
                decimal hasil = 0; // Inisialisasi hasil

                switch (opr)
                {
                    case 1: // Perkalian
                        hasil = bill1 * bilangan2;
                        break;
                    case 2: // Pembagian
                        hasil = bill1 / bilangan2;
                        break;
                    case 3: // Penambahan
                        hasil = bill1 + bilangan2;
                        break;
                    case 4: // Pengurangan
                        hasil = bill1 - bilangan2;
                        break;
                }

                txtDisplay1.Text = hasil.ToString(); // Tampilkan hasil dalam teks box
                opr_selesai = false;

            }
        }
    }
}