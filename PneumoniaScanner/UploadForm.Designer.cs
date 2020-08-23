namespace PneumoniaScanner
{
    partial class UploadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.imageName = new System.Windows.Forms.Label();
            this.xrayImage = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.treatmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xrayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please provide your chest x-ray image";
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectButton.FlatAppearance.BorderSize = 2;
            this.selectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectButton.ForeColor = System.Drawing.Color.Navy;
            this.selectButton.Location = new System.Drawing.Point(331, 414);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(160, 49);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Upload an image";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // runButton
            // 
            this.runButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.runButton.BackColor = System.Drawing.SystemColors.Control;
            this.runButton.FlatAppearance.BorderSize = 2;
            this.runButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runButton.ForeColor = System.Drawing.Color.Red;
            this.runButton.Location = new System.Drawing.Point(331, 532);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(160, 49);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Start scanning";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // imageName
            // 
            this.imageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.imageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imageName.Location = new System.Drawing.Point(160, 477);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(502, 25);
            this.imageName.TabIndex = 8;
            this.imageName.Text = "Example image";
            this.imageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imageName.Visible = false;
            // 
            // xrayImage
            // 
            this.xrayImage.Image = ((System.Drawing.Image)(resources.GetObject("xrayImage.Image")));
            this.xrayImage.Location = new System.Drawing.Point(141, 52);
            this.xrayImage.Name = "xrayImage";
            this.xrayImage.Size = new System.Drawing.Size(540, 354);
            this.xrayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xrayImage.TabIndex = 3;
            this.xrayImage.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.ForeColor = System.Drawing.Color.Navy;
            this.backButton.Location = new System.Drawing.Point(12, 532);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 49);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // treatmentButton
            // 
            this.treatmentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treatmentButton.BackColor = System.Drawing.SystemColors.Control;
            this.treatmentButton.FlatAppearance.BorderSize = 2;
            this.treatmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.treatmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.treatmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treatmentButton.ForeColor = System.Drawing.Color.Navy;
            this.treatmentButton.Location = new System.Drawing.Point(700, 532);
            this.treatmentButton.Name = "treatmentButton";
            this.treatmentButton.Size = new System.Drawing.Size(110, 49);
            this.treatmentButton.TabIndex = 10;
            this.treatmentButton.Text = "Treatment";
            this.treatmentButton.UseVisualStyleBackColor = false;
            this.treatmentButton.Click += new System.EventHandler(this.treatmentButton_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(148)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(822, 593);
            this.Controls.Add(this.treatmentButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.xrayImage);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pneumonia Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.xrayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox xrayImage;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label imageName;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button treatmentButton;
    }
}