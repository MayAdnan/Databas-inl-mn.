namespace Inlämning.databas
{
    partial class Form1
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
            listViewAdvertisment = new ListView();
            labelAdvertisment = new Label();
            buttonSignUpOrLogIn = new Button();
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
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(22, 119);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
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
            // listViewAdvertisment
            // 
            listViewAdvertisment.Location = new Point(397, 159);
            listViewAdvertisment.Name = "listViewAdvertisment";
            listViewAdvertisment.Size = new Size(151, 121);
            listViewAdvertisment.TabIndex = 4;
            listViewAdvertisment.UseCompatibleStateImageBehavior = false;
            // 
            // labelAdvertisment
            // 
            labelAdvertisment.AutoSize = true;
            labelAdvertisment.Location = new Point(397, 127);
            labelAdvertisment.Name = "labelAdvertisment";
            labelAdvertisment.Size = new Size(97, 20);
            labelAdvertisment.TabIndex = 5;
            labelAdvertisment.Text = "Advertisment";
            // 
            // buttonSignUpOrLogIn
            // 
            buttonSignUpOrLogIn.Location = new Point(432, 17);
            buttonSignUpOrLogIn.Name = "buttonSignUpOrLogIn";
            buttonSignUpOrLogIn.Size = new Size(165, 29);
            buttonSignUpOrLogIn.TabIndex = 6;
            buttonSignUpOrLogIn.Text = "Sign up / Log in ";
            buttonSignUpOrLogIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 425);
            Controls.Add(buttonSignUpOrLogIn);
            Controls.Add(labelAdvertisment);
            Controls.Add(listViewAdvertisment);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private TextBox textBoxSearch;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private ListView listViewAdvertisment;
        private Label labelAdvertisment;
        private Button buttonSignUpOrLogIn;
    }
}
