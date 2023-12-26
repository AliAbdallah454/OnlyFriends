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
    public partial class SuggestedFriendComponent : UserControl {
        public SuggestedFriendComponent() {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e) {
            addButton.Visible = false;
            requestedButton.Visible = true;
        }

        private void requestedButton_Click(object sender, EventArgs e) {
            requestedButton.Visible = false;
            addButton.Visible = true;
        }
    }
}
