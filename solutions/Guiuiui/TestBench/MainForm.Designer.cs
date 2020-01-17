namespace TestBench
{
    partial class MainForm
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
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.personListView = new System.Windows.Forms.ListView();
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personTable = new System.Windows.Forms.TableLayoutPanel();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTable = new System.Windows.Forms.TableLayoutPanel();
            this.cityTextBox2 = new System.Windows.Forms.TextBox();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox2 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.streetTextBox2 = new System.Windows.Forms.TextBox();
            this.streetTextBox1 = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.addressListView = new System.Windows.Forms.ListView();
            this.addressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address1Label = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.addressAddRemoveButtons = new Guiuiui.AddRemove.Buttons.StandardAddRemoveButtons();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.isVegetarianLabel = new System.Windows.Forms.Label();
            this.isVegetarianCheckBox = new System.Windows.Forms.CheckBox();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.personAddRemoveButtons = new Guiuiui.AddRemove.Buttons.StandardAddRemoveButtons();
            this.layoutTable.SuspendLayout();
            this.personTable.SuspendLayout();
            this.addressTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 4;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.Controls.Add(this.personListView, 1, 2);
            this.layoutTable.Controls.Add(this.personTable, 2, 2);
            this.layoutTable.Controls.Add(this.personAddRemoveButtons, 1, 1);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 5;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutTable.Size = new System.Drawing.Size(1189, 703);
            this.layoutTable.TabIndex = 0;
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumn,
            this.LastNameColumn});
            this.personListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personListView.FullRowSelect = true;
            this.personListView.GridLines = true;
            this.personListView.Location = new System.Drawing.Point(23, 44);
            this.personListView.MultiSelect = false;
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(224, 542);
            this.personListView.TabIndex = 0;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "First Name";
            this.firstNameColumn.Width = 100;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Text = "Last Name";
            this.LastNameColumn.Width = 100;
            // 
            // personTable
            // 
            this.personTable.ColumnCount = 2;
            this.personTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.personTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.personTable.Controls.Add(this.dateOfBirthDateTimePicker, 1, 4);
            this.personTable.Controls.Add(this.addressTable, 1, 8);
            this.personTable.Controls.Add(this.fullNameTextBox, 1, 3);
            this.personTable.Controls.Add(this.fullNameLabel, 0, 3);
            this.personTable.Controls.Add(this.nameLabel, 0, 1);
            this.personTable.Controls.Add(this.firstNameLabel, 0, 2);
            this.personTable.Controls.Add(this.genderLabel, 0, 5);
            this.personTable.Controls.Add(this.nameTextBox, 1, 1);
            this.personTable.Controls.Add(this.firstNameTextBox, 1, 2);
            this.personTable.Controls.Add(this.genderComboBox, 1, 5);
            this.personTable.Controls.Add(this.dateOfBirthLabel, 0, 4);
            this.personTable.Controls.Add(this.summaryLabel, 1, 0);
            this.personTable.Controls.Add(this.isVegetarianLabel, 0, 6);
            this.personTable.Controls.Add(this.isVegetarianCheckBox, 1, 6);
            this.personTable.Controls.Add(this.addressesLabel, 0, 8);
            this.personTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personTable.Location = new System.Drawing.Point(253, 44);
            this.personTable.Name = "personTable";
            this.personTable.RowCount = 10;
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.personTable.Size = new System.Drawing.Size(913, 542);
            this.personTable.TabIndex = 1;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(153, 111);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(757, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 8;
            // 
            // addressTable
            // 
            this.addressTable.ColumnCount = 5;
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addressTable.Controls.Add(this.cityTextBox2, 4, 4);
            this.addressTable.Controls.Add(this.cityTextBox1, 2, 4);
            this.addressTable.Controls.Add(this.postalCodeTextBox2, 4, 3);
            this.addressTable.Controls.Add(this.postalCodeTextBox1, 2, 3);
            this.addressTable.Controls.Add(this.streetTextBox2, 4, 2);
            this.addressTable.Controls.Add(this.streetTextBox1, 2, 2);
            this.addressTable.Controls.Add(this.cityLabel, 1, 4);
            this.addressTable.Controls.Add(this.postalCodeLabel, 1, 3);
            this.addressTable.Controls.Add(this.address2Label, 4, 1);
            this.addressTable.Controls.Add(this.addressListView, 0, 1);
            this.addressTable.Controls.Add(this.address1Label, 2, 1);
            this.addressTable.Controls.Add(this.streetLabel, 1, 2);
            this.addressTable.Controls.Add(this.addressAddRemoveButtons, 0, 0);
            this.addressTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTable.Location = new System.Drawing.Point(150, 203);
            this.addressTable.Margin = new System.Windows.Forms.Padding(0);
            this.addressTable.Name = "addressTable";
            this.addressTable.RowCount = 6;
            this.personTable.SetRowSpan(this.addressTable, 2);
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addressTable.Size = new System.Drawing.Size(763, 339);
            this.addressTable.TabIndex = 14;
            // 
            // cityTextBox2
            // 
            this.cityTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox2.Location = new System.Drawing.Point(584, 111);
            this.cityTextBox2.Name = "cityTextBox2";
            this.cityTextBox2.Size = new System.Drawing.Size(176, 20);
            this.cityTextBox2.TabIndex = 11;
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox1.Location = new System.Drawing.Point(383, 111);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(175, 20);
            this.cityTextBox1.TabIndex = 8;
            // 
            // postalCodeTextBox2
            // 
            this.postalCodeTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postalCodeTextBox2.Location = new System.Drawing.Point(584, 84);
            this.postalCodeTextBox2.Name = "postalCodeTextBox2";
            this.postalCodeTextBox2.Size = new System.Drawing.Size(176, 20);
            this.postalCodeTextBox2.TabIndex = 10;
            // 
            // postalCodeTextBox1
            // 
            this.postalCodeTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postalCodeTextBox1.Location = new System.Drawing.Point(383, 84);
            this.postalCodeTextBox1.Name = "postalCodeTextBox1";
            this.postalCodeTextBox1.Size = new System.Drawing.Size(175, 20);
            this.postalCodeTextBox1.TabIndex = 6;
            // 
            // streetTextBox2
            // 
            this.streetTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetTextBox2.Location = new System.Drawing.Point(584, 57);
            this.streetTextBox2.Name = "streetTextBox2";
            this.streetTextBox2.Size = new System.Drawing.Size(176, 20);
            this.streetTextBox2.TabIndex = 9;
            // 
            // streetTextBox1
            // 
            this.streetTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetTextBox1.Location = new System.Drawing.Point(383, 57);
            this.streetTextBox1.Name = "streetTextBox1";
            this.streetTextBox1.Size = new System.Drawing.Size(175, 20);
            this.streetTextBox1.TabIndex = 4;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityLabel.Location = new System.Drawing.Point(233, 108);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(144, 27);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postalCodeLabel.Location = new System.Drawing.Point(233, 81);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(144, 27);
            this.postalCodeLabel.TabIndex = 5;
            this.postalCodeLabel.Text = "Postal Code";
            this.postalCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address2Label.Location = new System.Drawing.Point(584, 27);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(176, 27);
            this.address2Label.TabIndex = 2;
            this.address2Label.Text = "Address 2";
            this.address2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressListView
            // 
            this.addressListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addressColumn});
            this.addressListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressListView.FullRowSelect = true;
            this.addressListView.GridLines = true;
            this.addressListView.Location = new System.Drawing.Point(3, 30);
            this.addressListView.Name = "addressListView";
            this.addressTable.SetRowSpan(this.addressListView, 5);
            this.addressListView.Size = new System.Drawing.Size(224, 306);
            this.addressListView.TabIndex = 0;
            this.addressListView.UseCompatibleStateImageBehavior = false;
            this.addressListView.View = System.Windows.Forms.View.Details;
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Address";
            this.addressColumn.Width = 200;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address1Label.Location = new System.Drawing.Point(383, 27);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(175, 27);
            this.address1Label.TabIndex = 1;
            this.address1Label.Text = "Address 1";
            this.address1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetLabel.Location = new System.Drawing.Point(233, 54);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(144, 27);
            this.streetLabel.TabIndex = 3;
            this.streetLabel.Text = "Street";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressAddRemoveButtons
            // 
            this.addressAddRemoveButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressAddRemoveButtons.Location = new System.Drawing.Point(3, 3);
            this.addressAddRemoveButtons.Name = "addressAddRemoveButtons";
            this.addressAddRemoveButtons.Size = new System.Drawing.Size(224, 21);
            this.addressAddRemoveButtons.TabIndex = 12;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameTextBox.Location = new System.Drawing.Point(153, 84);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(757, 20);
            this.fullNameTextBox.TabIndex = 6;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 81);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(144, 27);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "Full name (read only)";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 27);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Last Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(144, 27);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderLabel.Location = new System.Drawing.Point(3, 135);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(144, 27);
            this.genderLabel.TabIndex = 9;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(153, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(757, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(757, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(153, 138);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(757, 21);
            this.genderComboBox.TabIndex = 10;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(3, 108);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(144, 27);
            this.dateOfBirthLabel.TabIndex = 7;
            this.dateOfBirthLabel.Text = "Date of Birth";
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryLabel.Location = new System.Drawing.Point(153, 0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(757, 27);
            this.summaryLabel.TabIndex = 0;
            this.summaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isVegetarianLabel
            // 
            this.isVegetarianLabel.AutoSize = true;
            this.isVegetarianLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isVegetarianLabel.Location = new System.Drawing.Point(3, 162);
            this.isVegetarianLabel.Name = "isVegetarianLabel";
            this.isVegetarianLabel.Size = new System.Drawing.Size(144, 27);
            this.isVegetarianLabel.TabIndex = 11;
            this.isVegetarianLabel.Text = "Vegetarian";
            this.isVegetarianLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isVegetarianCheckBox
            // 
            this.isVegetarianCheckBox.AutoSize = true;
            this.isVegetarianCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isVegetarianCheckBox.Location = new System.Drawing.Point(153, 165);
            this.isVegetarianCheckBox.Name = "isVegetarianCheckBox";
            this.isVegetarianCheckBox.Size = new System.Drawing.Size(757, 21);
            this.isVegetarianCheckBox.TabIndex = 12;
            this.isVegetarianCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressesLabel.Location = new System.Drawing.Point(3, 203);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(144, 27);
            this.addressesLabel.TabIndex = 13;
            this.addressesLabel.Text = "Addresses";
            this.addressesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // personAddRemoveButtons
            // 
            this.personAddRemoveButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personAddRemoveButtons.Location = new System.Drawing.Point(23, 17);
            this.personAddRemoveButtons.Name = "personAddRemoveButtons";
            this.personAddRemoveButtons.Size = new System.Drawing.Size(224, 21);
            this.personAddRemoveButtons.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 703);
            this.Controls.Add(this.layoutTable);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.layoutTable.ResumeLayout(false);
            this.personTable.ResumeLayout(false);
            this.personTable.PerformLayout();
            this.addressTable.ResumeLayout(false);
            this.addressTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.TableLayoutPanel personTable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label isVegetarianLabel;
        private System.Windows.Forms.CheckBox isVegetarianCheckBox;
        private System.Windows.Forms.ColumnHeader LastNameColumn;
        private System.Windows.Forms.Label addressesLabel;
        private System.Windows.Forms.ListView addressListView;
        private System.Windows.Forms.ColumnHeader addressColumn;
        private System.Windows.Forms.TableLayoutPanel addressTable;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetTextBox1;
        private System.Windows.Forms.TextBox streetTextBox2;
        private System.Windows.Forms.TextBox postalCodeTextBox1;
        private System.Windows.Forms.TextBox postalCodeTextBox2;
        private System.Windows.Forms.TextBox cityTextBox2;
        private System.Windows.Forms.TextBox cityTextBox1;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private Guiuiui.AddRemove.Buttons.StandardAddRemoveButtons personAddRemoveButtons;
        private Guiuiui.AddRemove.Buttons.StandardAddRemoveButtons addressAddRemoveButtons;
    }
}

