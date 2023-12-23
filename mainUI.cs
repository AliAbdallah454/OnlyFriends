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
    public partial class mainUI : Form {
        public mainUI() {
            InitializeComponent();
        }
        private void mouseEnter_Bold(object sender, EventArgs e) {
            if (sender is Label panel) {
                panel.Font = new Font(panel.Font, FontStyle.Bold);
                panel.ForeColor = Color.Black;
            }
        }
        private void mouseLeave_Regular(object sender, EventArgs e) {
            if (sender is Label panel) {
                panel.Font = new Font(panel.Font, FontStyle.Regular);
                panel.ForeColor = Color.Gray;
            }
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e) {

        }

        private void interactions_MouseEnter(object sender, EventArgs e) {
            if (sender is PictureBox x) {
                switch (x.Name) {
                    case "likeBtn":
                        if (buttonclicked[0]) break;
                        likeBtn.Image = Properties.Resources.heart__1_;
                        break;
                    case "commentBtn":
                        if (buttonclicked[1]) break;
                        commentBtn.Image = Properties.Resources.chat;
                        break;
                    case "shareBtn":
                        if (buttonclicked[2]) break;
                        shareBtn.Image = Properties.Resources.share;
                        break;

                }
            }
        }
        private void interactions_MouseLeave(object sender, EventArgs e) {
            if (sender is PictureBox x) {
                switch (x.Name) {
                    case "likeBtn":
                        if (buttonclicked[0]) break;
                        likeBtn.Image = Properties.Resources.heart__2_;
                        break;
                    case "commentBtn":
                        if (buttonclicked[1]) break;
                        commentBtn.Image = Properties.Resources.chat_bubble;
                        break;
                    case "shareBtn":
                        if (buttonclicked[2]) break;
                        shareBtn.Image = Properties.Resources.social;
                        break;

                }
            }

        }
        private bool[] buttonclicked = { false, false, false };
        private void interactions_Click(object sender, EventArgs e) {
            if (sender is PictureBox x) {
                switch (x.Name) {
                    case "likeBtn":
                        likeBtn.Image = (!buttonclicked[0]) ? Properties.Resources.heart__1_ : Properties.Resources.heart__2_;
                        buttonclicked[0] = !buttonclicked[0];
                        break;
                    case "commentBtn":
                        commentBtn.Image = (!buttonclicked[1]) ? Properties.Resources.chat : Properties.Resources.chat_bubble;
                        buttonclicked[1] = !buttonclicked[1];
                        break;
                    case "shareBtn":
                        shareBtn.Image = (!buttonclicked[2]) ? Properties.Resources.share : Properties.Resources.social;
                        buttonclicked[2] = !buttonclicked[2];
                        break;

                }
            }
        }

    }
}
