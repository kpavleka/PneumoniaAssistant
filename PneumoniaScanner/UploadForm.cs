using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PneumoniaScannerML.Model;

namespace PneumoniaScanner
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        public OpenFileDialog ofd = new OpenFileDialog();

        private void selectButton_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            ofd.ShowDialog();
            if(ofd.FileName != null)
            {
                xrayImage.ImageLocation = ofd.FileName;
                imageName.Text = Path.GetFileName(xrayImage.ImageLocation);
                imageName.Visible = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new SymptomsForm();
            myForm.ShowDialog();
            this.Close();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (ofd.FileName == "")
            {
                MessageBox.Show("Please upload an X-ray image first!", "Image required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var input = new ModelInput();
                input.ImageSource = xrayImage.ImageLocation;

                var result = ConsumeModel.Predict(input);

                var precisionNormal = String.Format("Algorithm precision: {0:P2}", result.Score[0]);
                var precisionPneumonia = String.Format("Algorithm precision: {0:P2}", result.Score[1]);

                if (result.Prediction == "NORMAL")
                {
                    MessageBox.Show("Great news! You probably aren't suffering from Pneumonia!" + "\n" + precisionNormal, "Normal condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("We have detected a potential case of Pneumonia." + "\n" + "Please visit your local doctor for assistance." + "\n" + precisionPneumonia, "Pneumonia detected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }                
        }

        private void treatmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new TreatmentForm();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
