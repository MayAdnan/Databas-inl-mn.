namespace Inlämning.databas
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTitle = new TextBox();
            textBoxDescriptions = new TextBox();
            label1 = new Label();
            labelDescriptions = new Label();
            label3 = new Label();
            labelCategory = new Label();
            buttonSave = new Button();
            comboBoxCategories = new ComboBox();
            buttonEdit = new Button();
            numericUpDownPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(63, 73);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(378, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxDescriptions
            // 
            textBoxDescriptions.Location = new Point(63, 155);
            textBoxDescriptions.Name = "textBoxDescriptions";
            textBoxDescriptions.Size = new Size(378, 27);
            textBoxDescriptions.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // labelDescriptions
            // 
            labelDescriptions.AutoSize = true;
            labelDescriptions.Location = new Point(63, 132);
            labelDescriptions.Name = "labelDescriptions";
            labelDescriptions.Size = new Size(91, 20);
            labelDescriptions.TabIndex = 5;
            labelDescriptions.Text = "Descriptions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 214);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(63, 307);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(69, 20);
            labelCategory.TabIndex = 7;
            labelCategory.Text = "Category";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(347, 399);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(63, 341);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(378, 28);
            comboBoxCategories.TabIndex = 10;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(63, 399);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(63, 237);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(378, 27);
            numericUpDownPrice.TabIndex = 13;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 460);
            Controls.Add(numericUpDownPrice);
            Controls.Add(buttonEdit);
            Controls.Add(comboBoxCategories);
            Controls.Add(buttonSave);
            Controls.Add(labelCategory);
            Controls.Add(label3);
            Controls.Add(labelDescriptions);
            Controls.Add(label1);
            Controls.Add(textBoxDescriptions);
            Controls.Add(textBoxTitle);
            Name = "FormEdit";
            Text = "FormEdit";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxDescriptions;
        private Label label1;
        private Label labelDescriptions;
        private Label label3;
        private Label labelCategory;
        private Button buttonSave;
        private ComboBox comboBoxCategories;
        private Button buttonEdit;
        private NumericUpDown numericUpDownPrice;
    }
}