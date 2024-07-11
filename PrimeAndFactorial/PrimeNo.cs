namespace PrimeAndFactorial {
    public partial class PrimeNo : Form {
        public PrimeNo() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int num;
            double prime, squr_root;
            try {
                prime = Double.Parse(textBox1.Text);
                squr_root = Math.Sqrt(prime);

                for (num = 2; num <= squr_root; num++) {
                    if (prime % num == 0) {
                        MessageBox.Show(prime + " is not a prime number");
                        break;
                    }
                }
                if (num > squr_root) MessageBox.Show(prime + " is a prime number");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
