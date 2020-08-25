namespace PneumoniaAssistant
{
    partial class InitialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.initialPhoto = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // initialPhoto
            // 
            this.initialPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initialPhoto.Image = global::PneumoniaAssistant.Properties.Resources.xrayPhoto;
            this.initialPhoto.Location = new System.Drawing.Point(44, 12);
            this.initialPhoto.Name = "initialPhoto";
            this.initialPhoto.Size = new System.Drawing.Size(325, 325);
            this.initialPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.initialPhoto.TabIndex = 0;
            this.initialPhoto.TabStop = false;
            this.initialPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.Location = new System.Drawing.Point(40, 340);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(332, 24);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Pneumonia Assistant!";
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.BackColor = System.Drawing.SystemColors.Control;
            this.continueButton.FlatAppearance.BorderSize = 3;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueButton.ForeColor = System.Drawing.Color.Navy;
            this.continueButton.Location = new System.Drawing.Point(152, 382);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(108, 49);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(92, 511);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(228, 17);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "Copyright © 2020 by Karlo Pavleka";
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(412, 537);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.initialPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pneumonia Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.initialPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox initialPhoto;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

