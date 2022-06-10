using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLenght = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLenght)
        {
            String allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghjklmnopqrstuvwxyz!@#$%^&";
            String randomPassword = "";

            for (int i = 0; i < passwordLenght; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            passwordLabel.Text = randomPassword;
        }

        public Form1()
        {
            InitializeComponent();

            passwordLenghtSlider.Minimum = 5;
            passwordLenghtSlider.Maximum = 20;
            passwordGenerator(5);
        }

        private void passwordLenghtSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLenghtLabel.Text = "Password Lenght: " + passwordLenghtSlider.Value.ToString();
            currentPasswordLenght = passwordLenghtSlider.Value;
            passwordGenerator(currentPasswordLenght);
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }
    }
}
