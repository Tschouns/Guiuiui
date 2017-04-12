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
            this.addressTable = new System.Windows.Forms.TableLayoutPanel();
            this.addressListView = new System.Windows.Forms.ListView();
            this.addressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityTextBox2 = new System.Windows.Forms.TextBox();
            this.cityTextBox1 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox2 = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.streetTextBox2 = new System.Windows.Forms.TextBox();
            this.streetTextBox1 = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageLagel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.isVegetarianLabel = new System.Windows.Forms.Label();
            this.isVegetarianCheckBox = new System.Windows.Forms.CheckBox();
            this.addressesLabel = new System.Windows.Forms.Label();
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
            this.layoutTable.Controls.Add(this.personListView, 1, 1);
            this.layoutTable.Controls.Add(this.personTable, 2, 1);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 4;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
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
            this.personListView.Location = new System.Drawing.Point(23, 17);
            this.personListView.MultiSelect = false;
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(224, 569);
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
            this.personTable.Controls.Add(this.addressTable, 1, 8);
            this.personTable.Controls.Add(this.fullNameTextBox, 1, 3);
            this.personTable.Controls.Add(this.fullNameLabel, 0, 3);
            this.personTable.Controls.Add(this.nameLabel, 0, 1);
            this.personTable.Controls.Add(this.firstNameLabel, 0, 2);
            this.personTable.Controls.Add(this.genderLabel, 0, 5);
            this.personTable.Controls.Add(this.nameTextBox, 1, 1);
            this.personTable.Controls.Add(this.firstNameTextBox, 1, 2);
            this.personTable.Controls.Add(this.genderComboBox, 1, 5);
            this.personTable.Controls.Add(this.ageLagel, 0, 4);
            this.personTable.Controls.Add(this.ageTextBox, 1, 4);
            this.personTable.Controls.Add(this.summaryLabel, 1, 0);
            this.personTable.Controls.Add(this.isVegetarianLabel, 0, 6);
            this.personTable.Controls.Add(this.isVegetarianCheckBox, 1, 6);
            this.personTable.Controls.Add(this.addressesLabel, 0, 8);
            this.personTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personTable.Location = new System.Drawing.Point(253, 17);
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
            this.personTable.Size = new System.Drawing.Size(913, 569);
            this.personTable.TabIndex = 1;
            // 
            // addressTable
            // 
            this.addressTable.ColumnCount = 5;
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addressTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.addressTable.Controls.Add(this.cityTextBox2, 4, 3);
            this.addressTable.Controls.Add(this.cityTextBox1, 2, 3);
            this.addressTable.Controls.Add(this.postalCodeTextBox2, 4, 2);
            this.addressTable.Controls.Add(this.postalCodeTextBox1, 2, 2);
            this.addressTable.Controls.Add(this.streetTextBox2, 4, 1);
            this.addressTable.Controls.Add(this.streetTextBox1, 2, 1);
            this.addressTable.Controls.Add(this.cityLabel, 1, 3);
            this.addressTable.Controls.Add(this.postalCodeLabel, 1, 2);
            this.addressTable.Controls.Add(this.address2Label, 4, 0);
            this.addressTable.Controls.Add(this.addressListView, 0, 0);
            this.addressTable.Controls.Add(this.address1Label, 2, 0);
            this.addressTable.Controls.Add(this.streetLabel, 1, 1);
            this.addressTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTable.Location = new System.Drawing.Point(153, 206);
            this.addressTable.Name = "addressTable";
            this.addressTable.RowCount = 5;
            this.personTable.SetRowSpan(this.addressTable, 2);
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.addressTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addressTable.Size = new System.Drawing.Size(757, 360);
            this.addressTable.TabIndex = 2;
            // 
            // addressListView
            // 
            this.addressListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addressColumn});
            this.addressListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressListView.FullRowSelect = true;
            this.addressListView.GridLines = true;
            this.addressListView.Location = new System.Drawing.Point(3, 3);
            this.addressListView.Name = "addressListView";
            this.addressTable.SetRowSpan(this.addressListView, 5);
            this.addressListView.Size = new System.Drawing.Size(224, 354);
            this.addressListView.TabIndex = 14;
            this.addressListView.UseCompatibleStateImageBehavior = false;
            this.addressListView.View = System.Windows.Forms.View.Details;
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Address";
            this.addressColumn.Width = 200;
            // 
            // cityTextBox2
            // 
            this.cityTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox2.Location = new System.Drawing.Point(581, 84);
            this.cityTextBox2.Name = "cityTextBox2";
            this.cityTextBox2.Size = new System.Drawing.Size(173, 20);
            this.cityTextBox2.TabIndex = 25;
            // 
            // cityTextBox1
            // 
            this.cityTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox1.Location = new System.Drawing.Point(383, 84);
            this.cityTextBox1.Name = "cityTextBox1";
            this.cityTextBox1.Size = new System.Drawing.Size(172, 20);
            this.cityTextBox1.TabIndex = 24;
            // 
            // postalCodeTextBox2
            // 
            this.postalCodeTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postalCodeTextBox2.Location = new System.Drawing.Point(581, 57);
            this.postalCodeTextBox2.Name = "postalCodeTextBox2";
            this.postalCodeTextBox2.Size = new System.Drawing.Size(173, 20);
            this.postalCodeTextBox2.TabIndex = 23;
            // 
            // postalCodeTextBox1
            // 
            this.postalCodeTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postalCodeTextBox1.Location = new System.Drawing.Point(383, 57);
            this.postalCodeTextBox1.Name = "postalCodeTextBox1";
            this.postalCodeTextBox1.Size = new System.Drawing.Size(172, 20);
            this.postalCodeTextBox1.TabIndex = 22;
            // 
            // streetTextBox2
            // 
            this.streetTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetTextBox2.Location = new System.Drawing.Point(581, 30);
            this.streetTextBox2.Name = "streetTextBox2";
            this.streetTextBox2.Size = new System.Drawing.Size(173, 20);
            this.streetTextBox2.TabIndex = 21;
            // 
            // streetTextBox1
            // 
            this.streetTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetTextBox1.Location = new System.Drawing.Point(383, 30);
            this.streetTextBox1.Name = "streetTextBox1";
            this.streetTextBox1.Size = new System.Drawing.Size(172, 20);
            this.streetTextBox1.TabIndex = 20;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityLabel.Location = new System.Drawing.Point(233, 81);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(144, 27);
            this.cityLabel.TabIndex = 19;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postalCodeLabel.Location = new System.Drawing.Point(233, 54);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(144, 27);
            this.postalCodeLabel.TabIndex = 18;
            this.postalCodeLabel.Text = "Postal Code";
            this.postalCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address2Label.Location = new System.Drawing.Point(581, 0);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(173, 27);
            this.address2Label.TabIndex = 16;
            this.address2Label.Text = "Address 2";
            this.address2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address1Label.Location = new System.Drawing.Point(383, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(172, 27);
            this.address1Label.TabIndex = 15;
            this.address1Label.Text = "Address 1";
            this.address1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetLabel.Location = new System.Drawing.Point(233, 27);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(144, 27);
            this.streetLabel.TabIndex = 17;
            this.streetLabel.Text = "Street";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameTextBox.Location = new System.Drawing.Point(153, 84);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(757, 20);
            this.fullNameTextBox.TabIndex = 5;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 81);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(144, 27);
            this.fullNameLabel.TabIndex = 4;
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
            this.nameLabel.TabIndex = 0;
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
            this.firstNameLabel.TabIndex = 2;
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
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(153, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(757, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Location = new System.Drawing.Point(153, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(757, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(153, 138);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(757, 21);
            this.genderComboBox.TabIndex = 9;
            // 
            // ageLagel
            // 
            this.ageLagel.AutoSize = true;
            this.ageLagel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageLagel.Location = new System.Drawing.Point(3, 108);
            this.ageLagel.Name = "ageLagel";
            this.ageLagel.Size = new System.Drawing.Size(144, 27);
            this.ageLagel.TabIndex = 6;
            this.ageLagel.Text = "Age";
            this.ageLagel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageTextBox.Location = new System.Drawing.Point(153, 111);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(757, 20);
            this.ageTextBox.TabIndex = 7;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryLabel.Location = new System.Drawing.Point(153, 0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(757, 27);
            this.summaryLabel.TabIndex = 10;
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
        private System.Windows.Forms.Label ageLagel;
        private System.Windows.Forms.TextBox ageTextBox;
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
    }
}

