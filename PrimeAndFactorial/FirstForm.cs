namespace PrimeAndFactorial {
    public partial class FirstForm : Form {
        public FirstForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                Factorial f1 = new Factorial();
                Hide();
                f1.ShowDialog();
                Show();
            } else if (radioButton2.Checked == true) {
                PrimeNo f2 = new PrimeNo();
                Hide();
                f2.ShowDialog();
                Show();
            }


        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
