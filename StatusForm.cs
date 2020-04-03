using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tray_windows
{
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            this.Icon = Icon.FromHandle(bm.GetHicon());
            this.Text = @"CodeReady Containers Status";
        }
    }
}
