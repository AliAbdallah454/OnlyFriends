using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyFriends.Components {
    public partial class FriendSearchResult : UserControl {
        public FriendSearchResult() {
            InitializeComponent();
        }
        bool clickedRequested = false;

        private void removeFriendButton_Click(object sender, EventArgs e) {
            if(sender is Button x) {
                (x.Image, x.Text) = (clickedRequested) ? (Properties.Resources.icons8_done_26, "Requested") : (Properties.Resources.icons8_add_42, "Request");
                clickedRequested=!clickedRequested;
            }
        }
    }
}
