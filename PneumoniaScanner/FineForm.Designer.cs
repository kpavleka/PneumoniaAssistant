namespace PneumoniaScanner
{
    partial class FineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FineForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greatLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkSymptomsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PneumoniaScanner.Properties.Resources.doctorsPhoto;
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // greatLabel
            // 
            this.greatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greatLabel.AutoSize = true;
            this.greatLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greatLabel.Location = new System.Drawing.Point(134, 423);
            this.greatLabel.Name = "greatLabel";
            this.greatLabel.Size = new System.Drawing.Size(273, 24);
            this.greatLabel.TabIndex = 2;
            this.greatLabel.Text = "Great to hear! Stay healthy!";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(273, 464);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 52);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkSymptomsButton
            // 
            this.checkSymptomsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkSymptomsButton.BackColor = System.Drawing.SystemColors.Control;
            this.checkSymptomsButton.FlatAppearance.BorderSize = 2;
            this.checkSymptomsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.checkSymptomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSymptomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkSymptomsButton.ForeColor = System.Drawing.Color.Navy;
            this.checkSymptomsButton.Location = new System.Drawing.Point(133, 464);
            this.checkSymptomsButton.Name = "checkSymptomsButton";
            this.checkSymptomsButton.Size = new System.Drawing.Size(134, 52);
            this.checkSymptomsButton.TabIndex = 4;
            this.checkSymptomsButton.Text = "Recheck symptoms";
            this.checkSymptomsButton.UseVisualStyleBackColor = false;
            this.checkSymptomsButton.Click += new System.EventHandler(this.checkSymptomsButton_Click);
            // 
            // FineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(148)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(540, 525);
            this.Controls.Add(this.checkSymptomsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.greatLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pneumonia Assistant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greatLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkSymptomsButton;
    }
}