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
    public partial class CrcSettingsForm : Form
    {
        public CrcSettingsForm()
        {
            InitializeComponent();
        }

        private void CrcSettingsForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Resource.ocp_logo);
            Icon = Icon.FromHandle(bm.GetHicon());
            Text = @"CodeReady Containers - Settings";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CRC Bundle|*.crcbundle";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            MessageBox.Show(fileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            MessageBox.Show(fileName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
