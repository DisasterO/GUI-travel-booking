namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // Logo background remover
            panel1.Controls.Add(pictureBox1);
            pictureBox1.Location = new Point(470, 44);
            pictureBox1.BackColor = Color.Transparent;
            // Username background remover
            panel1.Controls.Add(label1);
            label1.Location = new Point(499, 299);
            label1.BackColor = Color.Transparent;
            // Password background remover
            panel1.Controls.Add(label2);
            label2.Location = new Point(499, 340);
            label2.BackColor = Color.Transparent;

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
           
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {


            string id = textBox1.Text;
            string password = textBox2.Text;

            if ( id == "123" && password == "123") {

                Form2 Y = new Form2();
                Y.Show();
            }
            else {
                MessageBox.Show("Incorrect Usernme/Password. Please check you login information and try again.");
            }
        }
    }
}