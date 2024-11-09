using Inlämning.databas.Entities;
using Inlämning.databas.Repository;
using Microsoft.Exchange.WebServices.Data;

namespace Inlämning.databas
{
    public partial class FormAdvertisement : Form
    {
        private List<Category> categories;
        private List<Advertisement> advertisements;
        private int currentID;
        public FormAdvertisement(int usersID)
        {
            InitializeComponent();
            this.currentID = usersID;
            LoadAd();
            LoadCategory();
        }
        private void LoadAd()
        {
            AdvertisementsRepo repo = new AdvertisementsRepo();
            advertisements = repo.GetAll();
            BindAdvertisements();
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
            if (currentID == 0)
            {
                MessageBox.Show("Du måste vara inloggad för att ta bort annonser.");
                return;
            }
            if (listBoxAd.SelectedItem is Advertisement adSelected)
            {
                var repo = new AdvertisementsRepo();
                repo.Delete(adSelected);
                LoadAd();
            }
        }

        private void buttonNewAd_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Du måste vara inloggad för att lägga till annonser.");
                return;
            }
            var newAd = new FormEdit(null, categories, currentID);
            if (newAd.ShowDialog() == DialogResult.OK)
            {
                LoadAd();
            }
        }

        private void buttonEditAd_Click(object sender, EventArgs e)
        {
            if (currentID == 0)
            {
                MessageBox.Show("Du måste vara inloggad för att redigera annonser.");
                return;
            }

            if (listBoxAd.SelectedItem is Advertisement editAd)
            {
                var editForm = new FormEdit(editAd, categories, currentID);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAd();
                }
            }
            else
            {
                MessageBox.Show("Välj en annos att redigera");
            }
        }

        private void buttonSignUpOrLogIn_Click(object sender, EventArgs e)
        {
            SignUpOrLogin signUpOrLogin = new SignUpOrLogin();
            signUpOrLogin.ShowDialog();
            this.Hide();
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
            var advertisements = repo.Sort("Price");
            BindAdvertisements();
        }
    }
}
