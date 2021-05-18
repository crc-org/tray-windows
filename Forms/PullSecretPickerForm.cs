using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRCTray
{
    public partial class PullSecretPickerForm : Form
    {
        string pullSecretPath = "";
        public PullSecretPickerForm()
        {
            InitializeComponent();
        }

        private void PullSecretPicker_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            browseFile.ShowDialog();
            if (browseFile.FileName != "")
            { 
                pullSecretPath = browseFile.FileName;
                pullSecretPathTextField.Text = pullSecretPath;
            }

            Console.WriteLine("Selected file: {0}", pullSecretPath);
        }

        public String ShowFilePicker()
        {
            base.ShowDialog();
            return pullSecretPath;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
