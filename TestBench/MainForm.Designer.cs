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
            this.addressListView = new System.Windows.Forms.ListView();
            this.streetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postalCodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.layoutTable.SuspendLayout();
            this.personTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 4;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.Controls.Add(this.personListView, 1, 1);
            this.layoutTable.Controls.Add(this.personTable, 2, 1);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 4;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutTable.Size = new System.Drawing.Size(946, 703);
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
            this.personListView.Size = new System.Drawing.Size(294, 331);
            this.personListView.TabIndex = 0;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            this.personListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.personListView_ItemSelectionChanged);
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
            this.personTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.personTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
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
            this.personTable.Controls.Add(this.addressListView, 1, 8);
            this.personTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personTable.Location = new System.Drawing.Point(323, 17);
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
            this.personTable.Size = new System.Drawing.Size(600, 331);
            this.personTable.TabIndex = 1;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameTextBox.Location = new System.Drawing.Point(183, 84);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(414, 20);
            this.fullNameTextBox.TabIndex = 5;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 81);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(174, 27);
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
            this.nameLabel.Size = new System.Drawing.Size(174, 27);
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
            this.firstNameLabel.Size = new System.Drawing.Size(174, 27);
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
            this.genderLabel.Size = new System.Drawing.Size(174, 27);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(183, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(414, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Location = new System.Drawing.Point(183, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(414, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(183, 138);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(414, 21);
            this.genderComboBox.TabIndex = 9;
            // 
            // ageLagel
            // 
            this.ageLagel.AutoSize = true;
            this.ageLagel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageLagel.Location = new System.Drawing.Point(3, 108);
            this.ageLagel.Name = "ageLagel";
            this.ageLagel.Size = new System.Drawing.Size(174, 27);
            this.ageLagel.TabIndex = 6;
            this.ageLagel.Text = "Age";
            this.ageLagel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageTextBox.Location = new System.Drawing.Point(183, 111);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(414, 20);
            this.ageTextBox.TabIndex = 7;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryLabel.Location = new System.Drawing.Point(183, 0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(414, 27);
            this.summaryLabel.TabIndex = 10;
            this.summaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isVegetarianLabel
            // 
            this.isVegetarianLabel.AutoSize = true;
            this.isVegetarianLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isVegetarianLabel.Location = new System.Drawing.Point(3, 162);
            this.isVegetarianLabel.Name = "isVegetarianLabel";
            this.isVegetarianLabel.Size = new System.Drawing.Size(174, 27);
            this.isVegetarianLabel.TabIndex = 11;
            this.isVegetarianLabel.Text = "Vegetarian";
            this.isVegetarianLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // isVegetarianCheckBox
            // 
            this.isVegetarianCheckBox.AutoSize = true;
            this.isVegetarianCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isVegetarianCheckBox.Location = new System.Drawing.Point(183, 165);
            this.isVegetarianCheckBox.Name = "isVegetarianCheckBox";
            this.isVegetarianCheckBox.Size = new System.Drawing.Size(414, 21);
            this.isVegetarianCheckBox.TabIndex = 12;
            this.isVegetarianCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressesLabel.Location = new System.Drawing.Point(3, 203);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(174, 27);
            this.addressesLabel.TabIndex = 13;
            this.addressesLabel.Text = "Addresses";
            this.addressesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressListView
            // 
            this.addressListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.streetColumn,
            this.postalCodeColumn,
            this.cityColumn});
            this.addressListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressListView.FullRowSelect = true;
            this.addressListView.GridLines = true;
            this.addressListView.Location = new System.Drawing.Point(183, 206);
            this.addressListView.MultiSelect = false;
            this.addressListView.Name = "addressListView";
            this.personTable.SetRowSpan(this.addressListView, 2);
            this.addressListView.Size = new System.Drawing.Size(414, 122);
            this.addressListView.TabIndex = 14;
            this.addressListView.UseCompatibleStateImageBehavior = false;
            this.addressListView.View = System.Windows.Forms.View.Details;
            // 
            // streetColumn
            // 
            this.streetColumn.Text = "Street";
            this.streetColumn.Width = 100;
            // 
            // postalCodeColumn
            // 
            this.postalCodeColumn.Text = "Postal Code";
            this.postalCodeColumn.Width = 100;
            // 
            // cityColumn
            // 
            this.cityColumn.Text = "City";
            this.cityColumn.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 703);
            this.Controls.Add(this.layoutTable);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.layoutTable.ResumeLayout(false);
            this.personTable.ResumeLayout(false);
            this.personTable.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader streetColumn;
        private System.Windows.Forms.ColumnHeader postalCodeColumn;
        private System.Windows.Forms.ColumnHeader cityColumn;
    }
}

