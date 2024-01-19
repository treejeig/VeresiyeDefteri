using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeresiyeDefteri.DataAccess;
using VeresiyeDefteri.Helpers;
using VeresiyeDefteri.Pages.ListPages;

namespace VeresiyeDefteri.Pages
{
    public partial class LoginPageForm : Form
    {
        LoginController loginController = new LoginController();
        MessageBoxes messageBoxes = new MessageBoxes();
        bool initialUser = false;
        public LoginPageForm()
        {
            InitializeComponent();
            PrepareLoginPage();
        }

        public void PrepareLoginPage()
        {
            if (loginController.GetUserCount() == 0)
            {
                initialUser = true;
                UserLoginButton.Text = "Kaydol";
            }
            else
            {
                initialUser = false;
                UserLoginButton.Text = "Giriş";
                UserNameTextBox.Text = null;
                UserPasswordTextBox.Text = null;
                UserPasswordAgainLabel.Visible = false;
                UserPasswordAgainTextBox.Visible = false;
                UserPasswordAgainTextBox.Text = null;
                UserLoginButton.Location = new System.Drawing.Point(40, 150);
            }

        }

        public void TryLogin()
        {
            if (loginController.CanLogin(UserNameTextBox.Text, UserPasswordTextBox.Text))
            {
                GoToHome();
            }
            else
            {
                ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Giriş Reddedildi", "Kullanıcı adı veya şifre hatalı"));
            }
        }

        public void GoToHome()
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.FormClosed += (s, args) => Close();
            Hide();
            homePageForm.ShowDialog();
        }

        private void ShowInfoMessageBoxAndRefreshPage(bool res)
        {
            if (res)
            {
                PrepareLoginPage();
            }
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            if (initialUser)
            {
                if (ValidateNewUser() && loginController.AddUser(UserNameTextBox.Text, UserPasswordTextBox.Text))
                {
                    ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Başarılı", $"Kullanıcı eklendi.\nGiriş yapabilirsiniz."));
                }
            }
            else
            {
                TryLogin();
            }
        }

        private bool ValidateNewUser()
        {
            if (string.IsNullOrEmpty(UserNameTextBox.Text) || string.IsNullOrEmpty(UserPasswordTextBox.Text) || string.IsNullOrEmpty(UserPasswordAgainTextBox.Text))
            {
                ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Hata", "\"Kullanıcı Adı\", \"Şifre\" ve \"Şifre Tekrar\" alanları doldurulmalıdır."));
                return false;
            }
            if (UserPasswordTextBox.Text != UserPasswordAgainTextBox.Text)
            {
                ShowInfoMessageBoxAndRefreshPage(messageBoxes.InformationMessageBox("Hata", "\"Şifre\" ve \"Şifre Tekrar\" alanları aynı olmalıdır."));
                return false;
            }
            return true;
        }

        private void UserPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                UserLoginButton_Click(sender, e);
            }
        }
    }
}
