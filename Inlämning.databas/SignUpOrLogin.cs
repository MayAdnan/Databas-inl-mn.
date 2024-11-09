using Inlämning.databas.Repository;
using User = Inlämning.databas.Entities.User;

namespace Inlämning.databas
{
    public partial class SignUpOrLogin : Form
    {
        private UsersRepo userRepo;
        private FormAdvertisement formAdvertisement;
        public SignUpOrLogin()
        {
            InitializeComponent();
            userRepo = new UsersRepo();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string Password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Fälten får inte vara tomma.");
                return;
            }

            User user = userRepo.GetUsername(username);

            if (user != null && user.PasswordUser == Password)
            {
                MessageBox.Show("Du är inloggad!");
                formAdvertisement = new FormAdvertisement(user.UsersID);
                formAdvertisement.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Ogiltig användarnamn eller lösenord.");
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            User newUser = new User(0, username, password);

            if (userRepo.CreateUser(newUser))
            {
                MessageBox.Show("Ett konto har skappats, du kan logga in nu");
            }
            else
            {
                MessageBox.Show("Välj ett annat användarnamn.");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (formAdvertisement != null)
            {
                formAdvertisement.Close();
            }
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            this.Show();
            MessageBox.Show("Du har loggat ut.");
        }
    }
}
