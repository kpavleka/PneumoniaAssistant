using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PneumoniaScanner
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            initialPhoto.Image = Properties.Resources.xrayPhoto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new SymptomsForm();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
