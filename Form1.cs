using System;
using System.Windows.Forms;

namespace OnlyFriends {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e) {


		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}
		private bool flag = true;
		private void textBox2_Enter(object sender, EventArgs e) {
			if (flag) { textBox2.Text = string.Empty; flag = false; }
			textBox2.UseSystemPasswordChar = true;
		}

		private void textBox1_Leave(object sender, EventArgs e) {
			//check valid characters for username
			//check for cotrect email format
			//query request
			//change the lbl visibility in case for any error

		}
		//to press any buttons there mustn't be any errors and thus the labels must be noot visble
		private void button1_Click(object sender, EventArgs e) {

		}

		private void button2_Click(object sender, EventArgs e) {

		}

		private void form2btn_Click(object sender, EventArgs e) {
			Form2 form2 = new Form2();
			this.Hide();
			form2.Show();


		}
	}
}
