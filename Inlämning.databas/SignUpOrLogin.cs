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
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fälten får inte vara tomma.");
                return;
            }

            User user = userRepo.GetUsername(username);

            if (user == null)
            {
                MessageBox.Show("Ogiltig användarnamn eller lösenord.");
                return;
            }

            if (user.PasswordUser == password)
            {
                MessageBox.Show("Du är inloggad!");
                formAdvertisement = new FormAdvertisement(user);
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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Användarnamn och lösenord får inte vara tomma.");
                return;
            }

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

            MessageBox.Show("Du har loggat ut.");
            formAdvertisement = new FormAdvertisement(null);
            formAdvertisement.Show();
            this.Hide();
        }
    }
}