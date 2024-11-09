using Inlämning.databas.Entities;
using Inlämning.databas.Repository;

namespace Inlämning.databas
{
    public partial class FormEdit : Form
    {
        private List<Category> categories;
        private Advertisement advertisements;
        private int usersID;
        public FormEdit(Advertisement ad, List<Category> categories, int usersID)
        {
            InitializeComponent();
            this.categories = categories;
            this.advertisements = ad; ;
            this.usersID = usersID;

            LoadCategory();

            numericUpDownPrice.Minimum = 0;
            numericUpDownPrice.Maximum = 100000;

            FormFilledWithAd();
        }
        private void LoadCategory()
        {
            CategoryRepo repo = new CategoryRepo();
            var categories = repo.GetList();

            if (categories != null && categories.Count > 0)
            {
                comboBoxCategories.DataSource = categories;
                comboBoxCategories.DisplayMember = "Name";
                comboBoxCategories.ValueMember = "CategoryID";
                comboBoxCategories.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Det finns inga kategorier.");
            }
        }

        private void FormFilledWithAd()
        {
            if (advertisements != null)
            {
                textBoxTitle.Text = advertisements.Title;
                textBoxDescriptions.Text = advertisements.Descriptions;
                numericUpDownPrice.Value = advertisements.Price;
                comboBoxCategories.SelectedValue = advertisements.CategoryID;
            }

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string descriptions = textBoxDescriptions.Text;
            decimal price = numericUpDownPrice.Value;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(descriptions) || price <= 0)
            {
                MessageBox.Show("Inga fält får vara tomma, fylla i alla fält.");
                return;
            }
            if (comboBoxCategories.SelectedValue == null)
            {
                MessageBox.Show("Vänligen välj en kategori.");
                return;
            }

            int categoryID = (int)comboBoxCategories.SelectedValue;
            var repo = new AdvertisementsRepo();
            var newAd = new Advertisement(0, title, descriptions, price, DateTime.Now, categoryID, usersID);

            repo.Add(newAd);
            MessageBox.Show("Du har skapat en ny annons.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text.Trim();
            string description = textBoxDescriptions.Text.Trim();
            decimal price = numericUpDownPrice.Value;
            int categoryID = (int)comboBoxCategories.SelectedValue;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || price <= 0)
            {
                MessageBox.Show("Du måste fylla i alla fält.");
                return;
            }

            advertisements.Title = title;
            advertisements.Descriptions = description;
            advertisements.Price = price;
            advertisements.CategoryID = categoryID;

            var adRepo = new AdvertisementsRepo();
            adRepo.Update(advertisements);
            MessageBox.Show("Annonsen är nu uppdaterad.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
