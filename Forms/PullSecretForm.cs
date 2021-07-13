using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRCTray.Helpers;

namespace CRCTray
{
    public partial class PullSecretForm : Form
    {
        
        public PullSecretForm()
        {
            InitializeComponent();

            PullSecret = String.Empty;
        }

        private void PullSecretPicker_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
        }

        public String PullSecret
        {
            get;
            set;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            PullSecret = pullSecreTextbox.Text;
            Hide();
        }
    }
}
