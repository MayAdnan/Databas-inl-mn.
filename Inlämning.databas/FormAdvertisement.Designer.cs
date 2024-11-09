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
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(22, 21);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(53, 20);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(22, 44);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(164, 27);
            textBoxSearch.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(22, 119);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(164, 28);
            comboBoxCategory.TabIndex = 2;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(22, 96);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 20);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Category";
            // 
            // labelAdvertisment
            // 
            labelAdvertisment.AutoSize = true;
            labelAdvertisment.Location = new Point(22, 166);
            labelAdvertisment.Name = "labelAdvertisment";
            labelAdvertisment.Size = new Size(97, 20);
            labelAdvertisment.TabIndex = 5;
            labelAdvertisment.Text = "Advertisment";
            // 
            // buttonSignUpOrLogIn
            // 
            buttonSignUpOrLogIn.Location = new Point(451, 12);
            buttonSignUpOrLogIn.Name = "buttonSignUpOrLogIn";
            buttonSignUpOrLogIn.Size = new Size(165, 29);
            buttonSignUpOrLogIn.TabIndex = 6;
            buttonSignUpOrLogIn.Text = "Sign up / Log in ";
            buttonSignUpOrLogIn.UseVisualStyleBackColor = true;
            buttonSignUpOrLogIn.Click += buttonSignUpOrLogIn_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(242, 42);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(113, 29);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(469, 384);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(113, 29);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete Advertisement";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNewAd
            // 
            buttonNewAd.Location = new Point(22, 384);
            buttonNewAd.Name = "buttonNewAd";
            buttonNewAd.Size = new Size(160, 29);
            buttonNewAd.TabIndex = 9;
            buttonNewAd.Text = "New Advertisement";
            buttonNewAd.UseVisualStyleBackColor = true;
            buttonNewAd.Click += buttonNewAd_Click;
            // 
            // buttonEditAd
            // 
            buttonEditAd.Location = new Point(242, 384);
            buttonEditAd.Name = "buttonEditAd";
            buttonEditAd.Size = new Size(157, 29);
            buttonEditAd.TabIndex = 10;
            buttonEditAd.Text = "Edit Advertisement";
            buttonEditAd.UseVisualStyleBackColor = true;
            buttonEditAd.Click += buttonEditAd_Click;
            // 
            // listBoxAd
            // 
            listBoxAd.FormattingEnabled = true;
            listBoxAd.Location = new Point(22, 199);
            listBoxAd.Name = "listBoxAd";
            listBoxAd.Size = new Size(560, 164);
            listBoxAd.TabIndex = 11;
            // 
            // buttonDate
            // 
            buttonDate.Location = new Point(388, 166);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(94, 29);
            buttonDate.TabIndex = 12;
            buttonDate.Text = "Date";
            buttonDate.UseVisualStyleBackColor = true;
            buttonDate.Click += buttonDate_Click;
            // 
            // buttonPrice
            // 
            buttonPrice.Location = new Point(488, 166);
            buttonPrice.Name = "buttonPrice";
            buttonPrice.Size = new Size(94, 29);
            buttonPrice.TabIndex = 13;
            buttonPrice.Text = "Price";
            buttonPrice.UseVisualStyleBackColor = true;
            buttonPrice.Click += buttonPrice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 170);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 14;
            label1.Text = "Sort by: ";
            // 
            // FormAdvertisement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 432);
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
            Text = "Form1";
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
    }
}
