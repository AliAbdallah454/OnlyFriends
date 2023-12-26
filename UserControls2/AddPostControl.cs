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
        private User user;
        public AddPostControl() {
            InitializeComponent();
           user = User.Instance;
        }

        private void postButton_Click(object sender, EventArgs e) {
            user.addPost(postTitleInput.Text, postContentInput.Text, postTagsInput.Text);
           
        }
    }
}
