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
    public partial class Tweet : UserControl {
        public Tweet() {
            InitializeComponent();
        }

        #region Properties

        private string uName;
        public string UName {
            get { return uName; }
            set { uName = value; usernameLabel.Text = value; }
        }

        #endregion Properties
    }
}
