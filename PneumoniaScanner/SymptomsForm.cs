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
    public partial class SymptomsForm : Form
    {
        public SymptomsForm()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new FineForm();
            myForm.ShowDialog();
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new UploadForm();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
