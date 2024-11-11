namespace Inlämning.databas
{
    partial class FormAdvertisement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            labelAdvertisment = new Label();
            buttonSignUpOrLogIn = new Button();
            buttonSearch = new Button();
            buttonDelete = new Button();
            buttonNewAd = new Button();
            buttonEditAd = new Button();
            listBoxAd = new ListBox();
            buttonDate = new Button();
            buttonPrice = new Button();
            label1 = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(22, 21);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(105, 20);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Sök på annons";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(22, 44);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(190, 27);
            textBoxSearch.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(22, 119);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(190, 28);
            comboBoxCategory.TabIndex = 2;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(22, 96);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 20);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Kategory";
            // 
            // labelAdvertisment
            // 
            labelAdvertisment.AutoSize = true;
            labelAdvertisment.Location = new Point(22, 170);
            labelAdvertisment.Name = "labelAdvertisment";
            labelAdvertisment.Size = new Size(71, 20);
            labelAdvertisment.TabIndex = 5;
            labelAdvertisment.Text = "Annonser";
            // 
            // buttonSignUpOrLogIn
            // 
            buttonSignUpOrLogIn.Location = new Point(680, 12);
            buttonSignUpOrLogIn.Name = "buttonSignUpOrLogIn";
            buttonSignUpOrLogIn.Size = new Size(165, 29);
            buttonSignUpOrLogIn.TabIndex = 6;
            buttonSignUpOrLogIn.Text = "Logga in / Registrera ";
            buttonSignUpOrLogIn.UseVisualStyleBackColor = true;
            buttonSignUpOrLogIn.Click += buttonSignUpOrLogIn_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(266, 42);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(113, 29);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(523, 398);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 29);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Ta bort annons";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNewAd
            // 
            buttonNewAd.Location = new Point(22, 398);
            buttonNewAd.Name = "buttonNewAd";
            buttonNewAd.Size = new Size(160, 29);
            buttonNewAd.TabIndex = 9;
            buttonNewAd.Text = "Ny annons";
            buttonNewAd.UseVisualStyleBackColor = true;
            buttonNewAd.Click += buttonNewAd_Click;
            // 
            // buttonEditAd
            // 
            buttonEditAd.Location = new Point(276, 398);
            buttonEditAd.Name = "buttonEditAd";
            buttonEditAd.Size = new Size(157, 29);
            buttonEditAd.TabIndex = 10;
            buttonEditAd.Text = "Redigera annons";
            buttonEditAd.UseVisualStyleBackColor = true;
            buttonEditAd.Click += buttonEditAd_Click;
            // 
            // listBoxAd
            // 
            listBoxAd.FormattingEnabled = true;
            listBoxAd.Location = new Point(22, 199);
            listBoxAd.Name = "listBoxAd";
            listBoxAd.Size = new Size(823, 184);
            listBoxAd.TabIndex = 11;
            listBoxAd.SelectedIndexChanged += listBoxAd_SelectedIndexChanged;
            // 
            // buttonDate
            // 
            buttonDate.Location = new Point(638, 166);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(94, 29);
            buttonDate.TabIndex = 12;
            buttonDate.Text = "Datum";
            buttonDate.UseVisualStyleBackColor = true;
            buttonDate.Click += buttonDate_Click;
            // 
            // buttonPrice
            // 
            buttonPrice.Location = new Point(751, 166);
            buttonPrice.Name = "buttonPrice";
            buttonPrice.Size = new Size(94, 29);
            buttonPrice.TabIndex = 13;
            buttonPrice.Text = "Pris";
            buttonPrice.UseVisualStyleBackColor = true;
            buttonPrice.Click += buttonPrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 170);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 14;
            label1.Text = "Sortera efter:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(751, 398);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Rensa ";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // FormAdvertisement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 447);
            Controls.Add(buttonClear);
            Controls.Add(label1);
            Controls.Add(buttonPrice);
            Controls.Add(buttonDate);
            Controls.Add(listBoxAd);
            Controls.Add(buttonEditAd);
            Controls.Add(buttonNewAd);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSignUpOrLogIn);
            Controls.Add(labelAdvertisment);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Name = "FormAdvertisement";
            Text = "Sök annonser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private TextBox textBoxSearch;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private Label labelAdvertisment;
        private Button buttonSignUpOrLogIn;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button buttonNewAd;
        private Button buttonEditAd;
        private ListBox listBoxAd;
        private Button buttonDate;
        private Button buttonPrice;
        private Label label1;
        private Button buttonClear;
    }
}
