using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends.UserControls2 {
    public partial class AddPostControl : UserControl {
        User user=User.Instance;
        public AddPostControl() {
            InitializeComponent();
            postTitleInput.LostFocus += defaultText;
            postContentInput.LostFocus += defaultText;
            postTagsInput.LostFocus += defaultText;
        }
        private void clearer(object sender, EventArgs e) {
            if(sender is RichTextBox x) {
                error.Visible = !true;
                if (x.Text == "Title" ||x.Text == "What are you thinking about?" || x.Text== "Tags" ) {
                    x.Text = string.Empty;
                }
            }
        }
        private void defaultText(object sender, EventArgs e) {
            if(sender is RichTextBox textBox) {
                if (textBox.Text != String.Empty) return;
                switch(textBox.Name) {
                    case "postTitleInput":
                        textBox.Text = "Title";
                        break;
                    case "postContentInput":
                        textBox.Text = "What are you thinking about?";
                        break;
                    case "postTagsInput":
                        textBox.Text = "Tags";
                        break;
                }
            }
        }

        private void postButton_Click(object sender, EventArgs e) {
            if (sender is Button x) {
                if (postTitleInput.Text == "Title" || postContentInput.Text == "What are you thinking about?" || postTagsInput.Text == "Tags") {
                    error.Visible = true;
                    return;
                }
                user.addPost(postTitleInput.Text, postContentInput.Text, postTagsInput.Text);
            }
        }
    }
}
