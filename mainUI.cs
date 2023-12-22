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
    }
    
}
