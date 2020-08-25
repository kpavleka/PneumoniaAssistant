using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PneumoniaAssistant
{
    public partial class FineForm : Form
    {
        public FineForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkSymptomsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new SymptomsForm();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
