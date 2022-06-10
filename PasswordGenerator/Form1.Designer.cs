
namespace PasswordGenerator
{
    partial class Form1
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PasswordLenghtLabel = new System.Windows.Forms.Label();
            this.passwordLenghtSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(136, 63);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(484, 64);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label1";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLenghtLabel
            // 
            this.PasswordLenghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLenghtLabel.Location = new System.Drawing.Point(136, 156);
            this.PasswordLenghtLabel.Name = "PasswordLenghtLabel";
            this.PasswordLenghtLabel.Size = new System.Drawing.Size(484, 64);
            this.PasswordLenghtLabel.TabIndex = 1;
            this.PasswordLenghtLabel.Text = "Password Lenght: 5";
            this.PasswordLenghtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLenghtSlider
            // 
            this.passwordLenghtSlider.Location = new System.Drawing.Point(183, 258);
            this.passwordLenghtSlider.Name = "passwordLenghtSlider";
            this.passwordLenghtSlider.Size = new System.Drawing.Size(394, 56);
            this.passwordLenghtSlider.TabIndex = 2;
            this.passwordLenghtSlider.Scroll += new System.EventHandler(this.passwordLenghtSlider_Scroll);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyPasswordButton.Location = new System.Drawing.Point(194, 339);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(383, 51);
            this.CopyPasswordButton.TabIndex = 3;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.passwordLenghtSlider);
            this.Controls.Add(this.PasswordLenghtLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label PasswordLenghtLabel;
        private System.Windows.Forms.TrackBar passwordLenghtSlider;
        private System.Windows.Forms.Button CopyPasswordButton;
    }
}

