using Inlämning.databas.Entities;
using Inlämning.databas.Repository;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.VisualBasic.ApplicationServices;

namespace Inlämning.databas
{
    public partial class FormAdvertisement : Form
    {
        private List<Category> categories;
        private List<Advertisement> advertisements;
        private Entities.User currentUser;
        public FormAdvertisement(Entities.User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadAd();
            LoadCategory();
            UpdateButtonVisibility();
        }
        private void LoadAd()
        {
            AdvertisementsRepo repo = new AdvertisementsRepo();
            advertisements = repo.GetAll();
            BindAdvertisements();
            UpdateButtonVisibility();
        }
        private void BindAdvertisements()
        {
            listBoxAd.DisplayMember = "ToString";
            listBoxAd.ValueMember = "AdvertisementID";
            listBoxAd.DataSource = advertisements;
        }
        private void LoadCategory()
        {
            CategoryRepo repo = new CategoryRepo();
            categories = repo.GetList();

            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.SelectedIndex = -1;
        }
        private void UpdateButtonVisibility()
        {
            if (currentUser?.UsersID != null)
            {
                buttonNewAd.Visible = true;
            }
            else
            {
                buttonNewAd.Visible = false;
            }

            if (listBoxAd.SelectedItem is Advertisement selectedAd)
            {
                bool isOwner = selectedAd.UsersID == currentUser?.UsersID;
                buttonDelete.Visible = isOwner;
                buttonEditAd.Visible = isOwner;
            }
            else
            {
                buttonDelete.Visible = false;
                buttonEditAd.Visible = false;
            }
        }
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = comboBoxCategory.SelectedItem as Category;
            if (selectedCategory == null)
            {
                MessageBox.Show("Vänligen välj en kategori.");
                return;
            }
            else
            {
                var repo = new AdvertisementsRepo();
                advertisements = repo.SearchAd(null, selectedCategory.CategoryID);
                BindAdvertisements();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchWord = textBoxSearch.Text.Trim();
            var selectedCategory = comboBoxCategory.SelectedItem as Category;

            var repo = new AdvertisementsRepo();
            if (selectedCategory == null)
            {
                advertisements = repo.SearchAd(searchWord, null);
            }
            else
            {
                advertisements = repo.SearchAd(searchWord, selectedCategory.CategoryID);
            }

            BindAdvertisements();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAd.SelectedItem is Advertisement adSelected && adSelected.UsersID == currentUser.UsersID)
            {
                var result = MessageBox.Show("Är du säker på att du vill ta bort denna annons?", "Bekräfta borttagning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var repo = new AdvertisementsRepo();
                    repo.Delete(adSelected);
                    LoadAd();
                }
            }
        }

        private void buttonNewAd_Click(object sender, EventArgs e)
        {
            var newAd = new FormEdit(null, categories, currentUser.UsersID);
            if (newAd.ShowDialog() == DialogResult.OK)
            {
                LoadAd();
            }
        }

        private void buttonEditAd_Click(object sender, EventArgs e)
        {
            if (listBoxAd.SelectedItem is Advertisement editAd && editAd.UsersID == currentUser.UsersID)
            {
                var editForm = new FormEdit(editAd, categories, currentUser.UsersID);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAd();
                }
            }
        }
        private void buttonSignUpOrLogIn_Click(object sender, EventArgs e)
        {
            SignUpOrLogin signUpOrLogin = new SignUpOrLogin();
            this.Hide();
            signUpOrLogin.ShowDialog();
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            AdvertisementsRepo repo = new AdvertisementsRepo();
            advertisements = repo.Sort("Date");
            BindAdvertisements();
        }
        private void buttonPrice_Click(object sender, EventArgs e)
        {
            AdvertisementsRepo repo = new AdvertisementsRepo();
            advertisements = repo.Sort("Price");
            BindAdvertisements();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            listBoxAd.ClearSelected();
            comboBoxCategory.SelectedIndex = -1;
            LoadAd();
        }

        private void listBoxAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
        }
    }
}
