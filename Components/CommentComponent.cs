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
    public partial class CommentComponent : UserControl {
        public CommentComponent() {
            InitializeComponent();
        }

        #region Properties

        private int commentId;
        private int postId;
        private int userId;
        private string userName;
        private string content;
        private DateTime timeStamp;

        public int CommentId {
            get { return commentId; }
            set { commentId = value; }
        }
        public int PostId {
            get { return postId; }
            set { postId = value; }
        }
        public int UserId {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName {
            get { return userName; }
            set { userName = value; usernameLabel.Text = value; }
        }
        public string Content {
            get { return content; }
            set { content = value; contentLabel.Text = value; }
        }
        public DateTime TimeStamp {
            get { return timeStamp; }
            set { timeStamp = value; timeStampLabel.Text = value.ToString(); }
        }

        #endregion Properties
    }
}
