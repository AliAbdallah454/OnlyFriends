using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends {
    public partial class Comments : Form {
        bool textBoxEntered = false;
        public Comments() {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void addCommentBox_Enter(object sender, EventArgs e) {
            if (!textBoxEntered) {
                addCommentBox.Text = string.Empty;
                textBoxEntered = true;
            }
        }

        private void addCommentBox_Leave(object sender, EventArgs e) {
            if(addCommentBox.Text == string.Empty) {
                addCommentBox.Text = "add comment...";
                textBoxEntered = false;
            }
        }

        private void addCommentButton_Click(object sender, EventArgs e) {
            string comment = addCommentBox.Text;

            try {

                User user = User.Instance;
                user.commentOnPost(12, comment);
                addCommentBox.Text = "";
            }
            catch (Exception ex) {
                addCommentBox.Text = "";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
